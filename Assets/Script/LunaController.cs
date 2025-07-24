using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunaController : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    private Vector2 movement;
    public float moveSpeed = 4;
    private int maxHealth = 5;//Luna的最大健康值
    private int currentHealth;//Luna的当前健康值

    public int CurrentHealth { get => currentHealth; }
    public int MaxHealth { get => maxHealth;}

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth; // 初始化当前健康值为最大健康值
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

    public void ChangeHeath( int amount)
    {
        currentHealth = Mathf.Clamp(CurrentHealth + amount, 0, maxHealth);
    }
}
