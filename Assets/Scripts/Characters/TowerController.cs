using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NavGame.Core;

public class TowerController : ThrowerGameObject
{
    protected virtual void UpdateAttack()
    {
        if (enemiesToAttack.Count > 0)
        {
            FaceObjectFrame(enemiesToAttack[0].gameObject.transform);
            AttackOnCooldown(enemiesToAttack[0]);

        }
    }
}
