using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercenary : NPCstats
{
    private void Start()
    {
        Movement();
        Attack();
        Debug.Log("Health:" + Health);
    }

    protected override void Movement()
    {
        Debug.Log("Mercenary Jumps the goblin XD ");
    }

    protected override void Attack()
    {
        Debug.Log("Mercenary Walks");
    }

}