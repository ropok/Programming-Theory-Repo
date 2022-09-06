using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilesPlayer : Projectiles
{
    protected override float defaultSpeed { get { return 10.0f; } }
    protected override float defaultBoundary { get { return 4.5f; } }

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
