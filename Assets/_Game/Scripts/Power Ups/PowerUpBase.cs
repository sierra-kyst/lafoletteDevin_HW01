using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    protected int PowerupDuration = 500;
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
