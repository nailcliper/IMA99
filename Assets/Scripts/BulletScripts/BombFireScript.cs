using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombFireScript : MonoBehaviour {
    /*
    public float duration;
    protected PlayerManagerScript playerManager;
    BackgroundManagerScript backgroundManager;

    void Start()
    {
        backgroundManager = GameObject.FindGameObjectWithTag("BackgroundManager").GetComponent<BackgroundManagerScript>();
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManagerScript>();
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    public virtual void FireBomb()
    {
        playerManager.AddBomb(-1);
        playerManager.SetIsBombing();
        playerManager.SetInvincible();
        playerManager.SetIsCollecting();
        backgroundManager.blackground.GetComponent<BackgroundTilingScript>().FadeHalf(0.5f);
        Invoke("EndBomb", duration);
    }

    void EndBomb()
    {
        backgroundManager.blackground.GetComponent<BackgroundTilingScript>().FadeClear(0.5f);
        //backgroundManager.foreground.GetComponent<BackgroundTilingScript>().FadeFull(0.5f);
        playerManager.SetIsBombing(false);
        playerManager.SetInvincible(false);
        if (gameObject.transform.position.y < 2.2)
            playerManager.SetIsCollecting(false);
    }

    public float GetDuration() { return duration; }
    */
}
