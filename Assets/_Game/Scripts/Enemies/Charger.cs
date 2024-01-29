using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : EnemyBase
{
    [SerializeField] private GameObject rapidFirePrefab;
    protected override void OnHit()
    {
        //increase speed when hit
        MoveSpeed *= 2;
    }

    public override void Kill()
    {
        Instantiate(rapidFirePrefab, this.transform.position, Quaternion.identity);
        AudioHelper.PlayClip2D(_deathSound, 1, .1f);
        gameObject.SetActive(false);
    }
}
