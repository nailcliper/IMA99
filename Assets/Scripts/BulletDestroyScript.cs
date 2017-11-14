using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyScript : MonoBehaviour {

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "PlayerShot" || collision.tag == "EnemyShot" || collision.tag == "BombShot")
        {
            if (collision.tag == "BombShot")
                Destroy(collision.gameObject);
            else
                collision.gameObject.SetActive(false);
        }
    }
}
