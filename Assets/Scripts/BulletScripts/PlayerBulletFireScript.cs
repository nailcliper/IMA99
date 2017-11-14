using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletFireScript : BulletFireScript {

    /*
    bool fireButtonDown = false;
    bool restart = false;
    public int currentLevel = 0;
    int currentLoop = 0;

    [System.Serializable]
    public class Shot
    {
        public float posX;
        public float posY;
        public float driftX;

        public int bullets = 1;

        public float angle;
        public float angleSpread;
    }

    [System.Serializable]
    public class Loop
    {
        public Shot[] shots = new Shot[1];
    }

    [System.Serializable]
    public class Level
    {
        public int power;
        public float interval;
        public bool constantSpeed = true;
        public float speed;
        public float endSpeed = 0;
        public float speedTime;
        public float scaleX = 1f;
        public float scaleY = 1f;
        public Loop[] loops = new Loop[1];
    }

    public Level[] levels = new Level[6];

    protected void Start()
    {
        poolerObj = GameObject.Find(poolerObjectName);
        poolerScript = poolerObj.GetComponent<ObjectPoolerScript>();
        //playerManager = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManagerScript>();
        player = playerManager.GetPlayer();
    }

    void OnEnable()
    {
        restart = true;
        StartCoroutine(FireLoop());
    }

    void Update()
    {
        fireButtonDown = PlayerControllerScript.current.GetFireBool();
    }

    IEnumerator FireLoop()
    {
        while (true)
        {
            if (fireButtonDown)
            {
                if (clip != null)
                {
                    GameObject audioClip = AudioScript.PlayClipAt(clip, transform.position, 0.2f);
                }
                for (int i = 0; i < levels[currentLevel].loops[currentLoop].shots.Length; i++)
                {
                    
                    if (!restart)
                    {
                        posX = levels[currentLevel].loops[currentLoop].shots[i].posX;
                        posY = levels[currentLevel].loops[currentLoop].shots[i].posY;
                        driftX = levels[currentLevel].loops[currentLoop].shots[i].driftX;

                        bullets = levels[currentLevel].loops[currentLoop].shots[i].bullets;

                        angle = levels[currentLevel].loops[currentLoop].shots[i].angle;
                        angleSpread = levels[currentLevel].loops[currentLoop].shots[i].angleSpread;

                        StartCoroutine(Shoot());
                    }
                    else
                    {
                        restart = false;
                        yield return new WaitForFixedUpdate();
                    }
                }
            
                currentLoop++;
                if (currentLoop >= levels[currentLevel].loops.Length)
                {
                    currentLoop = 0;
                }
            }
            else
            {
                currentLoop = 0;
            }

            yield return new WaitForSeconds(levels[currentLevel].interval);
        }
    }

    //When levelup is received, gets level from PlayerLevelScript and resets loop counter
    public void SetLevel(int playerLevel)
    {
        currentLevel = playerLevel;
        currentLoop = 0;

        power = levels[currentLevel].power;
        speed = levels[currentLevel].speed;
        endSpeed = levels[currentLevel].endSpeed;
        speedTime = levels[currentLevel].speedTime;
        scaleX = levels[currentLevel].scaleX;
        scaleY = levels[currentLevel].scaleY;
    }
    */
}
