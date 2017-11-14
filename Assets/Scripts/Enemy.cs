using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{

    public Sprite charSprite;
    public Sprite killSprite;
    public int hitPoints;
    public int points;
    public AudioClip killClip;

    bool canBeDamaged;
    int curHealth;
    CircleCollider2D hitBox;
    /*
    public int points = 1000;
    public GameObject itemPrefab;
    public CarePackageScript carePack;
    public int curHealth = 15;
    public CircleCollider2D hitBox;
    protected PlayerManagerScript playerManager;
    public MoveScript move;
    public AudioClip destClip;
    public EnemyBulletFireScript deathShot;
    public Sprite destSprite;
    public bool canBeDamaged;
    Coroutine destRoutine;
    protected bool destroying = false;
    */

    void Awake()
    {
        curHealth = hitPoints;
        hitBox = transform.GetChild(0).GetComponent<CircleCollider2D>();
        canBeDamaged = false;
    }

    public void Damage(int _damage)
    {
        curHealth -= _damage;
        if (curHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    /*
    protected virtual IEnumerator Destroy()
    {
        foreach (Transform child in gameObject.transform)
        {
            if (child.gameObject.CompareTag("Laser"))
            {
                child.SetParent(null);
                foreach (Transform grandchild in child.transform)
                {
                    grandchild.GetComponentInChildren<LaserScript>().StartFadeOut();
                }
            }
        }
        
        hitBox.enabled = false;
        playerManager.AddScore(points);
        if (killClip)
        {
            GameObject audioClp = AudioScript.PlayClipAt(killClip, transform.position, .3f);
        }
        if (carePack)
            carePack.Drop((Vector2)gameObject.transform.position);
        else if (itemPrefab)
            DropItem();

        if (GetComponent<Animator>())
            GetComponent<Animator>().Stop();

        if (GetComponent<PatternScript>())
            GetComponent<PatternScript>().StopPattern();

        if (deathShot)
            deathShot.StartShoot();

        if (destSprite && (GetComponent<SpriteRenderer>() || transform.GetChild(0).GetComponent<SpriteRenderer>()))
        {
            SpriteRenderer sRender;
            if (GetComponent<SpriteRenderer>())
                sRender = gameObject.GetComponent<SpriteRenderer>();
            else
                sRender = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();

            sRender.sprite = destSprite;
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            Vector3 iscale = gameObject.transform.localScale;
            Vector3 escale = new Vector3(gameObject.transform.localScale.x + 1, gameObject.transform.localScale.y + 1, 1);
            Color32 curColor = sRender.color;
            Color32 endColor = new Color32(255, 255, 255, 0);
            float t = 0;
            while (t < 1)
            {
                t += 3 * Time.deltaTime;
                gameObject.transform.localScale = Vector3.Lerp(iscale, escale, t);
                sRender.color = Color32.Lerp(curColor, endColor, t);
                yield return new WaitForFixedUpdate();
            }
        }
        Destroy(gameObject);

        /*

        void Update()
        {
            if (curHealth <= 0 && !destroying)
            {
                destroying = true;
                StartCoroutine(Destroy());
            }
        }

        protected virtual void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "PlayerShot" && canBeDamaged)
            {
                if (collision.tag == "PlayerShot")
                {
                    collision.gameObject.GetComponent<BulletScript>().Disable();
                }
                playerManager.AddScore(collision.GetComponent<BulletScript>().power);
                curHealth -= collision.GetComponent<BulletScript>().power;
            }
            else if (!canBeDamaged && collision.gameObject.CompareTag("STGBox"))
                canBeDamaged = true;
        }

        protected virtual void OnTriggerStay2D(Collider2D collision)
        {
            if((collision.CompareTag("PlayerLaser") || collision.CompareTag("BombShot")) && canBeDamaged)
            {
                if (collision.GetComponent<LaserScript>())
                {
                    playerManager.AddScore(collision.GetComponent<LaserScript>().power);
                    curHealth -= collision.GetComponent<LaserScript>().power;
                }
                else
                {
                    playerManager.AddScore(collision.GetComponent<BulletScript>().power);
                    curHealth -= collision.GetComponent<BulletScript>().power;
                }
            }
        }

        protected void DropItem()
        {
            GameObject item = Instantiate(itemPrefab);
            item.transform.position = transform.position;
            item.SetActive(true);
        }

        protected virtual IEnumerator Destroy()
        {
            foreach (Transform child in gameObject.transform)
            {
                if(child.gameObject.CompareTag("Laser"))
                {
                    child.SetParent(null);
                    foreach (Transform grandchild in child.transform)
                    {
                        grandchild.GetComponentInChildren<LaserScript>().StartFadeOut();
                    }
                }
            }

            hitBox.enabled = false;
            playerManager.AddScore(points);
            if (destClip)
            {
                GameObject audioClp = AudioScript.PlayClipAt(destClip, transform.position, .3f);
            }
            if (carePack)
                carePack.Drop((Vector2)gameObject.transform.position);
            else if (itemPrefab)
                DropItem();

            if (GetComponent<Animator>())
                GetComponent<Animator>().Stop();

            if (GetComponent<PatternScript>())
                GetComponent<PatternScript>().StopPattern();

            if (deathShot)
                deathShot.StartShoot();

            if (destSprite && (GetComponent<SpriteRenderer>() || transform.GetChild(0).GetComponent<SpriteRenderer>()))
            {
                SpriteRenderer sRender;
                if (GetComponent<SpriteRenderer>())
                    sRender = gameObject.GetComponent<SpriteRenderer>();
                else
                    sRender = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();

                sRender.sprite = destSprite;
                gameObject.transform.localScale = new Vector3(1, 1, 1);
                Vector3 iscale = gameObject.transform.localScale;
                Vector3 escale = new Vector3(gameObject.transform.localScale.x + 1, gameObject.transform.localScale.y + 1, 1);
                Color32 curColor = sRender.color;
                Color32 endColor = new Color32(255, 255, 255, 0);
                float t = 0;
                while (t < 1)
                {
                    t += 3 * Time.deltaTime;
                    gameObject.transform.localScale = Vector3.Lerp(iscale, escale, t);
                    sRender.color = Color32.Lerp(curColor, endColor, t);
                    yield return new WaitForFixedUpdate();
                }
            }
            Destroy(gameObject);
        }
    }
    */
}
