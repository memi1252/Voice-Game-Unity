using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutoral2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Time.timeScale = 0;
        tutoral2UI.Instance.Show();
    }

    private void Update()
    {
        if (PlayerController.Instance.rmsValue >= 1)
        {
            Time.timeScale = 1;
            tutoral2UI.Instance.Hide();
        }
    }
}
