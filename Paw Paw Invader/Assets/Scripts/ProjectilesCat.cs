using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilesCat : Projectiles
{
    protected override float defaultSpeed { get { return -3.0f; } }
    protected override float defaultBoundary { get { return -4.5f; } }
    protected override float defaultMaxDamage { get { return 5.0f; } }

    protected override void Explode()
    {
        //Debug.Log("Kapaw!");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Explode();
            Destroy(gameObject);
        }
    }
}
