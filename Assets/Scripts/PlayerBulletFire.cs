using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletFire : BulletFire {

    /*
    public ObjectPoolerScript pooler;
    public float delay;
    public float angle;
    public bool local;
    public Vector2 spawnPos;
    public bool useVectors;
    public float startSpeed;
    public float endSpeed;
    public float acceleration;
    public Vector2 startSpeedVec;
    public Vector2 endSpeedVec;
    public Vector2 accelerationVec;
    */

    int currentLevel;
    int currentLoop;

    public float interval = 0.1f;

    [System.Serializable]
    public struct Shot
    {
        public Vector2 spawnPos;
        public bool useVec;
        public float startSpeed;
        public float endSpeed;
        public float acceleration;
        public Vector2 startSpeedVec;
        public Vector2 endSpeedVec;
        public Vector2 accelerationVec;
        public int bullets;
        public float angle;
        public float spread;
    }

    [System.Serializable]
    public struct Loop
    {
        public Shot[] shot;
    }

    [System.Serializable]
    public struct Level
    {
        public int power;
        public float interval;
        public Vector2 scale;    
        public Loop[] loop;
    }
    public Level[] level = new Level[PlayerManager.maxLevel];

    void OnEnable()
    {
        currentLoop = 0;
    }

    void OnDisable()
    {
        StopAllCoroutines();
    }

    void FixedUpdate()
    {
        if(InputManager.PlayerController.fireButtonDown && currentLoop == 0)
        {
            StartCoroutine(Fire());
        }
    }

    IEnumerator Fire()
    {
        while (currentLoop < level[currentLevel].loop.Length)
        {
            AudioScript.PlayClipAt(AudioManager.Audio.playerShot, transform.position, 0.1f);
            Loop iLoop = level[currentLevel].loop[currentLoop];
            for (int i = 0; i < level[currentLevel].loop[currentLoop].shot.Length; i++)
            {
                Shot iShot = iLoop.shot[i];
                if(iShot.bullets > 1)
                {
                    float maxAngle = GetMaxAngle(iShot.bullets, iShot.spread);
                    for (float j = -maxAngle; j < maxAngle; j += iShot.spread)
                    {
                        if (iShot.useVec)
                            FireShot(pooler, (Vector2)transform.position + iShot.spawnPos, level[currentLevel].scale, iShot.startSpeedVec, iShot.endSpeedVec, iShot.accelerationVec, iShot.angle + j);
                        else
                            FireShot(pooler, (Vector2)transform.position + iShot.spawnPos, level[currentLevel].scale, iShot.startSpeed, iShot.endSpeed, iShot.acceleration, iShot.angle + j);
                    }
                }
                else
                {
                    if(iShot.useVec)
                        FireShot(pooler, (Vector2)transform.position + iShot.spawnPos, level[currentLevel].scale, iShot.startSpeedVec, iShot.endSpeedVec, iShot.accelerationVec, iShot.angle);
                    else
                        FireShot(pooler, (Vector2)transform.position + iShot.spawnPos, level[currentLevel].scale, iShot.startSpeed, iShot.endSpeed, iShot.acceleration, iShot.angle);
                }
            }
            currentLoop++;
            yield return new WaitForSeconds(level[currentLevel].interval);
        }
        currentLoop = 0;
    }
}
