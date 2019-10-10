using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCollider : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D jugador)
    {
        jugador.gameObject.GetComponent<PlayerController>().vida -= 10;
    }
}
