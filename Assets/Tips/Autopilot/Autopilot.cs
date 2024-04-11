using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autopilot
{
    public void Run()
    {
        while (!BattleManager.SetAction(Random.Range(0, 4)))
        {
            ;
        }
        BattleManager.TryBattle();
    }
}
