using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFirePowerup : PowerUpBase
{
    private TurretController turret;
    private bool poweredUp = false;
    private int powerUpTimer = 0;
    private int spawnTimer = 0;
    private bool startSpawnTimer = true;
    private void Start()
    {

        gameObject.SetActive(false);
    }
    private void Update()
    {
        if(startSpawnTimer == true)
        {
            spawnTimer++;
            if(spawnTimer >= 1000)
            {
                gameObject.SetActive(true);
                startSpawnTimer = false;
                spawnTimer = 0;
            }
        }
        if(poweredUp == true)
        {
            powerUpTimer++;
            if (powerUpTimer >= PowerupDuration)
            {
                PowerDown();
                poweredUp = false;
                powerUpTimer = 0;
            }
        }
    }
    protected override void OnHit()
    {
        PowerUp();
        gameObject.SetActive(false);
        startSpawnTimer = true;
    }
    protected override void PowerUp()
    {
        turret.FireCooldown = 0.25f;
        poweredUp = true;
    }
    protected override void PowerDown()
    {
        turret.FireCooldown = 0.5f;
    }
}
