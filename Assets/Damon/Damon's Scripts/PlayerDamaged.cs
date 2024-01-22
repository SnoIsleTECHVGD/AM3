using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamaged : MonoBehaviour
{
    public GameObject player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Stats hitStats = collision.gameObject.GetComponent<Stats>();
        Stats ourStats = GetComponent<Stats>();

        if (ourStats != null)
        {
            ourStats.health -= hitStats.damage;
            if (ourStats.health <= 0)
            {
                player.GetComponent<Lose>().isAlive = false;
            }
        }
    }
}