using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutoral2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Time.timeScale = 0;
        Tutoral2UI.Instance.Show();
    }

    private void Update()
    {
        if (PlayerController.Instance.rmsValue >= 3)
        {
            //ime.timeScale = 1;
            Tutoral2UI.Instance.Hide();
        }
    }
}
