using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : PlayerStats
{
    private void Start()
    {
        Attack();
        Run();
        Debug.Log("Health:" + Health);
    }
}
