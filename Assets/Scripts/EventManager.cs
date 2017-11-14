using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager: MonoBehaviour
{
    //Singleton
    static EventManager eventManager;
    public static EventManager Events { get { return eventManager; } }

    void Awake()
    {
        if (eventManager != null && eventManager != this)
            Destroy(gameObject);
        eventManager = this;
    }

    //Functions subscribe to events
    //When an event is called, any subscribed function will be called
    public delegate void GameLoad();
    public delegate void GameStart();
    public delegate void GameRestart();
    public delegate void GameOver();
    public delegate void PlayerSpawn();
    public delegate void PlayerDeath();
    public delegate void LevelChange(int _level);
    public delegate void BombStart();
    public delegate void BombEnd();
    public delegate void Focus();
    public delegate void Unfocus();
    public delegate void StageStart(Material _mat = null, Vector2 _scrollSpeed = new Vector2());
    public delegate void StageEnd();
    public delegate void BossEnter();
    public delegate void BossNextLife();
    public delegate void BossExit();
    public delegate void SpellcardStart(Material _mat = null, Vector2 _scrollSpeed = new Vector2());
    public delegate void SpellcardEnd();
    public delegate void Pause();
    public delegate void Unpause();

    public event GameLoad OnGameLoad;
    public event GameStart OnGameStart;
    public event GameRestart OnGameRestart;
    public event GameOver OnGameOver;
    public event PlayerSpawn OnPlayerSpawn;
    public event PlayerDeath OnPlayerDeath;
    public event LevelChange OnLevelChange;
    public event BombStart OnBombStart;
    public event BombEnd OnBombEnd;
    public event Focus OnFocus;
    public event Unfocus OnUnfocus;
    public event StageStart OnStageStart;
    public event StageEnd OnStageEnd;
    public event BossEnter OnBossEnter;
    public event BossNextLife OnBossNextLife;
    public event BossExit OnBossExit;
    public event SpellcardStart OnSpellStart;
    public event SpellcardEnd OnSpellEnd;
    public event Pause OnPause;
    public event Unpause OnUnpause;

    void Start()
    {
        SendGameLoad();
    }

    public void SendGameLoad()
    {
        Time.timeScale = 0;
        if (OnGameLoad != null)
            OnGameLoad();
    }

    public void SendGameStart()
    {
        Time.timeScale = 1;
        if (OnGameStart != null)
            OnGameStart();
    }

    public void SendGameRestart()
    {
        if (OnGameRestart != null)
            OnGameRestart();
        if (OnGameLoad != null)
            OnGameLoad();
    }

    public void SendGameOver()
    {
        Time.timeScale = 0;
        if (OnGameOver != null)
            OnGameOver();
    }

    public void SendPlayerSpawn()
    {
        if (OnPlayerSpawn != null)
            OnPlayerSpawn();
    }

    public void SendPlayerDeath()
    {
        if (OnPlayerDeath != null)
            OnPlayerDeath();
    }

    public void SendLevelChange(int _level)
    {
        if (OnLevelChange != null)
            OnLevelChange(_level);
    }

    public void SendBombStart()
    {
        if (OnBombStart != null)
            OnBombStart();
    }

    public void SendBombEnd()
    {
        if (OnBombEnd != null)
            OnBombEnd();
    }

    public void SendFocus()
    {
        if (OnFocus != null)
            OnFocus();
    }

    public void SendUnfocus()
    {
        if (OnUnfocus != null)
            OnUnfocus();
    }

    public void SendStageStart(Material _mat = null, Vector2 _scrollSpeed = new Vector2())
    {
        if (OnStageStart != null)
            OnStageStart(_mat, _scrollSpeed);
    }

    public void SendStageEnd()
    {
        if (OnStageEnd != null)
            OnStageEnd();
    }

    public void SendBossEnter()
    {
        if (OnBossEnter != null)
            OnBossEnter();
    }

    public void SendBossNextLife()
    {
        if (OnBossNextLife != null)
            OnBossNextLife();
    }

    public void SendBossExit()
    {
        if (OnBossExit != null)
            OnBossExit();
    }

    public void SendSpellStart(Material _mat, Vector2 _scrollSpeed)
    {
        if (OnSpellStart != null)
            OnSpellStart(_mat, _scrollSpeed);
    }

    public void SendSpellEnd()
    {
        if (OnSpellEnd != null)
            OnSpellEnd();
    }

    public void SendPause()
    {
        Time.timeScale = 0;
        if (OnPause != null)
            OnPause();
    }

    public void SendUnpause()
    {
        Time.timeScale = 1;
        if (OnUnpause != null)
            OnUnpause();
    }
}
