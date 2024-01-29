using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFirePowerup : PowerUpBase
{
    public TurretController turt;
    private void Start()
    {
        GameObject.Find("TurretController").GetComponent<TurretController>();
        _collider = GetComponent<Collider>();
        Debug.Log("Rate of Fire: " + turt.FireCooldown);
    }
    protected override void OnHit()
    {
        PowerUp();
    }
    protected override void PowerUp()
    {
        turt.FireCooldown = .25f;
        _artToDisable.SetActive(false);
        _collider.enabled = false;
        poweredUp = true;
        Debug.Log("Rate of Fire: " + turt.FireCooldown);
    }
    protected override void PowerDown()
    {
        turt.FireCooldown = .5f;
        Debug.Log("Rate of Fire: " + turt.FireCooldown);
        gameObject.SetActive(false);
    }
}
