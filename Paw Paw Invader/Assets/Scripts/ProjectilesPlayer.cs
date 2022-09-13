using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// INHERITANCE
public class ProjectilesPlayer : Projectiles
{
    // ENCAPSULATION
    protected override float defaultSpeed { get { return 10.0f; } }
    protected override float defaultBoundary { get { return 4.5f; } }
    protected override float defaultMaxDamage { get { return 5.0f; } }
    // POLYMORPHISM
    protected override void Explode()
    {
        Debug.Log("Yummy in my tummy!");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cat"))
        {
            Explode();
            Destroy(gameObject);
        }
    }

}
