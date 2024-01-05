using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnHit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Stats hitStats = collision.gameObject.GetComponent<Stats>();
        Stats ourStats = GetComponent<Stats>();

        if (hitStats != null)
        {
            hitStats.health -= ourStats.damage;

            if (hitStats.health <= 0)
            {
                Destroy(hitStats.gameObject);
            }
        }
    }
   
}
