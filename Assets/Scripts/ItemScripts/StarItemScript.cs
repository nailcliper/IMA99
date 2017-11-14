using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarItemScript : Item {

    public bool bombed { get; set; }

    protected override void Collect()
    {
        if (!bombed)
            pointValue = 500 + (10 * (int)(PlayerManager.PlayerInfo.graze / 3));
        base.Collect();
    }
}
