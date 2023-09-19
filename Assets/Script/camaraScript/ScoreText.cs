using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private PlayerController player;
    void Start()
    {
        //text = GetComponent<TMP_Text>();
        //player = GameObject.FindFirstObjectByType<PlayerController>();


    }

    // Update is called once per frame
    void Update()
    {
        text.text = player.GetScore().ToString();
    }
}
