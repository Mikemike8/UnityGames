using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{

    public GameObject bullet;

    public Transform bulletSpawn;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Shooting();
        }
    }

    public void Shooting()
    {
        Instantiate(bullet,bulletSpawn.position, bulletSpawn.rotation);
    }
}
