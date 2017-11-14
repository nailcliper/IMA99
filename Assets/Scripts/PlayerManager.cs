using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    //Singleton
    static PlayerManager playerManager;
    public static PlayerManager PlayerInfo { get { return playerManager; } }

    public GameObject player { get; private set; }
    public int score { get; private set; }
    public int lives { get; private set; }
    public int bombs { get; private set; }
    public int power { get; private set; }
    public int graze { get; private set; }
    public int point { get; private set; }
    public bool isBombing { get; set; }
    public bool isInvincible { get; set; }
    public bool isCollecting { get; set; }

    public static readonly Vector2 spawnPoint = new Vector2(0,-5.5f);
    public const int maxLevel = 6;
    static readonly int[] levels = { 0, 16, 48, 64, 96, 128 };
    static int currentLevel = 0;

    void Awake()
    {
        if (playerManager != null && playerManager != this)
            Destroy(gameObject);
        playerManager = this;
    }

    void OnEnable()
    {
        EventManager.Events.OnGameStart += SpawnPlayer;
        EventManager.Events.OnPlayerDeath += SpawnPlayer;
    }

    void OnDisable()
    {
        EventManager.Events.OnGameStart -= SpawnPlayer;
        EventManager.Events.OnPlayerDeath -= SpawnPlayer;
    }

    void Start()
    {
        ResetAll();
    }

    void ResetScore() { score = 0; PlayerInfoUI.PlayerInfo.UpdateScore(0); }
    void ResetLives() { lives = 5; PlayerInfoUI.PlayerInfo.UpdatePlayer(); }
    void ResetBombs() { bombs = 3; PlayerInfoUI.PlayerInfo.UpdateBomb(); }
    void ResetPower() { power = 0; PlayerInfoUI.PlayerInfo.UpdatePower(); }
    void ResetGraze() { graze = 0; PlayerInfoUI.PlayerInfo.UpdateGraze(); }
    void ResetPoint() { point = 0; PlayerInfoUI.PlayerInfo.UpdatePoint(); }

    public void ResetAll()
    {
        ResetScore();
        ResetLives();
        ResetBombs();
        ResetPower();
        ResetGraze();
        ResetPoint();
        isBombing = false;
        isCollecting = false;
        isInvincible = false;
    }

    public void SetPlayer(GameObject _player)
    {
        player = Instantiate(_player);
    }

    public void SpawnPlayer(){ StartCoroutine(Spawn()); }
    IEnumerator Spawn()
    {
        AddLife(-1);
        AddPower(-16);
        ResetBombs();
        player.transform.position = spawnPoint;
        isBombing = false;
        isCollecting = false;
        isInvincible = true;
        player.GetComponentInChildren<PlayerHitbox>().DisableHitbox();
        player.SetActive(true);
        SpriteRenderer sRender = player.transform.GetChild(0).GetComponent<SpriteRenderer>();
        Color32 full = new Color32(200, 200, 200, 255);
        Color32 half = new Color32(100, 100, 100, 255);

        sRender.color = new Color32(255, 255, 255, 0);

        
        float t = 0;
        while(t < 1f)
        {
            t += 4 * Time.deltaTime;
            sRender.color = new Color(1, 1, 1, Mathf.Lerp(0, 1, t));
            yield return new WaitForFixedUpdate();
        }
        player.GetComponent<InputManager>().enabled = true;

        int count = 39;
        do
        {
            if (count % 2 == 0)
                sRender.color = full;
            else
                sRender.color = half;

            count--;
            yield return new WaitForSeconds(0.05f);
        } while (count > 0);

        sRender.color = new Color32(255, 255, 255, 255);
        isInvincible = false;
        player.GetComponentInChildren<PlayerHitbox>().EnableHitbox();
    }

    public void AddScore(int value) { PlayerInfoUI.PlayerInfo.UpdateScore(value); score += value; }
    public void AddBomb(int value = 1) { bombs += value; PlayerInfoUI.PlayerInfo.UpdateBomb(); }
    public void AddGraze(int value = 1) { graze += value; PlayerInfoUI.PlayerInfo.UpdateGraze(); }
    public void AddPoint(int value = 1) { point += value; PlayerInfoUI.PlayerInfo.UpdatePoint(); }
    public void AddLife(int value = 1)
    {
        lives += value;
        if(value > 0)
            AudioScript.PlayClipAt(AudioManager.Audio.extend, Vector2.zero, 0.8f);
        PlayerInfoUI.PlayerInfo.UpdatePlayer();
    }
    public void AddPower(int value)
    {
        if (value > 0 && power < 128)
        {
            power += value;

            if (power >= 128)
            {
                //Check Bullet To Stars
                ClearBulletsScript.EnemyToStar();
                power = 128;
            }

            if(power >= levels[currentLevel + 1])
            {
                for(int i = currentLevel + 1; i < levels.Length; i++)
                {
                    if (power >= levels[i])
                        currentLevel = i;
                }

                EventManager.Events.SendLevelChange(currentLevel);
                AudioScript.PlayClipAt(AudioManager.Audio.playerPower, player.transform.position, 0.8f);
            }

            PlayerInfoUI.PlayerInfo.UpdatePower();
        }
        else if (value < 0 && power > 0)
        {
            power += value;

            if (power < 0)
                power = 0;

            if (power < levels[currentLevel])
            {
                do
                {
                    currentLevel--;
                } while (power < levels[currentLevel]);
                EventManager.Events.SendLevelChange(currentLevel);
            }

            PlayerInfoUI.PlayerInfo.UpdatePower();
        }
    }

}
