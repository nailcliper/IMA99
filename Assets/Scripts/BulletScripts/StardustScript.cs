using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StardustScript : BombFireScript {
    /*
    Color32[] colors;
    public GameObject stardustPrefab;
    public AudioClip clip;

    public int power = 20;
    public float speed = 1;
    public float startSpeed = 1;
    public float endSpeed = 15;
    public float speedTime = 5;
    public bool constantSpeed = false;
    int[] scales = { 1, 3, 2 };

    List<GameObject>[] size;

    void Awake()
    {
        colors = new Color32[6];
        size = new List<GameObject>[3];

        colors[0] = new Color32(255, 161, 171, 200); //Red
        colors[1] = new Color32(161, 255, 171, 200); //Green
        colors[2] = new Color32(171, 161, 255, 200); //Blue
        colors[3] = new Color32(161, 255, 255, 200); //Cyan
        colors[4] = new Color32(255, 161, 255, 200); //Magenta
        colors[5] = new Color32(255, 255, 161, 200); //Yellow
        size[0] = new List<GameObject>();
        size[1] = new List<GameObject>();
        size[2] = new List<GameObject>();

    }

    public override void FireBomb()
    {
        base.FireBomb();
        GameObject obj;
        size[0] = new List<GameObject>();
        size[1] = new List<GameObject>();
        size[2] = new List<GameObject>();

        if (clip != null)
        {
            GameObject audioClip = AudioScript.PlayClipAt(clip, transform.position, 1f);
        }

        for (float iAngle = 0; iAngle < 360; iAngle += 15)
        {
            for (int i = 0; i <= 2; i++)
            {
                obj = Instantiate(stardustPrefab);
                int icolor = Random.Range(0, 6);
                obj.GetComponent<SpriteRenderer>().color = colors[icolor];

                obj.transform.position = new Vector2(
                    (transform.position.x),
                    (transform.position.y));

                obj.transform.eulerAngles = new Vector3(
                    0,
                    0,
                    iAngle);


                obj.transform.localScale = new Vector3(scales[i], scales[i], 1);

                obj.GetComponent<BulletScript>().SetSpeed(speed, endSpeed, speedTime);
                obj.GetComponent<BulletScript>().SetPower(power);
                obj.GetComponent<BulletScript>().SetIsBomb(true);

                size[i].Add(obj);
                iAngle += 10;
            }
        }
        StartCoroutine(ActivateSize(size[1], 0.1f));
        StartCoroutine(ActivateSize(size[2], 0.2f));
        StartCoroutine(ActivateSize(size[0], 0.25f));

    }

    IEnumerator ActivateSize(List<GameObject> size, float delay)
    {
        yield return new WaitForSeconds(delay);
        foreach(GameObject shot in size)
        {
            shot.SetActive(true);
        }
    }
    */
}
