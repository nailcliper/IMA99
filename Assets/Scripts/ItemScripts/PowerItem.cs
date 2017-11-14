using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerItem : Item {

    public int power;
    static int combo;
    static int[] comboTier = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000,
        1100, 1200, 1300, 1400, 1500, 1600, 1700, 1800, 1900, 2000, 3200, 6400, 12800, 25600, 51200 };

    protected override void Collect()
    {
        if (PlayerManager.PlayerInfo.power >= 128 && pointValue == 10)
        {
            if (combo < comboTier.Length - 1)
                combo += power;
            if (combo >= comboTier.Length)
                combo = comboTier.Length - 1;

            pointValue = comboTier[combo];
        }
        else
        {
            combo = 0;
            PlayerManager.PlayerInfo.AddPower(power);
        }
        base.Collect();
    }
}
