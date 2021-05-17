using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
   
    public float speed = 10f;
    public Rigidbody2D rb;
    public Vector2 movement;
    public Camera cam;

    Vector2 mousePos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);


    }

    void FixedUpdate()
    { 
        moveCharacter(movement);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition(rb.position + (direction * speed * Time.deltaTime));
    }
 

}

