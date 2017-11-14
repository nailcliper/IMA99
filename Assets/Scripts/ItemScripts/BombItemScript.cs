using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombItemScript : Item {
    
    protected override void Collect()
    {
        PlayerManager.PlayerInfo.AddBomb();
        base.Collect();
    }
    
}
