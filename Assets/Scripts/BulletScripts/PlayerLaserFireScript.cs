using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaserFireScript : LaserFireScript {
    /*
    bool fireButtonDown = false;
    bool isFiring = false;
    int currentLevel = 0;
    Coroutine intervalRoutine;

    [System.Serializable]
    public struct Level
    {
        public float interval;
        public int power;
        public float growDelay;
        public float growTime;
        public float width;
        public float length;
        public float fireTime;
    }
    public Level[] levels = new Level[6];

    void Awake()
    {
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManagerScript>();
        player = playerManager.GetPlayer();
    }

    void Update()
    {
        fireButtonDown = PlayerControllerScript.current.GetFireBool();
        if(fireButtonDown && !isFiring)
        {
            source = new GameObject("Source");
            source.tag = "Laser";
            source.transform.position = gameObject.transform.position;
            FireLaser(0,0, true);
            intervalRoutine = StartCoroutine(SetIsFiring(true));
            intervalRoutine = StartCoroutine(SetIsFiring(false, interval));
        }
    }

    void OnEnable()
    {
        isFiring = false;
    }

    public void ResetInvterval()
    {
        StopCoroutine(intervalRoutine);
        intervalRoutine = StartCoroutine(SetIsFiring(false,1f));
    }
    public IEnumerator SetIsFiring(bool b = false, float time = 0)
    {
        if (time > 0)
            yield return new WaitForSeconds(time);

        isFiring = b;
    }

    public void SetLevel(int playerLevel)
    {
        currentLevel = playerLevel;

        interval = levels[currentLevel].interval;
        power = levels[currentLevel].power;
        growDelay = levels[currentLevel].growDelay;
        growTime = levels[currentLevel].growTime;
        width = levels[currentLevel].width;
        length = levels[currentLevel].length;
        fireTime = levels[currentLevel].fireTime;

        foreach(Transform child in gameObject.transform)
        {
            if(child.gameObject.CompareTag("Laser"))
            {
                child.localScale = new Vector3(width, width, 1);
                GameObject laser = child.transform.GetChild(0).GetChild(0).gameObject;
                laser.transform.localPosition = new Vector2(spawnPos.x, spawnPos.y + ((length / 4) / width));
                laser.GetComponent<LaserScript>().SetLaserProperties(gameObject, growDelay, growTime, 1, (length / width), fireTime, power);
                laser.transform.localScale = new Vector3(1, length / width, 1);
            }
        }
    }
    */
}
