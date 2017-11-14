using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject obj = collision.gameObject;

        if (obj.tag == "PlayerShot" || obj.tag == "EnemyShot")
            obj.SetActive(false);
        else if (obj.tag == "BombShot" || obj.tag == "Enemy" || obj.tag == "Boss")
            Destroy(obj);
    }
}