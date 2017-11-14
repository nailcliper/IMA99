using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    //GameObject player;
    Animator anim;
    public GameObject starPrefab;
    SpriteRenderer sRender;
    public Sprite sprite;
    public Sprite clearSprite;
    Collider2D hitbox;

    public int power;
    public float speed;
    public float startSpeed;
    public float endSpeed;
    public float speedTime;
    float driftX = 0;
    float driftTime;
    public Vector2 startPos;
    public Vector2 endPos;
    public bool hasGrazed = false;
    bool isBomb = false;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        hitbox = gameObject.GetComponent<Collider2D>();
        sRender = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        if (CompareTag("EnemyShot"))
            ClearBulletsScript.eBullets.Add(this);

        if (hitbox.bounds.Intersects(GameObject.FindGameObjectWithTag("STGBox").GetComponent<Collider2D>().bounds))
        {
            sRender.sprite = sprite;
            hitbox.enabled = true;
            hasGrazed = false;
            startPos = gameObject.transform.position;
            endPos = startPos + new Vector2(
                (gameObject.transform.up.x * 30) + driftX,
                gameObject.transform.up.y * 30);

            StartCoroutine(MoveObject());
            if (speedTime > 0)
            {
                startSpeed = speed;
                StartCoroutine(AccelerateObject());
            }
        }
        else
        {
            gameObject.SetActive(false);
        }

    }

    private void OnDisable()
    {
        if (CompareTag("EnemyShot"))
            ClearBulletsScript.eBullets.Remove(this);

        anim.StopPlayback();
        StopAllCoroutines();
    }

    public void SetSpeed(float ispeed, float iendSpeed = 0, float ispeedTime = 0, float idriftX = 0)
    {
        speed = ispeed;
        endSpeed = iendSpeed;
        speedTime = ispeedTime;
        driftX = idriftX;
    }

    public void SetPower(int ipower = 1)
    {
        power = ipower;
    }

    //Moves bullet (m/s) * s distance between current and end position
    IEnumerator MoveObject()
    {
        while ((Vector2)gameObject.transform.position != endPos)
        {
            gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, endPos, speed * Time.deltaTime);
            yield return new WaitForFixedUpdate();
        }
    }

    //Changes bullet speed from start to end in time seconds
    IEnumerator AccelerateObject()
    {
        float i = 0;
        float rate = 1 / speedTime;
        while (i < 1)
        {
            i += Time.deltaTime * rate;
            speed = Mathf.Lerp(startSpeed, endSpeed, i);
            yield return new WaitForFixedUpdate();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyShot" && isBomb)
        {
            collision.GetComponent<BulletScript>().Erase(true);
        }
    }

    public void Erase(bool bomb = false)
    {
        if (bomb)
        {
            GameObject obj = Instantiate(starPrefab);
            obj.transform.position = transform.position;
            obj.SetActive(true);
        }
        Disable();
    }

    public void Disable()
    {
        Coroutine routine = StartCoroutine(DisableBullet());
    }

    private IEnumerator DisableBullet()
    {
        hitbox.enabled = false;
        startSpeed = speed;
        endSpeed = 0;
        speedTime = 0.1f;
        StartCoroutine(AccelerateObject());
        sRender.sprite = clearSprite;
        anim.Play("BulletClear");
        yield return new WaitForSeconds(0.2f);
        gameObject.SetActive(false);
    }

    public bool HasGrazed() { return hasGrazed; }
    public void SetHasGrazed(bool i = true) { hasGrazed = i; }
    public void SetIsBomb(bool bomb = true) { isBomb = bomb; }
}
