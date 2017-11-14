using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {
    
    //Singleton
    static Pause pauseManager;
    public static Pause PauseManager { get { return pauseManager; } }

    public Text[] texts;

    bool isPaused = false;
    bool gameOver = false;
    int index = 0;
    Color32 white = new Color32(255, 255, 255, 255);
    Color32 amber = new Color32(255, 206, 0, 255);

    void Awake()
    {
        if (pauseManager != null && pauseManager != this)
            Destroy(gameObject);
        pauseManager = this;  
    }

    void OnEnable()
    {
        EventManager.Events.OnGameOver += GameOver;
    }

    void OnDisable()
    {
        EventManager.Events.OnGameOver -= GameOver;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            AudioScript.PlayClipAt(AudioManager.Audio.pause, Vector3.zero, 0.5f);
            PauseGame();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && !gameOver)
        {
            AudioScript.PlayClipAt(AudioManager.Audio.cancel, Vector3.zero, 0.5f);
            UnpauseGame();
        }

        if (isPaused)
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetButtonDown("Fire"))
            {
                AudioScript.PlayClipAt(AudioManager.Audio.ok, Vector3.zero, 0.5f);
                switch (index)
                {
                    case 0:
                        if (gameOver)
                            PlayerManager.PlayerInfo.ResetAll();
                        UnpauseGame();
                        break;
                    case 1:
                        Time.timeScale = 1;
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                        break;
                    case 2:
                        Application.Quit();
                        break;
                    default:
                        break;
                }
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Time.timeScale = 1;
                AudioScript.PlayClipAt(AudioManager.Audio.select, Vector3.zero, 0.5f);
                Time.timeScale = 0;
                texts[index].color = white;
                index++;
                if (index >= texts.Length)
                    index = 0;
                texts[index].color = amber;
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Time.timeScale = 1;
                AudioScript.PlayClipAt(AudioManager.Audio.select, Vector3.zero, 0.5f);
                Time.timeScale = 0;
                texts[index].color = white;
                index--;
                if (index < 0)
                    index = texts.Length - 1;
                texts[index].color = amber;
            }
        }
    }

    public void PauseGame()
    {
        isPaused = true;
        texts[0].text = "Resume";
        index = 0;
        texts[0].color = amber;
        texts[1].color = white;
        texts[2].color = white;
        EventManager.Events.SendPause();
    }

    public void UnpauseGame()
    {
        gameOver = false;
        isPaused = false;
        EventManager.Events.SendUnpause();
    }

    public void GameOver()
    {
        gameOver = true;
        isPaused = true;
        texts[0].text = "Continue";
        index = 0;
        texts[0].color = amber;
        texts[1].color = white;
        texts[2].color = white;
    }
}
