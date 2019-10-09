using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float healt;

    private Vector2 movement;
    public float speed = 50.0f;

    public float timer = 0.0f;
    public float max_time = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        timer += Time.deltaTime;
    }

    void FixedUpdate()
    {
        rb.MovePosition((Vector2)transform.position + (movement * speed * Time.deltaTime));
    }
}
