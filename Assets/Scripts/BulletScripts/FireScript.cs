using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour {
    /*
    protected bool circleFire = false;
    protected int bullets = 1;
    protected bool aimAtTarget = false;
    protected bool aimAwayFromTarget = false;
    protected float angle;
    protected float angleSpread;
    protected float maxAngle;
    protected float step = 0;
    protected List<float> iStep;

    protected Vector2 targetPos;

    protected PlayerManagerScript playerManager;
    protected GameObject target;


    public virtual void StartShoot() { }
    public virtual void StopShoot() { }

    void Awake()
    {
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManagerScript>();
    }

    protected float Aim(Vector2 selfPos) //Fix aimaway
    {
        float aimAngle = GetAngleToTarget(selfPos);

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

    protected float GetAngleToTarget(Vector2 selfPos)
    {
        if (!target)
            target = playerManager.GetPlayer();
        targetPos = target.transform.position;

        return ((Mathf.Atan2(targetPos.y - selfPos.y, targetPos.x - selfPos.x) * Mathf.Rad2Deg) - 90);
    }
    */
}
