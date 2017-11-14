using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointItem : Item {

    float height = 7.55f;
    float PoC = 3.7f;

    protected override void Collect()
    {
        if(transform.position.y < PoC)
        {
            pointValue = (int)(pointValue * ((transform.position.y + height) / (2 * height))) + 1400;
        }
        PlayerManager.PlayerInfo.AddPoint();
        base.Collect();
    }
}
