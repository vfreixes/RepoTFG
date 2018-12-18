﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
     
        PlayerController player = other.transform.GetComponentInParent<PlayerController>();
        EnemyController enemy = other.transform.GetComponentInParent<EnemyController>();
        if (player == null)
        {
            return;
        }
        if (player.hardAttack) enemy.DoDamage(15);

        else enemy.DoDamage(8);
    }
}
