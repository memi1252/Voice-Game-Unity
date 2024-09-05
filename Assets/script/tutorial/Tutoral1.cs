using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tutoral1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Time.timeScale = 0;
        tutoral1UI.Instance.Show();
        PlayerController.Instance.IsLive = true;
    }

    private void Update()
    {
        if (PlayerController.Instance.rmsValue >= 1)
        {
            Time.timeScale = 1;
            tutoral1UI.Instance.Hide();
        }
    }
}
