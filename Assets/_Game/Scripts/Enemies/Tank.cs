using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : EnemyBase
{
    private bool waiting = false;
    private int timer = 0;
    private void Start()
    {
        MoveSpeed = 0.05f;
    }
    private void Update()
    {
        if (waiting == true)
        {
            MoveSpeed = 0;
            timer++;
            if(timer >= 100)
            {
                waiting = false;
                MoveSpeed = 0.05f;
                timer = 0;
            }
        }
    }
    protected override void OnHit()
    {
        waiting = true;
    }
}
