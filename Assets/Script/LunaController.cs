using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunaController : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    private Vector2 movement;
    public float moveSpeed;

    void Start()
    {
        moveSpeed = 4;
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        movement = new Vector2(horizontal, vertical);
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position + movement * moveSpeed * Time.fixedDeltaTime;
        rigidbody2d.MovePosition(position);
    }
}
