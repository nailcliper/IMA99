using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour {

    public GameObject bulletPrefab;

    protected ObjectPoolerScript pooler;
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

    void Start()
    {
        pooler = ObjectPoolerScript.bulletPoolers[bulletPrefab.name];
        //StartCoroutine(Fire());
    }

    IEnumerator Fire()
    {
        if(delay > 0)
            yield return new WaitForSeconds(delay);

        if(useVectors)
        {
            FireShot(pooler, spawnPos, startSpeedVec, endSpeedVec, accelerationVec, angle);
        }
        else
        {
            FireShot(pooler, spawnPos, startSpeed, endSpeed, acceleration, angle);
        }
    }

    public static GameObject FireShot(ObjectPoolerScript _pool, Vector2 _spawnPos, float _speed, float _angle = 0, float _delay = 0)
    {

        GameObject obj = _pool.GetPooledObject();

        obj.transform.position = _spawnPos;
        obj.transform.eulerAngles = new Vector3(0, 0, _angle);
        obj.SetActive(true);
        obj.GetComponent<Bullet>().SetSpeed(_speed);

        return obj;
    }

    public static GameObject FireShot(ObjectPoolerScript _pool, Vector2 _spawnPos, float _speed, float _endSpeed, float _acceleration, float _angle = 0, float _delay = 0)
    {

        GameObject obj = _pool.GetPooledObject();

        obj.transform.position = _spawnPos;
        obj.transform.eulerAngles = new Vector3(0, 0, _angle);
        obj.SetActive(true);
        obj.GetComponent<Bullet>().SetSpeed(_speed, _endSpeed, _acceleration);

        return obj;
    }

    public static GameObject FireShot(ObjectPoolerScript _pool, Vector2 _spawnPos, Vector2 _scale, float _speed, float _endSpeed, float _acceleration, float _angle = 0, float _delay = 0)
    {

        GameObject obj = _pool.GetPooledObject();

        obj.transform.position = _spawnPos;
        obj.transform.localScale = _scale;
        obj.transform.eulerAngles = new Vector3(0, 0, _angle);
        obj.SetActive(true);
        obj.GetComponent<Bullet>().SetSpeed(_speed, _endSpeed, _acceleration);

        return obj;
    }

    public static GameObject FireShot(ObjectPoolerScript _pool, Vector2 _spawnPos, Vector2 _speed, float _angle, float _delay = 0)
    {

        GameObject obj = _pool.GetPooledObject();

        obj.transform.position = _spawnPos;
        obj.transform.eulerAngles = new Vector3(0, 0, _angle);
        obj.SetActive(true);
        obj.GetComponent<Bullet>().SetSpeed(_speed, new Vector2(), new Vector2());

        return obj;
    }

    public static GameObject FireShot(ObjectPoolerScript _pool, Vector2 _spawnPos, Vector2 _scale, Vector2 _speed, Vector2 _endSpeed, Vector2 _acceleration, float _angle, float _delay = 0)
    {

        GameObject obj = _pool.GetPooledObject();

        obj.transform.position = _spawnPos;
        obj.transform.position = _scale;
        obj.transform.eulerAngles = new Vector3(0, 0, _angle);
        obj.SetActive(true);
        obj.GetComponent<Bullet>().SetSpeed(_speed, _endSpeed, _acceleration);

        return obj;
    }

    public static GameObject FireShot(ObjectPoolerScript _pool, Vector2 _spawnPos, Vector2 _speed, Vector2 _endSpeed, Vector2 _acceleration, float _angle, float _delay = 0)
    {

        GameObject obj = _pool.GetPooledObject();

        obj.transform.position = _spawnPos;
        obj.transform.eulerAngles = new Vector3(0, 0, _angle);
        obj.SetActive(true);
        obj.GetComponent<Bullet>().SetSpeed(_speed, _endSpeed, _acceleration);

        return obj;
    }

    public static float GetAngleSpread(int _bullets)
    {
        if (_bullets != 0)
            return (360 / (float)_bullets);
        else
            return 0;
    }

    public static float GetMaxAngle(int _bullets, float _spread)
    {
        //float spread = GetAngleSpread(_bullets);

        if (_bullets % 2 == 0)
            return ((_bullets / 2) * _spread) - (_spread / 2);
        else
            return ((_bullets - 1) / 2) * _spread;
    }
}
