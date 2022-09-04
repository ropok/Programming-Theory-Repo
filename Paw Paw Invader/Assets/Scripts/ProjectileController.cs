using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] float speed;

    private float boundaryY = 4.5f;


    // Update is called once per frame
    void Update()
    {
        ProjectileMovement(speed);
        ProjectileBoundary(boundaryY);

    }

    void ProjectileMovement(float speed)
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    void ProjectileBoundary(float boundaryY)
    {
        if (transform.position.y >= boundaryY)
        {
            Destroy(gameObject);
        }

    }
}
