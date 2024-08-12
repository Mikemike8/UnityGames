using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public GameObject GameManager;

    public void Start()
    {

        GameManager = GameObject.Find("GameManager");

    }


    void OnCollisionEnter2D(Collision2D collison)
    {


        GameManager.GetComponent<GameManager>().Respawn();
        gameObject.SetActive(false);



    }

}
