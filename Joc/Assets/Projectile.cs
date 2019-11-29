using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject player;

    public float speedProjectile = 20.0f;

    public Rigidbody2D rgbd2D;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rgbd2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        player = GameObject.Find("Player_01");

        if(player != null)
        {
            switch (player.GetComponent<PlayerController>().current_weapon)
            {
                case WEAPON_TYPE.TYPE_NORMAL:
                    {
                        speedProjectile = 475.0f;
                    }
                    break;
                case WEAPON_TYPE.TYPE_02:
                    {
                        speedProjectile = 1500.0f;
                        animator.SetBool("Activate_Weapon_02", true);
                    }
                    break;
                case WEAPON_TYPE.TYPE_UNKNOWN:
                    break;
                default:
                    break;
            }
        }

        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        rgbd2D.velocity = transform.right * speedProjectile * Time.deltaTime;
    }
}
