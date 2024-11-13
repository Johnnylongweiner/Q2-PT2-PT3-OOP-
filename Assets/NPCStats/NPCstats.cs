using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCstats : MonoBehaviour
{
    [SerializeField] protected int Health;
    [SerializeField] protected int attack;
    [SerializeField] protected float speed;
    [SerializeField] protected int mana;
    [SerializeField] protected int defense;
    [SerializeField] protected float luck;

    protected abstract void Movement();

    protected abstract void Attack();
}
