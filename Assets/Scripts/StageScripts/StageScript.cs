using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageScript : MonoBehaviour {
    /*
    public float time;
    public int stageNum;
    public Material back;
    public Vector2 scrollSpeed;
    BackgroundManagerScript backgroundManager;
    public GameObject[] wavePrefab;
    public GameObject[] enemyPrefab;
    WaveScript[] waveScript;
    Coroutine spawnEnemies;
    bool paused = false;
    public GameObject nextStage;
    public StageDisplayScript stageCanvas;
    ScoringScript scoreScript;

    [System.Serializable]
    public struct SpawnInfo
    {
        public int waveIndex;
        public int enemyIndex;
        public Vector2 spawnPos;
        public List<GameObject> item;
    }

    [System.Serializable]
    public class Spawn
    {
        public float spawnTime;
        public SpawnInfo[] enemies = new SpawnInfo[1];
    }

    public List<Spawn> spawns = new List<Spawn>();

    void Awake()
    {
        scoreScript = GameObject.FindGameObjectWithTag("ScoreCanvas").GetComponent<ScoringScript>();
        stageCanvas = GameObject.FindGameObjectWithTag("StageCanvas").GetComponent<StageDisplayScript>();
        backgroundManager = GameObject.FindGameObjectWithTag("BackgroundManager").GetComponent<BackgroundManagerScript>();

        spawns.Sort(delegate (Spawn a, Spawn b)
        {
            return (a.spawnTime.CompareTo(b.spawnTime));
        });

        time = 0;
        waveScript = new WaveScript[wavePrefab.Length];
        for (int i = 1; i < wavePrefab.Length; i++)
        {
            waveScript[i] = wavePrefab[i].GetComponent<WaveScript>();
        }
    }

    void Update()
    {
        if (!paused)
            time += Time.deltaTime;
    }

    void OnEnable()
    {
        stageCanvas.Display(stageNum);
        backgroundManager.SetBackground(back, scrollSpeed);
        spawnEnemies = StartCoroutine(SpawnEnemies());
    }

    public void PauseSpawns()
    {
        paused = true;
    }
    public void UnpauseSpawns()
    {
        StartCoroutine(ClearBulletsScript.ClearEnemy());
        paused = false;
    }

    IEnumerator SpawnEnemies()
    {
        int i = 0;
        while (i < spawns.Count)
        {
            if (spawns[i].spawnTime < time)
            {
                for (int j = 0; j < spawns[i].enemies.Length; j++)
                {
                    if (spawns[i].enemies[j].waveIndex > 0)
                    {
                        WaveScript wave;
                        wave = waveScript[spawns[i].enemies[j].waveIndex];
                        StartCoroutine(wave.SpawnEnemies(spawns[i].enemies[j].spawnPos, spawns[i].enemies[j].item));
                    }
                    else
                    {
                        GameObject obj = Instantiate(enemyPrefab[spawns[i].enemies[j].enemyIndex]);
                        obj.transform.position = spawns[i].enemies[j].spawnPos;
                        obj.GetComponent<EnemyScript>().itemPrefab = spawns[i].enemies[j].item[0];
                        obj.SetActive(true);
                    }
                }
                i++;
            }
            yield return new WaitForFixedUpdate();
        }

        i = (int)time + 1;
        while (time < i)
            yield return new WaitForFixedUpdate();

        if (nextStage)
        {
            scoreScript.CalcScore();
            yield return new WaitForSeconds(3f);
            LoadNextStage();
        }
        else
        {
            yield return new WaitForSeconds(3f);
            scoreScript.CalcFinal();
        }
    }
    
    public void NextStage()
    {
        Invoke("LoadNextStage", 3f);
    }

    void LoadNextStage()
    {
        if (nextStage != null)
        {
            nextStage.SetActive(true);
            gameObject.SetActive(false);
        }
    }
    */
}
