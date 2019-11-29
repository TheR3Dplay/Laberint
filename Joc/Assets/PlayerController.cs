using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WEAPON_TYPE
{
    TYPE_UNKNOWN = -1,
    TYPE_NORMAL,
    TYPE_02
}

public class PlayerController : MonoBehaviour
{
    public WEAPON_TYPE current_weapon = WEAPON_TYPE.TYPE_NORMAL;

    public Rigidbody2D elMeuRgb2D;
    public Animator elMeuAnimator;

    [SerializeField]
    float speedRun = 1;

    [SerializeField]
    float jumpForce = 10000.0f;

    [SerializeField]
    Transform SpawnPoint;

    [SerializeField]
    GameObject PrefabProyectile;

    /* --------- */


    // Start is called before the first frame update
    void Start()
    {
        //inicializo la variable marioRgb2D con el rigidBody del gameObject
        elMeuRgb2D = GetComponent<Rigidbody2D>();

        elMeuAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject != null && Time.timeScale == 1)
        {

            float vx = Input.GetAxisRaw("Horizontal");
            float vy = elMeuRgb2D.velocity.y;

            elMeuRgb2D.velocity = new Vector2(vx * speedRun, vy);
            //cuando corra el personaje activa la variable Run = true

            //derecha
            if (vx > 0)
            {
                elMeuAnimator.SetBool("Run", true);
                //transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
                transform.rotation = Quaternion.Euler(0,0,0);
            }
            //izquierda
            if (vx < 0)
            {
                elMeuAnimator.SetBool("Run", true);
                //transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            //stop
            if (vx == 0)
            {
                elMeuAnimator.SetBool("Run", false);
            }
            //attack
            if (Input.GetKeyDown(KeyCode.L))
            {
                Instantiate(PrefabProyectile, SpawnPoint.position, SpawnPoint.rotation);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                elMeuAnimator.SetBool("Jump", true);
                elMeuRgb2D.AddForce(new Vector2(0, jumpForce));
            }

        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            elMeuAnimator.SetBool("Jump", false);
        }

        if (collision.collider.tag == "PickUp_Weapon")
        {
            current_weapon = WEAPON_TYPE.TYPE_02;

            PrefabProyectile.gameObject.GetComponent<Projectile>().speedProjectile = 100.0f;
            PrefabProyectile.gameObject.GetComponent<Animator>().SetBool("Activate_Weapon_02", true);
            Debug.Log(PrefabProyectile.gameObject.GetComponent<Animator>().GetBool("Activate_Weapon_02"));
            
            Destroy(collision.gameObject);
        }
    }
}
