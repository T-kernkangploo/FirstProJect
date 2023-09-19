using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Get 500 bath");
            Destroy(gameObject,0.5f);
            PlayerController player = GameObject.FindFirstObjectByType<PlayerController>();
            player.AddScore ();
            
        }

    }
}
