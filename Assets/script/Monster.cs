using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        DieUI.Instance.Show();
        Time.timeScale = 0;
        PlayerController.Instance.IsLive = false;
    }
}
