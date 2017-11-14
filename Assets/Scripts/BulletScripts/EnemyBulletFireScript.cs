using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletFireScript : BulletFireScript
{
    /*
    [System.Serializable]
    public struct Shot
    {
        public string poolerObjectName;
        GameObject poolerObj;
        ObjectPoolerScript poolerScript;

        public float speedStart;
        public float speedEnd;
        public float speedTime;
        public Vector2 pos;
        public int bullets;
        public bool circle;
        public float angle;
        public float spread;

        public void SetPoolerScript(GameObject obj)
        {
            poolerObj = obj;
            poolerScript = poolerObj.GetComponent<ObjectPoolerScript>();
        }
        public ObjectPoolerScript GetPoolerScript() { return poolerScript; }
    }
    public Shot[] shots = new Shot[1];

    public bool aimAt;
    public bool aimAway;
    public int count = 1;
    int icount;
    public bool isRepeating = false;
    public float delay;
    public float stepSize = 0;
    float aimAngle;
    public bool selfActive = false;

    protected void Start()
    {
        //playerManager = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManagerScript>();
        player = playerManager.GetPlayer();
        target = player;
        if(poolerObjectName != "")
        {
            for (int i = 0; i < shots.Length; i++)
                shots[i].SetPoolerScript(GameObject.Find(poolerObjectName));
        }
        else
            for (int i = 0; i < shots.Length; i++)
                shots[i].SetPoolerScript(GameObject.Find(shots[i].poolerObjectName));
    }

    void OnEnable()
    {
        if (selfActive)
            shoot = StartCoroutine(Shoot());
    }

    void OnDisbable()
    {
        if (selfActive)
            StopCoroutine(shoot);
    }

    protected override IEnumerator Shoot()
    {
        icount = count;
        step = 0;
        if (delay > 0)
            yield return new WaitForSeconds(delay);

        do
        {
            aimAtTarget = aimAt;
            aimAwayFromTarget = aimAway;
            if (aimAt || aimAway)
            {
                aimAngle = Aim(transform.position);
            }
                
            else
                aimAngle = 0;

            if (clip != null)
            {
                GameObject audioClip = AudioScript.PlayClipAt(clip, transform.position, volume);
            }

            for (int i = 0; i < shots.Length; i++)
            {
                poolerScript = shots[i].GetPoolerScript();
                speed = shots[i].speedStart;
                endSpeed = shots[i].speedEnd;
                speedTime = shots[i].speedTime;
                posX = shots[i].pos.x;
                posY = shots[i].pos.y;
                bullets = shots[i].bullets;
                circleFire = shots[i].circle;
                angle = shots[i].angle + aimAngle;
                angleSpread = shots[i].spread;

                yield return base.Shoot();
            }

            step += stepSize;
            yield return new WaitForSeconds(interval);
            icount--;
        } while (icount > 0 || isRepeating);
    }
    */
}