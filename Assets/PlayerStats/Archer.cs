using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : PlayerStats 
{

    private void Start()
    {
        Attack();
        Run();
        Debug.Log("Health:" + Health);
    }

    protected override void Run()
    {
        Debug.Log("Archer Dips");
    }

    protected override void Attack()
    {
        Debug.Log("Archer shoots the bling");
    }
    public void Damge (int damage)
    {
        Debug.Log("Archer Health")



    }
}
