using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class select : MonoBehaviour
{
    [SerializeField] private Button tutorialButton;
    [SerializeField] private Button playingButton;


    private void Awake()
    {
        tutorialButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Tutorial");
        });
        playingButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Main");
        });
    }
}
