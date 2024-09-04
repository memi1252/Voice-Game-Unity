using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class jumpSound : MonoBehaviour
{
    private AudioSource audioSource;
    private float jumpTime;
    
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        jumpTime -= Time.deltaTime;
        if (PlayerController.Instance.transform.position.y >=  -4.1f)
        {
            if (jumpTime <= 0)
            {
                audioSource.Play();
                jumpTime = 2f;
            }
        }
    }
}
