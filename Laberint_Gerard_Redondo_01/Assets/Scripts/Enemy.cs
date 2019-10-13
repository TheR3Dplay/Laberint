using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    public float lenght;
    private float counter;
    private float startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime * speed;
        transform.position = new Vector2(Mathf.PingPong(counter, lenght) + startPosition, transform.position.y);
    }

    private void OnTriggerEnter2D(Collision2D jugador)
    {
        jugador.gameObject.GetComponent<PlayerController>().vida -= 30;
    }
}
