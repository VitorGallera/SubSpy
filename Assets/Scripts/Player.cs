using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    public float maxAltura;
    public float minAltura;
    public int health = 3;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(0, Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput * speed;

    }

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < maxAltura)
        {
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > minAltura)
        {
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        }




    }
}
