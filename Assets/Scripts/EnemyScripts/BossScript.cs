using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossScript : EnemyScript {
    /*
    public string bossName;
    public bool midboss = false;
    public Material spellBack;
    public Vector2 scrollSpeed;
    float barValue;
    BackgroundManagerScript backgroundManager;

    [System.Serializable]
    public class Live
    {
        public int hitPoints;
        public CarePackageScript carePack;
    }
    public Live[] lives;
    public int curLife;
    public AudioClip lifeClip;

    GameObject canvas;
    Text nameText;
    Slider slider;
    StageScript stageManager;
    public PatternScript patternScript;

    private void Start()
    {
        backgroundManager = GameObject.FindGameObjectWithTag("BackgroundManager").GetComponent<BackgroundManagerScript>();
        stageManager = GameObject.FindGameObjectWithTag("StageManager").GetComponent<StageScript>();
        stageManager.PauseSpawns();
        canvas = GameObject.FindGameObjectWithTag("BossCanvas");
        nameText = canvas.transform.FindChild("NameText").GetComponent<Text>();
        nameText.text = bossName;
        slider = canvas.transform.FindChild("HealthBar").GetComponent<Slider>();
        curLife = lives.Length - 1;
        curHealth = lives[curLife].hitPoints;
        StartCoroutine(SetHealthBar());
    }

    void Update()
    {
        if (curHealth <= 0 && !destroying)
        {
            if(spellBack)
                backgroundManager.UnSetSpellcard();

            if (curLife == 0)
            {
                destroying = true;
                StartCoroutine(Destroy());
            }
            else
            {
                NextLife();
            }
        }
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
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

    protected override void OnTriggerStay2D(Collider2D collision)
    {
        if ((collision.CompareTag("PlayerLaser") || collision.tag == "BombShot") &canBeDamaged) 
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

    IEnumerator SetHealthBar()
    {
        barValue = 0;

        while (barValue < (((float)curHealth) / ((float)lives[curLife].hitPoints)))
        {
            barValue += (float)0.01;
            slider.value = barValue;
            yield return new WaitForEndOfFrame();
        }
        StartCoroutine(UpdateHealthBar());
        StopCoroutine(SetHealthBar());
    }

    IEnumerator UpdateHealthBar()
    {
        while (curHealth >= 0)
        {
            barValue = ((float)curHealth) / ((float)lives[curLife].hitPoints);
            slider.value = barValue;
            yield return new WaitForEndOfFrame();
        }
        StopCoroutine(UpdateHealthBar());
    }

    void NextLife()
    {
        if (lifeClip)
        {
            GameObject audioClp = AudioScript.PlayClipAt(lifeClip, transform.position, .7f);
        }

        ClearBulletsScript.ClearEnemyLasers();
        StartCoroutine(ClearBulletsScript.ClearEnemy());
        if (lives[curLife].carePack)
            lives[curLife].carePack.Drop((Vector2)gameObject.transform.position);

        curLife--;

        curHealth = lives[curLife].hitPoints;
        StartCoroutine(SetHealthBar());
        patternScript.NextPattern();
    }

    protected override IEnumerator Destroy()
    {
        nameText.text = "";
        slider.value = 0;
        hitBox.enabled = false;
        stageManager.UnpauseSpawns();
        playerManager.AddScore(points);
        ClearBulletsScript.ClearEnemyLasers();
        ClearBulletsScript.EnemyToStar();
        StartCoroutine(ClearBulletsScript.ClearEnemy());
        if (destClip)
        {
            GameObject audioClp = AudioScript.PlayClipAt(destClip, transform.position, .7f);
        }
        if (lives[curLife].carePack)
            lives[curLife].carePack.Drop((Vector2)gameObject.transform.position);
        else if (itemPrefab)
            DropItem();

        if (GetComponent<Animator>())
            GetComponent<Animator>().Stop();

        if (GetComponent<PatternScript>())
            GetComponent<PatternScript>().StopPattern();

        if (deathShot)
            deathShot.StartShoot();

        if (destSprite)
        {
            SpriteRenderer sRender = gameObject.GetComponent<SpriteRenderer>();
            sRender.sprite = destSprite;
            gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            Vector3 iscale = gameObject.transform.localScale;
            Vector3 escale = new Vector3(gameObject.transform.localScale.x + 2, gameObject.transform.localScale.y + 2, 1);
            Color32 curColor = sRender.color;
            Color32 endColor = new Color32(255, 255, 255, 0);
            float t = 0;
            while (t < 1)
            {
                t += 1 * Time.deltaTime;
                gameObject.transform.localScale = Vector3.Lerp(iscale, escale, t);
                sRender.color = Color32.Lerp(curColor, endColor, t);
                yield return new WaitForFixedUpdate();
            }
        }
        Destroy(gameObject);
    }
    */
}
