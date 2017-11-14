using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public Sprite bulletSprite;
    public Sprite clearSprite;

    GameObject bSprite;
    SpriteRenderer sRenderer;
    Collider2D hitbox;
    Collider2D STGBox;
    float startAlpha;
    Rigidbody2D bulletRigidbody;

    public float startSpeed;
    public float endSpeed;
    public float acceleration;
    public float speed;

    public Vector2 startSpeedVec;
    public Vector2 endSpeedVec;
    public Vector2 accelerationVec;
    public Vector2 speedVec;

    void Awake()
    {
        bSprite = transform.GetChild(0).gameObject;
        STGBox = GameObject.FindGameObjectWithTag("STGBox").GetComponent<Collider2D>();
        sRenderer = bSprite.GetComponent<SpriteRenderer>();
        startAlpha = sRenderer.color.a;
        hitbox = bSprite.GetComponent<Collider2D>();
        bulletRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        if (hitbox.bounds.Intersects(STGBox.bounds))
        {
            sRenderer.sprite = bulletSprite;
            sRenderer.color = new Color(1, 1, 1, startAlpha);
            hitbox.enabled = true;
        }
        else
        {
            gameObject.SetActive(false);
        }

        if(gameObject.layer == 9)
        {
            EventManager.Events.OnPlayerDeath += Disable;
        }
    }

    void OnDisable()
    {
        StopAllCoroutines();

        if(gameObject.layer == 9)
        {
            EventManager.Events.OnPlayerDeath -= Disable;
        }

    }

    IEnumerator Move()
    {
        while(true)
        {
            bulletRigidbody.MovePosition(transform.position + (transform.up * Time.deltaTime * speed));
            yield return new WaitForFixedUpdate();
        }
    }
    /*
    void FixedUpdate()
    {
        if(!vecMove)
            bulletRigidbody.MovePosition(transform.position + (transform.up * Time.deltaTime * speed));
    }
    */

    public void Disable()
    {
        Coroutine routine = StartCoroutine(DisableBullet());
    }

    private IEnumerator DisableBullet()
    {
        hitbox.enabled = false;
        sRenderer.sprite = clearSprite;
        Transform trans = bSprite.gameObject.transform;
        Vector3 endScale = new Vector3(trans.localScale.x * 1.2f, trans.localScale.y * 1.2f, 1);
        Vector3 startScale = trans.localScale = new Vector3(trans.localScale.x * 0.8f, trans.localScale.y * 0.8f, 1);
        float t = 0;
        while(t < 1)
        {
            t += Time.deltaTime / 0.2f;
            trans.localScale = Vector3.Lerp(startScale, endScale, t);
            sRenderer.color = new Color(sRenderer.color.r, sRenderer.color.g, sRenderer.color.b, Mathf.Lerp(startAlpha, 0, t));
            yield return new WaitForFixedUpdate();
        }
        yield return new WaitForSeconds(0.2f);
        gameObject.SetActive(false);
    }

    IEnumerator AccelerateBullet(float accel)
    {
        while(speed != endSpeed)
        {
            speed += accel;
            yield return new WaitForFixedUpdate();
        }
    }

    IEnumerator AccelerateBullet(Vector2 accel)
    {
        while (speedVec != endSpeedVec)
        {
            speedVec = new Vector2(
                Mathf.MoveTowards(speedVec.x, endSpeedVec.x, accel.x),
                Mathf.MoveTowards(speedVec.y, endSpeedVec.y, accel.y));
            bulletRigidbody.velocity = speedVec;
            yield return new WaitForFixedUpdate();
        }
    }

    public void SetSpeed(float _start, float _end = 0, float _accel = 0)
    {
        startSpeed = _start;
        endSpeed = _end;
        acceleration = _accel;
        speed = startSpeed;

        StartCoroutine(Move());
        if (acceleration != 0)
            StartCoroutine(AccelerateBullet(acceleration));
    }

    public void SetSpeed(Vector2 _start, Vector2 _end, Vector2 _accel)
    {
        startSpeedVec = _start;
        endSpeedVec = _end;
        accelerationVec = _accel;
        speedVec = startSpeedVec;

        bulletRigidbody.velocity = _start;
        if (accelerationVec.magnitude != 0)
            StartCoroutine(AccelerateBullet(accelerationVec));
    }

}
