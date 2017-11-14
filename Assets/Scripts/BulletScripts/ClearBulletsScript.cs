using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ClearBulletsScript {
    public static List<BulletScript> eBullets = new List<BulletScript>();
    public static List<LaserScript> eLasers = new List<LaserScript>();

    public static void ClearEnemyLasers()
    {
        for(int i = 0; i < eLasers.Count; i++)
        {
            //eLasers[i].StartFadeOut();
        }
    }

    public static void ClearEnemyOnce()
    {
        for (int i = 0; i < eBullets.Count; i++)
        {
            //BulletScript bscript = eBullets[i].GetComponent<BulletScript>();
            eBullets[i].Erase(true);
        }
    }

    public static void EnemyToStar()
    {
        for(int i = 0; i < eBullets.Count; i++)
        {
            //BulletScript bscript = eBullets[i].GetComponent<BulletScript>();
            eBullets[i].Erase(true);
        }
    }

    public static IEnumerator ClearEnemy(float wait = 0f)
    {
        if(wait > 0)
            yield return new WaitForSeconds(wait);

        float t = 0.8f;
        while (t>0)
        {
            t -= Time.deltaTime;
            for(int i = 0; i < eBullets.Count; i++)
            {
                //BulletScript bscript = eBullets[i].GetComponent<BulletScript>();
                eBullets[i].Erase();
            }
            yield return new WaitForFixedUpdate();
        }
    }

    /*
    public static IEnumerator ClearPlayer()
    {
        float t = 0.8f;
        while (t > 0)
        {
            t -= Time.deltaTime;
            for (int i = 0; i < pBullets.Count; i++)
            {
                //BulletScript bscript = pBullets[i].GetComponent<BulletScript>();
                eBullets[i].Erase(true);
            }
            yield return new WaitForFixedUpdate();
        }
    }
    */
}
