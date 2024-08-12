using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{



    public GameObject player;

  



   public void Respawn()
    {
        StartCoroutine(Spawning());

    }


    IEnumerator Spawning()
    {
        yield return new WaitForSeconds(2.5f);

        player.SetActive(true);
    
    }
}
