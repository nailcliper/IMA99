using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour {
    /*
    public static List<GameObject> ItemList = new List<GameObject>();

    public int pointValue = 1;
    public bool autoCollect = false;
    float speed = 12f;

    public PlayerManagerScript playerManager;
    public GameObject player;
    public AudioClip clip;
    Rigidbody2D rigidbodyComp;
    MoveScript moveScript;

    void Awake()
    {
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManagerScript>();
        player = playerManager.GetPlayer();
        rigidbodyComp = gameObject.GetComponent<Rigidbody2D>();
        moveScript = gameObject.GetComponent<MoveScript>();
        ItemList.Add(gameObject);
    }

    void OnEnable()
    {
        if (playerManager.IsCollecting())
        {
            AutoCollect();
        }
        else
        {
            rigidbodyComp.velocity = new Vector2(0, 4);
        }
    }

    void OnDisable()
    {
        ItemList.Remove(gameObject);
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == player)
        {
            GameObject audioClip = AudioScript.PlayClipAt(clip, transform.position, 0.5f);
            Collect();
        }
    }

    public virtual void Update()
    {
        if(playerManager.IsCollecting() || autoCollect)
        {
            AutoCollect();
        }

        if(!player.activeInHierarchy)
        {
            CancelAutoCollect();
        }
    }

    public virtual void Collect()
    {
        playerManager.AddScore(pointValue);
        Destroy(gameObject);
    }

    public void AutoCollect()
    {
        if (autoCollect)
        {
            moveScript.StopAllCoroutines();
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
        else
        {
            autoCollect = true;
            rigidbodyComp.gravityScale = 0;
            rigidbodyComp.velocity = new Vector2(0, 0);
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }

    public void CancelAutoCollect()
    {
        if (autoCollect)
        {
            autoCollect = false;
            rigidbodyComp.gravityScale = 0.5f;
        }
    }
    */
}