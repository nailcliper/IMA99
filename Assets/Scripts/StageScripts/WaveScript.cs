using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveScript : MonoBehaviour {
    /*
    //Add individual spawn time

    public bool test = false;
    public float spawnInterval;
    public GameObject[] enemyPrefab;

    [System.Serializable]
    public struct SpawnInfo
    {
        public int enemyIndex;
        public Vector2 spawnPos;
    }

    [System.Serializable]
    public class Spawn
    {
        public SpawnInfo[] enemies = new SpawnInfo[1];
    }

    public Spawn[] spawns;

    private void OnEnable()
    {
        if (test)
        {
            StartCoroutine(SpawnEnemies(transform.position, new List<GameObject>()));
        }
    }

    public IEnumerator SpawnEnemies(Vector2 waveSpawnPos, List<GameObject> iitem)
    {
        for (int i = 0; i < spawns.Length; i++)
        {
            for (int j = 0; j < spawns[i].enemies.Length; j++)
            {
                GameObject item = null;
                if (iitem.Count > 0)
                {
                    item = iitem[0];
                    iitem.RemoveAt(0);
                }

                GameObject obj = Instantiate(enemyPrefab[spawns[i].enemies[j].enemyIndex]);
                obj.transform.position = spawns[i].enemies[j].spawnPos + waveSpawnPos;
                obj.GetComponent<EnemyScript>().itemPrefab = item;
                obj.SetActive(true);
            }
            yield return new WaitForSeconds(spawnInterval);
        }
    }
    */
}
