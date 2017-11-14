using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolerScript : MonoBehaviour {

    public static Dictionary<string, ObjectPoolerScript> bulletPoolers;

    public GameObject pooledObject;
    public int poolAmount = 10;
    public bool willGrow = true;

    List<GameObject> pooledObjects;

    //Builds pool of game objects and deactivates them
	void Awake () {
        if (bulletPoolers == null)
            bulletPoolers = new Dictionary<string, ObjectPoolerScript>();

        pooledObjects = new List<GameObject>();

        for (int i = 0; i < poolAmount; i++)
        {
            GameObject obj = Instantiate(pooledObject);
            obj.SetActive(false);
            obj.transform.parent = transform;
            pooledObjects.Add(obj);
        }
	}

    void OnEnable()
    {
        bulletPoolers.Add(pooledObject.name, this);
    }

    void OnDisable()
    {
        bulletPoolers.Remove(pooledObject.name);
    }

    //Returns next deactivated pooled object to be activated
    public GameObject GetPooledObject()
    {
        for(int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        //Allows pooler to grow dynamically.
        if(willGrow)
        {
            GameObject obj = Instantiate(pooledObject);
            obj.transform.parent = transform;
            pooledObjects.Add(obj);
            return obj;
        }

        return null;
    }
}
