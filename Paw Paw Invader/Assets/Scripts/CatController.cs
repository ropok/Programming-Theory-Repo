using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [SerializeField] float thrust = 1.0f;
    [SerializeField] GameObject projectilePrefab;

    // boundary
    private float boundaryX = 8.0f;
    private float boundaryMove;
    private float currentPosition;

    private bool isMoving = false;
    private float movingDirection = 1;

    public float satietyLevel = 0f;

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
        if (transform.position.x >= currentPosition + boundaryMove || transform.position.x <= currentPosition - boundaryMove)
        {
            isMoving = false;
        }

        if (isMoving)
        {
            rb2D.MovePosition(rb2D.position + new Vector2(movingDirection * thrust * Time.deltaTime, 0));
        }
        else
        {
            GetBoundaryMovement(boundaryX/2);
            currentPosition = transform.position.x;
            movingDirection = -movingDirection;
            isMoving = true;
        }
    }

    void MovementBoundary(float boundaryX)
    {
        if (transform.position.x >= boundaryX)
        {
            transform.position = new Vector2(boundaryX, transform.position.y);
            isMoving = false;
        }
        if (transform.position.x <= -boundaryX)
        {
            transform.position = new Vector2(-boundaryX, transform.position.y);
            isMoving = false;
        }
    }

    void ShootControl(GameObject projectilePrefab)
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        //}
    }

    float GetBoundaryMovement(float boundary_X)
    {
        boundaryMove = Random.Range(0, boundary_X);
        return boundaryMove;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("CatFood") && satietyLevel <= 100)
        { 
        
            satietyLevel += collision.GetComponent<ProjectilesPlayer>().m_damage;
            Debug.Log("Satiety Level: " + satietyLevel);
        }
    }

}
