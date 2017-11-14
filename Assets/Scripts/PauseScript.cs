using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour {
    /*
    bool isPaused = false;
    bool gameOver = false;
    public GameObject canvas;
    public List<Text> texts;
    int index = 0;
    Color32 white = new Color32(255, 255, 255, 255);
    Color32 amber = new Color32(255, 206, 0, 255);
    public AudioClip pauseClip;
    public AudioClip okClip;
    public AudioClip cancelClip;
    public AudioClip selectClip;
    GameObject audioClip;
    PlayerManagerScript playerManager;
    AudioSource musicPlayer;

    private void Awake()
    {
        canvas.SetActive(false);
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManagerScript>();
        musicPlayer = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
                PauseGame();
            else if(!gameOver)
                UnpauseGame();
        }

        if (isPaused)
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetButtonDown("Fire"))
            {
                switch (index)
                {
                    case 0:
                        if (gameOver)
                            playerManager.ResetAll();
                        UnpauseGame();
                        break;
                    case 1:
                        isPaused = false;
                        canvas.SetActive(false);
                        Time.timeScale = 1;
                        audioClip = AudioScript.PlayClipAt(okClip, transform.position, 0.5f);
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                        break;
                    case 2:
                        audioClip = AudioScript.PlayClipAt(okClip, transform.position, 0.5f);
                        Application.Quit();
                        break;
                    default:
                        break;
                }
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Time.timeScale = 1;
                audioClip = AudioScript.PlayClipAt(selectClip, transform.position, 0.5f);
                Time.timeScale = 0;
                texts[index].color = white;
                index++;
                if (index >= texts.Count)
                    index = 0;
                texts[index].color = amber;
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Time.timeScale = 1;
                audioClip = AudioScript.PlayClipAt(selectClip, transform.position, 0.5f);
                Time.timeScale = 0;
                texts[index].color = white;
                index--;
                if (index < 0)
                    index = texts.Count - 1;
                texts[index].color = amber;
            }
        }
    }

    public void PauseGame()
    {
        musicPlayer.Pause();
        isPaused = true;
        if(pauseClip)
            audioClip = AudioScript.PlayClipAt(pauseClip, transform.position, 0.5f);
        texts[0].text = "Resume";
        canvas.SetActive(true);
        index = 0;
        texts[0].color = amber;
        texts[1].color = white;
        texts[2].color = white;
        Time.timeScale = 0;
    }

    public void UnpauseGame()
    {
        musicPlayer.UnPause();
        isPaused = false;
        Time.timeScale = 1;
        audioClip = AudioScript.PlayClipAt(cancelClip, transform.position, 0.5f);
        canvas.SetActive(false);
    }

    public void GameOver()
    {
        musicPlayer.Pause();
        gameOver = true;
        isPaused = true;
        texts[0].text = "Continue";
        canvas.SetActive(true);
        index = 0;
        texts[0].color = amber;
        texts[1].color = white;
        texts[2].color = white;
        Time.timeScale = 0;
    }
    */
}
