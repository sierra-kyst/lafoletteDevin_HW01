using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] protected int PowerupDuration = 5000;
    [SerializeField] protected GameObject _artToDisable;
    protected bool poweredUp = false;
    protected int powerUpTimer = 0;
    protected Collider _collider;
    private void Start()
    {
        _collider = GetComponent<Collider>();
        _artToDisable.SetActive(true);
        _collider.enabled = true;
    }
    private void Update()
    {
        //Debug.Log("Timer: " + powerUpTimer);
        if (poweredUp == true)
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
    protected abstract void OnHit();
    protected abstract void PowerUp();
    protected abstract void PowerDown();
    private void OnTriggerEnter(Collider other)
    {
        Projectile projectile = other.GetComponent<Projectile>();
        if (projectile != null)
        {
            OnHit();
        }
    }
}
