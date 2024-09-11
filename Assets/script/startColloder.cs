using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startColloder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController.Instance.IsLive = true;
    }
}
