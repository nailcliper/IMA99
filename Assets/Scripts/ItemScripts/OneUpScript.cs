using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneUpScript : Item {
    
    protected override void Collect()
    {
        PlayerManager.PlayerInfo.AddLife();
        base.Collect();
    }
    
}
