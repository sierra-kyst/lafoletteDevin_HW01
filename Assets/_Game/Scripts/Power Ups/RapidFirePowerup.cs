using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFirePowerup : PowerUpBase
{
    protected override void OnHit()
    {
        PowerUp();
    }
    protected override void PowerUp()
    {
        TurretController.FireCooldown = 1f;
    }
    protected override void PowerDown()
    {

    }
}
