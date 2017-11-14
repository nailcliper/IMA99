using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitboxScript : MonoBehaviour {
    /*
    GameObject player;
    PlayerManagerScript playerManager;
    public AudioClip clip;

    private void Start()
    {
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManagerScript>();
        player = playerManager.GetPlayer();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyShot" || collision.CompareTag("EnemyLaser") || collision.tag == "Enemy")
        {
            if (collision.tag == "EnemyShot")
                collision.gameObject.SetActive(false);
            if (!playerManager.IsInvincible())
            {
               GameObject audioClip = AudioScript.PlayClipAt(clip, transform.position, 0.6f);
               Invoke("KillPlayer", .05f);
            }
        }
    }

    void KillPlayer()
    {
        if (!playerManager.IsInvincible())
        {
            playerManager.SetIsBombing(false);
            playerManager.SetIsCollecting(false);
            player.SetActive(false);
            playerManager.RespawnPlayer();
        }
    }

    private void OnDisable()
    {
        CancelInvoke();
    }
    */
}
