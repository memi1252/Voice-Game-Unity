using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutoralEnd : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        tutoralEndUI.Instance.Show();
        Time.timeScale = 0;
        PlayerController.Instance.IsLive = false;
    }
}
