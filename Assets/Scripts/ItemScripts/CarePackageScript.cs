using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarePackageScript : MonoBehaviour {
    /*
    public List<GameObject> items;
    //public List<GameObject> spawned;
    public bool local = false;
    public Vector2 bottomLeftBound;
    public Vector2 upperRightBound;
    public Vector2 minMove;
    public Vector2 maxMove;
    float rTime = 1;

    GameObject target;

    private void Start()
    {
        if (gameObject.CompareTag("PlayerManager"))
            target = gameObject.GetComponent<PlayerManagerScript>().GetPlayer();
        else
            target = gameObject;
    }

    public void Drop(Vector2 pos)
    {
        for (int i = 0; i < items.Count; i++)
        {
            GameObject obj = Instantiate(items[i]);
            //spawned.Add(obj);
            RandomMoveScript ipath = obj.GetComponent<RandomMoveScript>();
            ipath.local = local;
            ipath.moves = 1;
            ipath.bottomLeftBound = bottomLeftBound;
            ipath.upperRightBound = upperRightBound;
            ipath.minMove = minMove;
            ipath.maxMove = maxMove;
            ipath.rTime = rTime;
            obj.transform.position = pos;
            obj.SetActive(true);
            //obj.GetComponent<Rigidbody2D>().gravityScale = 0.45f;
            obj.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            ipath.StartMove();
        }
/*
        yield return new WaitForSeconds(0f);

        while(spawned.Count > 0)
        {
            spawned[0].GetComponent<Rigidbody2D>().gravityScale = 0.5f;
            spawned.RemoveAt(0);
        }
        */
    //}

}
