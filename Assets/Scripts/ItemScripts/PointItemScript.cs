using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointItemScript : ItemScript {
    /*
    public float posY;
    float PoC;
    float height = 7.55f;

    void Start()
    {
        PoC = GameObject.FindGameObjectWithTag("PoC").transform.position.y;
    }

    //Remove on final build
    public override void Update()
    {
        base.Update();
        if (transform.position.y >= PoC)
            posY = pointValue;
        else
        {
            posY = gameObject.transform.position.y + height;
            posY /= (2 * height);
            posY = (int)(pointValue * posY) + 1500;
        }
    }

    int CalcValue()
    {
        if (transform.position.y >= PoC)
            return pointValue;
        else
        {
            posY = gameObject.transform.position.y + height;
            posY /= (2 * height);
            return (int)(pointValue * posY) + 1500;
        }
    }

    override public void Collect()
    {
        pointValue = CalcValue();
        playerManager.AddPoint();
        base.Collect();
    }
    */
}
