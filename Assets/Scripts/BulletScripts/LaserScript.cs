using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour {
    /*
    public GameObject owner;

    public float growDelay;
    public float growTime;
    public float width;
    public float length;
    public float fireTime;
    public int power = 1;
    public AudioClip laserClip;
    [Range(0, 1)]
    public float volume = 0.1f;
    bool isBomb = false;
    bool hasGrazed = false;

    Collider2D hitBox;
    SpriteRenderer spriteRenderer;
    Color32 curColor;
    Color32 clear = new Color32(255, 255, 255, 0);
    Color32 white = new Color32(255, 255, 255, 255);

    void Awake()
    {
        if(gameObject.CompareTag("EnemyLaser"))
            ClearBulletsScript.eLasers.Add(this);

        hitBox = gameObject.GetComponent<Collider2D>();
        hitBox.enabled = false;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        curColor = spriteRenderer.color;
    }

    void OnEnable()
    {
        //spriteRenderer.sprite = laserSprite;
        //spriteRenderer.color = white;
        //curColor = white;
        spriteRenderer.sortingLayerName = "Laser";
        gameObject.transform.localScale = new Vector3(0.15f, length, 1);
        StartCoroutine(FireLaser());
        hasGrazed = false;
    }

    void OnDisable()
    {
        if (gameObject.CompareTag("EnemyLaser"))
            ClearBulletsScript.eLasers.Remove(this);
        StopAllCoroutines();
        Transform container = gameObject.transform.parent;
        if (container.parent.CompareTag("Laser"))
            Destroy(container.parent.gameObject);
        else
            Destroy(container.gameObject);

        /*
        if (owner)
        {
            if (owner.GetComponent<EnemyScript>())
            {
                owner.GetComponent<EnemyScript>().activeLasers.Remove(gameObject);
            }
        }
        */
        /*
    }

    IEnumerator FireLaser()
    {
        if (laserClip != null)
        {
            GameObject audioClip = AudioScript.PlayClipAt(laserClip, transform.position, volume);
        }

        if (growDelay > 0)
        {
            yield return new WaitForSeconds(growDelay);
        }

        hitBox.enabled = true;
        StartCoroutine(FadeIn());

        float t = 0;
        while (t < fireTime)
        {
            t += Time.deltaTime;

            yield return new WaitForFixedUpdate();
        }

        StartCoroutine(FadeOut());
    }

    IEnumerator FadeIn()
    {
        float t = 0;
        while (t < 1)
        {
            t += (Time.deltaTime / growTime);
            gameObject.transform.localScale = new Vector3(Mathf.Lerp(0.15f, width, t), length, 1);
            yield return new WaitForFixedUpdate();
        }
        //hitBox.enabled = true;
    }

    public void StartFadeOut()
    {
        hitBox.enabled = false;
        StartCoroutine(FadeOut());
    }
    IEnumerator FadeOut()
    {
        float t = 0;
        float startW = gameObject.transform.localScale.x;
        while (t < 1)
        {
            t += Time.deltaTime;

            if (t >= 0.75)
                hitBox.enabled = false;

            spriteRenderer.color = Color32.Lerp(curColor, clear, t);
            gameObject.transform.localScale = new Vector3(Mathf.Lerp(startW, 0, t), gameObject.transform.localScale.y, 1);

            yield return new WaitForFixedUpdate();
        }

        if (gameObject.transform.parent.CompareTag("Laser"))
            Destroy(gameObject.transform.parent.gameObject);
        else
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyShot" && isBomb)
        {
            collision.GetComponent<BulletScript>().Erase(true);
        }
    }

    public void SetDelay(float d) { growDelay = d; }
    public void SetGrowTime(float g) { growTime = g; }
    public void SetWidth(float w) { width = w; }
    public void SetLength(float l ) { length = l; }
    public void SetFireTime(float f) { fireTime = f; }
    public void SetPower(int p) { power = p; }
    public void SetIsBomb(bool bomb = true) { isBomb = bomb; }
    public void setClip(AudioClip clip, float vol) { laserClip = clip; volume = vol; }

    public void SetLaserProperties(GameObject o, float d, float g, float w, float l, float f, int p, bool b = false)
    {
        owner = o;
        growDelay = d;
        growTime = g;
        width = w;
        length = l;
        fireTime = f;
        power = p;
        isBomb = b;
    }

    public bool HasGrazed() { return hasGrazed; }

    public IEnumerator SetGraze()
    {
        hasGrazed = true;
        yield return new WaitForSeconds(0.1f);
        hasGrazed = false;
    }
    public void SetHasGrazed() {
        Coroutine grazeRoutine = StartCoroutine(SetGraze());
    }
    */
}
