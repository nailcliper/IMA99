using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserFireScript : LaserFireScript {
    /*
    [System.Serializable]
    public struct Laser
    {
        public float growDelay;
        public float growTime;
        public float startWidth;
        public float endWidth;
        public float length;
        public float fireTime;
        public bool independant;
        public bool local;
        public Vector2 spawnPos;
        public int lasers;
        public bool circle;
        public float angle;
        public float spread;
        public float internalStep;
    }
    public Laser[] lasers = new Laser[1];

    public bool aimAt;
    public bool aimAway;
    public int count = 1;
    int icount;
    public bool isRepeating = false;
    public float delay;
    public float stepSize = 0;
    float aimAngle;
    public bool selfActive = false;
    Coroutine loop;

    protected void Start()
    {
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManagerScript>();
        player = playerManager.GetPlayer();
    }

    void OnEnable()
    {
        if (selfActive)
        {
            loop = StartCoroutine(LaserLoop());
        }
    }

    void OnDisbable()
    {
        StopCoroutine(loop);
    }

    public override void StartShoot()
    {
        loop = StartCoroutine(LaserLoop());
    }

    public override void StopShoot()
    {
        StopCoroutine(loop);
    }

    IEnumerator LaserLoop()
    {
        growDelay = lasers[0].growDelay;
        growTime = lasers[0].growTime;
        width = lasers[0].endWidth;
        length = lasers[0].length;
        fireTime = lasers[0].fireTime;
        local = lasers[0].local;
        independant = lasers[0].independant;
        spawnPos = lasers[0].spawnPos;
        bullets = lasers[0].lasers;
        circleFire = lasers[0].circle;
        angle = lasers[0].angle + aimAngle;
        angleSpread = lasers[0].spread;


        icount = count;
        iStep = new List<float>();

        for(int i = 0; i < lasers.Length; i++)
        {
            iStep.Add(0);
        }

        step = 0;
        if (delay > 0)
            yield return new WaitForSeconds(delay);

        do
        {
            source = CreateSource(spawnPos, laserSource);

            aimAtTarget = aimAt;
            aimAwayFromTarget = aimAway;
            if (aimAt || aimAway)
            {
                aimAngle = Aim(source.transform.position);
            }
            else
                aimAngle = 0;
                
            for(int i = 0; i < lasers.Length; i++)
            {
                growDelay = lasers[i].growDelay;
                growTime = lasers[i].growTime;
                width = lasers[i].endWidth;
                length = lasers[i].length;
                fireTime = lasers[i].fireTime;
                local = lasers[i].local;
                independant = lasers[i].independant;
                spawnPos = lasers[i].spawnPos;
                bullets = lasers[i].lasers;
                circleFire = lasers[i].circle;
                angle = lasers[i].angle + aimAngle;
                angleSpread = lasers[i].spread;

                if (bullets > 1)
                {
                    if (circleFire)
                    {
                        angleSpread = GetAngleSpread();
                        for (float iAngle = 0; iAngle < 360; iAngle += angleSpread)
                            FireLaser(iAngle + iStep[i]);
                    }
                    else
                    {
                        maxAngle = GetMaxAngle();
                        for (float iAngle = -maxAngle; iAngle <= maxAngle; iAngle += angleSpread)
                            FireLaser(iAngle + iStep[i]);
                    }
                }
                else
                    FireLaser(0 + iStep[i]);

                iStep[i] += lasers[i].internalStep;
            }

            step += stepSize;
            yield return new WaitForSeconds(interval);
            icount--;
        } while (icount > 0 || isRepeating);
    }
    */
}
