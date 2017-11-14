using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFireScript : FireScript {
    /*
    public string poolerObjectName;
    public float interval;
    public AudioClip clip;
    [Range(0, 1)]
    public float volume = 0.1f;

    protected GameObject poolerObj;
    protected ObjectPoolerScript poolerScript;
    //protected PlayerManagerScript playerManager;
    protected GameObject player;

    protected float speed;
    protected float endSpeed;
    protected float speedTime;

    protected float scaleX = 1;
    protected float scaleY = 1;
    protected float posX;
    protected float posY;
    protected float driftX = 0;

    //protected bool circleFire = false;
    //protected int bullets = 1;

    //protected bool aimAtTarget = false;
    //protected bool aimAwayFromTarget = false;
    //protected float angle;
    //protected float angleSpread;
    //protected float step = 0;
    protected int power = 0;

    //float maxAngle;
    protected Coroutine shoot;

    public override void StartShoot()
    {
        shoot = StartCoroutine(Shoot());
    }

    public override void StopShoot()
    {
        StopCoroutine(shoot);
    }

    void OnDisable()
    {
        StopAllCoroutines();
    }

    protected void FireShot(float iAngle = 0)
    {
        //Gets next pooled object
        GameObject obj = poolerScript.GetPooledObject();

        obj.transform.position = new Vector2(
                    (posX + transform.position.x),
                    (posY + transform.position.y));

        obj.transform.eulerAngles = new Vector3(
                    0,
                    0,
                    iAngle + angle + step);

        obj.transform.localScale = new Vector2(
            scaleX,
            scaleY);

        //BulletScript script = obj.AddComponent<BulletScript>();
        //script.SetSpeed(speed, endSpeed, speedTime, driftX);
        //script.SetPower(power);
        obj.GetComponent<BulletScript>().SetSpeed(speed, endSpeed, speedTime, driftX);
        obj.GetComponent<BulletScript>().SetPower(power);

        obj.SetActive(true);
    }

    protected virtual IEnumerator Shoot()
    {
        if (bullets > 1)
        {
            if (circleFire)
            {
                angleSpread = GetAngleSpread();
                for (float iAngle = 0; iAngle < 360; iAngle += angleSpread)
                    FireShot(iAngle);
            }
            else
            {
                maxAngle = GetMaxAngle();
                for (float iAngle = -maxAngle; iAngle <= maxAngle; iAngle += angleSpread)
                    FireShot(iAngle);
            }
        }
        else
            FireShot();

        yield return null;
    }

    /*
    protected float Aim() //Fix aimaway
    {
        float aimAngle = GetAngleToTarget();

        if (aimAwayFromTarget)
        {
            if (circleFire)
                aimAngle += (GetAngleSpread() / 2);
            else
                aimAngle += 180;
        }

        return aimAngle;
    }

    protected float GetAngleSpread()
    {
        if (bullets != 0)
            return (360 / (float)bullets);
        else
            return 0;
    }

    protected float GetMaxAngle()
    {
        if (bullets % 2 == 0)
            return ((bullets / 2) * angleSpread) - (angleSpread / 2);
        else
            return ((bullets - 1) / 2) * angleSpread;
    }

    protected float GetAngleToTarget()
    {
        selfX = transform.position.x;
        selfY = transform.position.y;
        targetX = target.transform.position.x;
        targetY = target.transform.position.y;

        return ((Mathf.Atan2(targetY - selfY, targetX - selfX) * Mathf.Rad2Deg) - 90);
    }
    */
}
