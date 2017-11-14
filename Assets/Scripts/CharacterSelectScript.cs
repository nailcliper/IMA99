using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectScript : MonoBehaviour {
    /*
    public List<Text> texts;
    int index = 0;
    Color32 white = new Color32(255, 255, 255, 255);
    Color32 amber = new Color32(255, 206, 0, 255);

    public AudioClip okClip;
    public AudioClip selectClip;
    GameObject audioClip;
    PlayerManagerScript playerManager;
    AudioSource musicPlayer;
    public GameObject stage1;

    void Awake()
    {
        index = 0;
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManagerScript>();
        musicPlayer = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioSource>();
        musicPlayer.Pause();
        texts[index].color = amber;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetButtonDown("Fire"))
        {
            playerManager.SetPlayerType(index);
            playerManager.InstantiatePlayer();
            Time.timeScale = 1;
            musicPlayer.UnPause();
            if(stage1)
                stage1.SetActive(true);
            gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow))
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
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
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
    */
}
