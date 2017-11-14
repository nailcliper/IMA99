using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterSparkScript : BombFireScript {
    /*
    public GameObject sparkPrefab;
    public AudioClip sparkClip;
    public int power = 1;
    public float delay = 0;
    public float growTime = 0.5f;
    public float width = 8;
    public float length = 5;
    public float fireTime = 5;

    Collider2D hibox;

    Color32[] colors = new Color32[4];
    float[] angles = new float[4];
    Vector2[] pos = new Vector2[4];

    void Awake()
    {
        colors[0] = new Color32(255, 161, 171, 107); //Red
        colors[1] = new Color32(161, 255, 171, 107); //Green
        colors[2] = new Color32(171, 161, 255, 107); //Blue
        colors[3] = new Color32(161, 255, 171, 107); //Green

        angles[0] = 13;
        angles[1] = 5.3f;
        angles[2] = -5.3f;
        angles[3] = -13;

        pos[0] = new Vector2(-2.15f, 9.5f);
        pos[1] = new Vector2(-0.9f, 9.7f);
        pos[2] = new Vector2(0.9f, 9.7f);
        pos[3] = new Vector2(2.15f, 9.5f);

    }

    public override void FireBomb()
    {
        base.FireBomb();

        if (sparkClip != null)
        {
            GameObject audioClip = AudioScript.PlayClipAt(sparkClip, transform.position, 1f);
        }

        foreach (Transform child in gameObject.transform)
        {
            if(child.gameObject.GetComponent<PlayerLaserFireScript>())
            {
                foreach (Transform grandchild in child.transform)
                    if (grandchild.gameObject.CompareTag("Laser"))
                        grandchild.gameObject.transform.GetChild(0).GetChild(0).gameObject.GetComponent<LaserScript>().StartFadeOut();
                child.gameObject.GetComponent<PlayerLaserFireScript>().ResetInvterval();
            }
        }

        GameObject container = new GameObject("MasterSpark");
        container.transform.position = gameObject.transform.position;
        container.transform.parent = gameObject.transform;
        container.tag = "Laser";
        for (int i = 0; i < 4; i++)
        {
            GameObject obj = Instantiate(sparkPrefab);
            obj.transform.parent = container.transform;
            obj.transform.localPosition = pos[i];
            obj.transform.localEulerAngles = new Vector3(0, 0, angles[i]);
            obj.GetComponent<SpriteRenderer>().color = colors[i];

            LaserScript script = obj.GetComponent<LaserScript>();
            script.SetLaserProperties(gameObject, delay, growTime, width, length, fireTime, power, true);

            obj.SetActive(true);
        }
    }
    */
}
