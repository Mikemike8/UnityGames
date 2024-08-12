using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float distance;
    public float transdist;
    public Transform player;
    public float yspeed = 0.5f;
    public float fspeed = 0.0f;

    public float distanceX;
    public float xStopDist = 0.05f;

    [Header("Firing")]
    public GameObject bullet;
    public Transform shootpos;
    public Vector3 shootOffSet;
    public float shootTime = 1.0f;
    private bool canShoot = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        distance =transform.position.x - player.position.x;
        distanceX = Mathf.Abs(transform.position.y - player.position.y);
        if(distance < transdist)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, fspeed);
            if(distanceX > xStopDist)
            {
                if(transform.position.y > player.position.y)
                {
                    rb.velocity = new Vector2(rb.velocity.x,-yspeed);
                }
                else if(transform.position.y < player.position.y)
                {
                    rb.velocity = new Vector2(rb.velocity.x, yspeed);
                }
            }
            else
            {
                rb.velocity = new Vector2(rb.velocity.x, 0);
            }

            if(!canShoot)
            {
                StartCoroutine(shooting());
            }


        }
    }

    IEnumerator shooting()
    {
        canShoot = true;
        yield return new WaitForSeconds(shootTime);
        Instantiate(bullet, shootpos.position, shootpos.rotation);
        canShoot = false;
    }
}
