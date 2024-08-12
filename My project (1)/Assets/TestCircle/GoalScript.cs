using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Trigger Entered with: " + collider.gameObject.tag);

        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player detected. Loading next scene.");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
