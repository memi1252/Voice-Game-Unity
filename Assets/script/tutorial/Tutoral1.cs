using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tutoral1 : MonoBehaviour
{
    private void Start()
    {
        PlayerController.Instance.IsLive = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController.Instance.IsLive = true;
        Time.timeScale = 0;
        Tutoral1UI.Instance.Show();
    }

    private void Update()
    {
        if (PlayerController.Instance.rmsValue >= 3)
        {
            Time.timeScale = 1;
            Tutoral1UI.Instance.Hide();
        }
    }
}
