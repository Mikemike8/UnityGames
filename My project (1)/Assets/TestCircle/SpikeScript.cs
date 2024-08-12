using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeScript : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.layer == 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
