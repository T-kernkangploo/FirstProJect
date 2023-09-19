using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Get Key");
            Destroy(gameObject, 0.5f);
            PlayerController player = GameObject.FindFirstObjectByType<PlayerController>();
            player.AddKey();

        }

        else if (other.CompareTag("Player"))
        {
            Debug.Log("You are noob");
            PlayerController player = GameObject.FindFirstObjectByType<PlayerController>();
            player.AddKey();
            
        }
    }
}
