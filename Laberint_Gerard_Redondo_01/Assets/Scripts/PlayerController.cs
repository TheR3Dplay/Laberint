using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    [SerializeField]
    float speed = 1f;

    [SerializeField]
    float rotation;

    [SerializeField]
    float vida;

    Transform transformada;

    public float timer = 0.0f;
    public float max_time = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transformada = GetComponent<Transform>();

        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = transform.up * speed * Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.A))
        {
            transformada.Rotate(0, 0, rotation * Time.deltaTime * speed);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transformada.Rotate(0, 0, -rotation * Time.deltaTime * speed);

        }

        timer += Time.deltaTime;
    }
}
