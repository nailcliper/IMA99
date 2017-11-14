using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : BulletScript {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "EnemyShot")
        {
            collision.GetComponent<BulletScript>().Erase(true);
        }
    }
}
