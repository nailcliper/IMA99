using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitbox : MonoBehaviour {

    SpriteRenderer hitboxSprite;
    Collider2D hitbox;
    Coroutine fadeRoutine;
    Coroutine killRoutine;

    void Awake()
    {
        hitboxSprite = transform.GetComponentInChildren<SpriteRenderer>();
        hitbox = transform.GetComponent<Collider2D>();
        hitboxSprite.color = new Color(1, 1, 1, 0);
    }

    void OnEnable()
    {
        hitboxSprite.color = new Color(1, 1, 1, 0);
        EventManager.Events.OnFocus += FadeIn;
        EventManager.Events.OnUnfocus += FadeOut;
        EventManager.Events.OnBombStart += DisableHitbox;
        EventManager.Events.OnBombEnd += EnableHitbox;
    }

    void OnDiable()
    {
        StopAllCoroutines();

        EventManager.Events.OnFocus -= FadeIn;
        EventManager.Events.OnUnfocus -= FadeOut;
        EventManager.Events.OnBombStart -= DisableHitbox;
        EventManager.Events.OnBombEnd -= EnableHitbox;
    }

    public void EnableHitbox() { hitbox.enabled = true; }
    public void DisableHitbox() { hitbox.enabled = false; }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 9)
        {
            /*
            if (collision.CompareTag("Bullet"))
            {
                //DisableBullet
            }
            */

            killRoutine = StartCoroutine(Kill());
        }
    }

    void CancelKill()
    {
        if (killRoutine != null)
            StopCoroutine(killRoutine);
    }

    IEnumerator Kill()
    {
        DisableHitbox();
        AudioScript.PlayClipAt(AudioManager.Audio.playerDead, transform.position, 0.6f);
        yield return new WaitForSeconds(0.05f);

        SpriteRenderer sRender = PlayerManager.PlayerInfo.player.transform.GetChild(0).GetComponent<SpriteRenderer>();
        PlayerManager.PlayerInfo.player.GetComponent<InputManager>().enabled = false;
        PlayerManager.PlayerInfo.player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        float t = 0;
        while (t < 1f)
        {
            t += 4 * Time.deltaTime;
            sRender.color = new Color(1, 1, 1, Mathf.Lerp(1, 0, t));
            yield return new WaitForFixedUpdate();
        }

        PlayerManager.PlayerInfo.player.SetActive(false);
        EventManager.Events.SendPlayerDeath();
    }

    void FadeIn()
    {
        if(fadeRoutine != null)
            StopCoroutine(fadeRoutine);
        fadeRoutine = StartCoroutine(Fade(1));
    }

    IEnumerator Fade(byte color)
    {
        while(hitboxSprite.color.a != color)
        {
            hitboxSprite.color = new Color(1, 1, 1, Mathf.MoveTowards(hitboxSprite.color.a, color, 3 * Time.deltaTime));
            yield return new WaitForFixedUpdate();
        }
    }

    void FadeOut()
    {
        StopCoroutine(fadeRoutine);
        fadeRoutine = StartCoroutine(Fade(0));
    }
}
