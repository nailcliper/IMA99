using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour {

    //Singleton
    static CharacterSelect characterSelector;
    public static CharacterSelect CharacterSelector { get { return characterSelector; } }

    [System.Serializable]
    public struct ShotType
    {
        public GameObject playerType;
        public Text typeText;
    }
    public ShotType[] shotTypes;

    int index = 0;
    Color32 white = new Color32(255, 255, 255, 255);
    Color32 amber = new Color32(255, 206, 0, 255);

    void Awake()
    {
        if (characterSelector != null && characterSelector != this)
            Destroy(gameObject);
        characterSelector = this;
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetButtonDown("Fire"))
        {
            AudioScript.PlayClipAt(AudioManager.Audio.ok, Vector2.zero, 0.5f);
            PlayerManager.PlayerInfo.SetPlayer(shotTypes[index].playerType);
            EventManager.Events.SendGameStart();
            gameObject.SetActive(false);
        }
        
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Time.timeScale = 1;
            AudioScript.PlayClipAt(AudioManager.Audio.select, Vector2.zero, 0.5f);
            Time.timeScale = 0;
            shotTypes[index].typeText.color = white;
            index++;
            if (index >= shotTypes.Length)
                index = 0;
            shotTypes[index].typeText.color = amber;
        }
        
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Time.timeScale = 1;
            AudioScript.PlayClipAt(AudioManager.Audio.select, Vector2.zero, 0.5f);
            Time.timeScale = 0;
            shotTypes[index].typeText.color = white;
            index--;
            if (index < 0)
                index = shotTypes.Length - 1;
            shotTypes[index].typeText.color = amber;
        }
    }
}
