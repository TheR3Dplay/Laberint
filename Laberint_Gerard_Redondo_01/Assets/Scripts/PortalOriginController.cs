using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalOriginController : MonoBehaviour
{
    public GameObject destination;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        Debug.Log("Collision detected with " + collider.gameObject.ToString());

        if (collider.gameObject.GetComponent<PlayerController>().timer > collider.gameObject.GetComponent<PlayerController>().max_time)
        {
            collider.gameObject.transform.position = destination.transform.position;
            collider.gameObject.GetComponent<PlayerController>().timer = 0.0f;
        }
    }
}
