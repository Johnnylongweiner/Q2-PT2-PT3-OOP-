using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : NPCstats 
{

    private void Start()
    {
        Movement();
        Attack();
        Debug.Log("Health:" + Health);
    }

    protected override void Movement()
    {
        Debug.Log("Goblin moves");
    }

    protected override void Attack()
    {
        Debug.Log("Goblin sucks the player's power");
    }
    public void Damge(int damage)
    {
        Debug.Log("Goblin Health")



    }

}