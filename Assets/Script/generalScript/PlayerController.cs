using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 25f;
    private Rigidbody rb;
    [SerializeField] private int score = 0;
    [SerializeField] private int key = 0;
    public void AddScore()
    {
        score = score + 1;
    }
    public void AddKey()
    {
        key = key + 1;

        if( key == 3)
        {
            SceneManager.LoadScene(0);
        }
    }
    public int GetScore()
    {
        return score;
    }
    public int GetKey()
    {
        return key;
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
