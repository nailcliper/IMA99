using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrazeboxScript : MonoBehaviour {
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
        if (collision.tag == "EnemyShot")
        {
            BulletScript collisionScript = collision.gameObject.GetComponent<BulletScript>();

            if (!collisionScript.HasGrazed())
            {
                GameObject audioClip = AudioScript.PlayClipAt(clip, transform.position, 0.75f);
                playerManager.AddGraze(1);
                collisionScript.SetHasGrazed();
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "EnemyLaser")
        {
            LaserScript collisionScript = collision.gameObject.GetComponent<LaserScript>();

            if(!collisionScript.HasGrazed())
            {
                GameObject audioClip = AudioScript.PlayClipAt(clip, transform.position, 0.75f);
                playerManager.AddGraze(1);
                collisionScript.SetHasGrazed();
            }

        }
    }
    */
}
