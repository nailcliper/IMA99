using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript : MonoBehaviour {
    /*
    public float time;
    public GameObject[] enemyPrefab;

    [System.Serializable]
    public struct SpawnInfo
    {
        public WaveScript wavePrefab;
        public int enemyIndex;
        public Vector2 spawnPos;
        public GameObject item;
    }

    [System.Serializable]
    public class Spawn
    {
        public float spawnTime;
        public SpawnInfo[] enemies= new SpawnInfo[1];
    }

    public Spawn[] spawns = new Spawn[1];

    void Awake()
    {
        time = 0;
    }

    void Update()
    {
        time += Time.deltaTime;
    }

    void OnEnable()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        int i = 0;
        while (i < spawns.Length)
        {
            if (spawns[i].spawnTime < time)
            {
                for (int j = 0; j < spawns[i].enemies.Length; j++)
                {
                    if (spawns[i].enemies[j].wavePrefab)
                    {
                        WaveScript wave = spawns[i].enemies[j].wavePrefab;
                    }
                    else
                    {
                        GameObject obj = Instantiate(enemyPrefab[spawns[i].enemies[j].enemyIndex]);
                        obj.transform.position = spawns[i].enemies[j].spawnPos;
                        obj.GetComponent<EnemyScript>().itemPrefab = spawns[i].enemies[j].item;
                        obj.SetActive(true);
                    }
                }
                i++;
                yield return new WaitForFixedUpdate();
            }
            yield return new WaitForFixedUpdate();
        }
    }
    */
}
