using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [SerializeField] float thrust = 20.0f;
    [SerializeField] GameObject projectilePrefab;

    // boundary
    private float boundaryX = 8.0f;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MovePlayer(thrust);
        MovementBoundary(boundaryX);
        ShootControl(projectilePrefab);

    }

    void MovePlayer(float thrust)
    {
        float horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime;
        rb2D.MovePosition(rb2D.position + new Vector2(horizontalInput * thrust, 0));
    }

    void MovementBoundary(float boundaryX)
    {
        if (transform.position.x >= boundaryX)
        {
            transform.position = new Vector2(boundaryX, transform.position.y);
        }
        if (transform.position.x <= -boundaryX)
        {
            transform.position = new Vector2(-boundaryX, transform.position.y);
        }
    }

    void ShootControl(GameObject projectilePrefab)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

}