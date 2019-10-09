using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    float grausRotacio;
    Transform transformada;


    // Start is called before the first frame update
    void Start()
    {
        transformada = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transformada.Rotate(0, 0, grausRotacio * Time.deltaTime);
        
    }
}
