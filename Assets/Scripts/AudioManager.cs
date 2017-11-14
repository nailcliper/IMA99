using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    //Singleton
    static AudioManager audioManager;
    public static AudioManager Audio { get { return audioManager; } }

    public AudioClip attack1;
    public AudioClip attack2;
    public AudioClip attack3;
    public AudioClip cancel;
    public AudioClip enemyDestroy1;
    public AudioClip enemyDestroy2;
    public AudioClip enemyDestroy3;
    public AudioClip extend;
    public AudioClip graze;
    public AudioClip item;
    public AudioClip masterSpark;
    public AudioClip ok;
    public AudioClip pause;
    public AudioClip playerBomb;
    public AudioClip playerDead;
    public AudioClip playerPower;
    public AudioClip playerShot;
    public AudioClip select;

    void Awake()
    {
        if (audioManager != null && audioManager != this)
            Destroy(gameObject);
        audioManager = this;
    }
}
