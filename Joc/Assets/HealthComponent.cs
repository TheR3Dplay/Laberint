using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Libreria de acceso a UI

public class HealthComponent : MonoBehaviour
{
    [SerializeField]
    float health = 10;

    [SerializeField]
    Text textField;


    // Start is called before the first frame update
    void Start()
    {

        if (textField != null)
        {
            textField.text = health + " punts";
        }
    }

    public void DoDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);

        }

        //actualizar si no està buida la variable
        if (textField != null)
        {
            textField.text = health + " punts";
        }
    }


}
