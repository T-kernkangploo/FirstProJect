using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 25f;
    private Rigidbody rb;

    [SerializeField] private PlayerData playerData;
    [SerializeField] private SoundLibrary sound;
    [SerializeField] private AudioClip clip;

    private AudioSource audioSource;

    public void AddScore()
    {
        playerData.score = playerData.score + 1;
        AudioSource.PlayClipAtPoint(sound.coin, transform.position);
    }
    public void AddKey()
    {
        playerData.key = playerData.key + 1;
        AudioSource.PlayClipAtPoint(sound.key, transform.position);

        if (playerData.key == 3)
        {
            SceneManager.LoadScene(0);
        }
    }
    public int GetScore()
    {
        return playerData.score;
    }
    public int GetKey()
    {
        return playerData.key;
    }

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(0, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0.0f;
        float y = 0.0f;
        if(Input.GetKey(KeyCode.A))
        {
            x = rotationSpeed * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            x = -rotationSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.W))
        {
            y = rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            y = -rotationSpeed * Time.deltaTime;
        }
        rb.AddTorque(x, 0 ,y);
        

       
    }
}
