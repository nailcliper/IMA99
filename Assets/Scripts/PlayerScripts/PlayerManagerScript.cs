using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagerScript : MonoBehaviour {
    /*
    public GameObject[] types;
    public GameObject playerPrefab;
    GameObject player;
    public Vector2 spawnPoint;
    public PauseScript pauseMenu;
    public CarePackageScript powerPack;
    public CarePackageScript fullPack;

    public int score = 0;
    public int lives = 5;
    public int bombs = 3;
    public int power = 0;
    public int graze = 0;
    public int point = 0;

    const int maxLevel = 6;
    int[] levels = new int[maxLevel] { 0, 16, 48, 80, 96, 128 };
    public int currentLevel = 0;

    List<Transform> bulletSpawners;
    List<Transform> laserSpawners;
    BombFireScript bombScript;
    bool isBombing = false;
    bool isInvincible = false;
    bool isCollecting = false;
    bool isFocused = false;

    UIScript uiManager;
    AudioSource sfx;
    public AudioClip extendClip;
    public AudioClip powerClip;

    void Awake()
    {
        Time.timeScale = 0;

        sfx = gameObject.GetComponent<AudioSource>();
        uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIScript>();
        pauseMenu = GameObject.Find("PauseMenu").GetComponent<PauseScript>();
    }

    public void LevelChange(int level = 0)
    {
        currentLevel = level;

        for (int i = 0; i < bulletSpawners.Count; i++)
        {
            bulletSpawners[i].GetComponent<PlayerBulletFireScript>().SetLevel(currentLevel);
        }
        for (int i = 0; i < laserSpawners.Count; i++)
            laserSpawners[i].GetComponent<PlayerLaserFireScript>().SetLevel(currentLevel);
    }

    public void AddPower(int value)
    {
        if (value > 0 && power < 128)
        {
            power += value;

            if (power >= 128)
            {
                ClearBulletsScript.EnemyToStar();
                power = 128;
                uiManager.SetString("MAX", 3);
                /*
                foreach (GameObject item in ItemScript.ItemList)
                {
                    item.GetComponent<ItemScript>().AutoCollect();
                }
                */
                /*
            }
            else
            {
                uiManager.SetString(power.ToString(), 3);
            }

            if (levels[currentLevel + 1] <= power)
            {
                for (int i = currentLevel; i < 6; i++)
                    if (levels[currentLevel + 1] <= power)
                        currentLevel = i;

                GameObject audioClip = AudioScript.PlayClipAt(powerClip, player.transform.position, 0.8f);
                LevelChange(currentLevel);
            }
        }
        else if (value < 0 && power > 0)
        {
            power += value;

            if (power < 0)
                power = 0;

            uiManager.SetString(power.ToString(), 3);

            if (levels[currentLevel] > power)
            {
                for (int i = currentLevel; i >= 0; i--)
                    if (levels[currentLevel] > power)
                        currentLevel = i;

                LevelChange(currentLevel);
            }
        }
    }

    public IEnumerator SpawnPlayer(float respawnDelay = 0)
    {
        yield return new WaitForSeconds(respawnDelay);
        player.transform.position = spawnPoint;
        isBombing = false;
        isCollecting = false;
        isInvincible = true;
        player.SetActive(true);
        StartCoroutine(InvAnim());
        yield return new WaitForSeconds(2f);
        if(!isBombing)
            isInvincible = false;
    }

    IEnumerator InvAnim()
    {
        SpriteRenderer sRender = player.GetComponent<SpriteRenderer>();
        Color32 full = new Color32(200, 200, 200, 255);
        Color32 half = new Color32(128, 128, 128, 255);
        bool isFull = true;
        int count = 19;
        while (count > 0)
        {
            count--;
            isFull = !isFull;
            if (isFull)
                sRender.color = full;
            else
                sRender.color = half;
            yield return new WaitForSeconds(0.1f);
        }
        sRender.color = new Color32(255, 255, 255, 255);
    }

    public void RespawnPlayer()
    {
        LoseLife();
        StartCoroutine(SpawnPlayer(1));
    }
    public void AddLife(int i = 1) {
        GameObject audioClip = AudioScript.PlayClipAt(extendClip, player.transform.position, 0.8f);
        lives += i; uiManager.SetString(lives.ToString(), 1);
    }
    public void AddBomb(int i = 1) { bombs += i; uiManager.SetString(bombs.ToString(), 2); }
    public void SetInvincible(bool i = true) { isInvincible = i; }
    public void SetIsBombing(bool i = true) { isBombing = i; }
    public void SetIsCollecting(bool i = true) { isCollecting = i; }
    public void SetIsFocused(bool i = true) { isFocused = i; }

    public void LoseLife()
    {
        lives--;
        if (lives < 0)
        {
            //ResetPower();
            fullPack.Drop((Vector2)player.transform.position);
            ActivateGOScreen();
        }
        else
        {
            ResetBombs();
            AddPower(-16);
            powerPack.Drop((Vector2)player.transform.position);
            uiManager.SetString(lives.ToString(), 1);
        }
        StartCoroutine(ClearBulletsScript.ClearEnemy(0.5f));
    }

    public void AddScore(int scoreValue)
    {
        score += scoreValue;
        uiManager.SetString(score.ToString(), 0);
    }

    public void AddPoint()
    {
        point++;
        uiManager.SetString(point.ToString(), 5);
    }

    public void AddGraze(int grazeValue)
    {
        score += grazeValue;
        graze++;
        uiManager.SetString(graze.ToString(), 4);
        uiManager.SetString(score.ToString(), 0);
    }

    public void SetPlayerType(int i) { playerPrefab = types[i]; }
    public GameObject GetPlayer() { return player; }
    public int GetLevel() { return currentLevel; }
    public bool IsBombing() { return isBombing; }
    public bool IsInvincible() { return isInvincible; }
    public bool IsCollecting() { return isCollecting; }
    public bool IsFocused() { return isFocused; }
    public int GetBomb() { return bombs; }
    public int GetLife() { return lives; }
    public int GetScore() { return score; }
    public int GetPoint() { return point; }
    public int GetGraze() { return graze; }

    public void ResetScore() { score = 0; uiManager.SetString(score.ToString(), 0); }
    public void ResetLives() { lives = 5; uiManager.SetString(lives.ToString(), 1); }
    public void ResetBombs() { bombs = 3; uiManager.SetString(bombs.ToString(), 2); }
    public void ResetPower() { power = 0; uiManager.SetString(power.ToString(), 3); }
    public void ResetGraze() { graze = 0; uiManager.SetString(graze.ToString(), 4); }
    public void ResetPoint() { point = 0; uiManager.SetString(point.ToString(), 5); }

    public void ResetBools()
    {
        isBombing = false;
        isCollecting = false;
        isInvincible = false;
    }

    public void ResetAll()
    {
        ResetScore();
        ResetLives();
        ResetBombs();
        ResetPower();
        ResetGraze();
        ResetPoint();
        LevelChange();
    }

    public void ActivateGOScreen()
    {
        pauseMenu.GameOver();
    }

    public void InstantiatePlayer()
    {
        player = Instantiate(playerPrefab);
        bombScript = player.GetComponent<BombFireScript>();
        player.transform.parent = null;

        bulletSpawners = new List<Transform>();
        foreach (Transform child in player.transform)
        {
            if (child.gameObject.CompareTag("BulletSpawner"))
                bulletSpawners.Add(child);
        }
        laserSpawners = new List<Transform>();
        foreach (Transform child in player.transform)
        {
            if (child.gameObject.CompareTag("LaserSpawner"))
                laserSpawners.Add(child);
        }

        LevelChange();
        ResetAll();
        lives--;
        uiManager.SetString(lives.ToString(), 1);
        StartCoroutine(SpawnPlayer());
    }
    */
}
