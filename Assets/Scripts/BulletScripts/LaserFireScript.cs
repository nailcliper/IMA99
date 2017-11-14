using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserFireScript : FireScript {
    /*
    //protected PlayerManagerScript playerManager;
    protected GameObject player;
    public AudioClip laserClip;
    [Range(0, 1)]
    public float volume = 0.1f;

    public GameObject laserBase;
    public GameObject laserSource;
    public float interval;

    protected int power = 1;
    public Sprite laserSprite;
    protected float growDelay;
    protected float growTime;
    protected float width;
    protected float length;
    protected float fireTime;
    public bool independant = false;
    public bool local = true;
    public Vector2 spawnPos;

    Collider2D hitBox;
    protected Coroutine shoot;
    protected GameObject source;

    protected void FireLaser(float iAngle = 0, float iStep = 0, bool playerShot = false)
    {
        //source.transform.position = gameObject.transform.position;
        if (independant)
            source.transform.SetParent(null);
        else
            source.transform.parent = gameObject.transform;
        source.transform.localScale = new Vector3(width, width, 1);

        GameObject container = new GameObject("Container");
        container.tag = "Laser";
        container.transform.parent = source.transform;
        container.transform.localPosition = new Vector3(0, 0, 0);
        container.transform.localScale = new Vector3(1, 1, 1);

        GameObject obj = Instantiate(laserBase);
        if (playerShot)
            obj.tag = "PlayerLaser";
        else
        {
            obj.tag = "EnemyLaser";
            Destroy(obj.GetComponent<BulletScript>());
            Destroy(obj.GetComponent<Animator>());
            obj.AddComponent<LaserScript>();
            //gameObject.GetComponent<EnemyScript>().activeLasers.Add(obj);
        }
        obj.transform.parent = container.transform;
        obj.transform.localPosition = new Vector2(0, ((length / 4) / width));

        source.transform.eulerAngles = new Vector3(0,0, step);
        container.transform.eulerAngles = new Vector3(0, 0, angle + iAngle + iStep);

        LaserScript script = obj.GetComponent<LaserScript>();
        script.setClip(laserClip, volume);
        script.SetLaserProperties(gameObject, growDelay, growTime, 1, (length / width), fireTime, power);

        obj.SetActive(true);
    }

    protected GameObject CreateSource(Vector2 pos, GameObject laserSource = null)
    {
        GameObject lSource;
        if (laserSource)
            lSource = Instantiate(laserSource);
        else
            lSource = new GameObject("Laser");

        if (local)
            lSource.transform.position = (Vector2)gameObject.transform.position + pos;
        else
            lSource.transform.position = pos;
        lSource.tag = "Laser";
        return lSource;
    }

    /*
        protected void FireShot(float iAngle = 0)
    {
        obj.transform.position = new Vector2(
                    (posX + transform.position.x),
                    (posY + transform.position.y));

        obj.transform.localScale = new Vector2(
            scaleX,
            scaleY);
    }
    */
}
