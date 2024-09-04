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
        Time.timeScale = 0;
        TutoralEndUI.Instance.Show();
        PlayerController.Instance.IsLive = false;
    }
}
