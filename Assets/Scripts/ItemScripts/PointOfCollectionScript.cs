using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOfCollectionScript : MonoBehaviour {
    /*
    public PlayerManagerScript playerManager;
    public GameObject player;

    private void Start()
    {
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManagerScript>();
        player = playerManager.GetPlayer();
    }
   
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!player)
            player = playerManager.GetPlayer();
        if (collision.gameObject == player)
        {
            playerManager.SetIsCollecting();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == player && !playerManager.IsBombing())
        {
            playerManager.SetIsCollecting(false);
        }
    }
    */
}
