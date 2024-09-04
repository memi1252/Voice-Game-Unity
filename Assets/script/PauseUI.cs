using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseUI : MonoBehaviour
{
    [SerializeField] private Button settingButton;
    
    private void Awake()
    {
        Hide();
        
        settingButton.onClick.AddListener(() =>
        {
            if (gameObject.activeSelf == true)
            {
                Hide();
                Time.timeScale = 1;
                PlayerController.Instance.IsLive = true;
            }
            else
            {
                Show();
                Time.timeScale = 0;
                PlayerController.Instance.IsLive = false;
            }
        });
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
