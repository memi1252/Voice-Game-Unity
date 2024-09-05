
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tutoralEndUI : MonoBehaviour
{
    public static tutoralEndUI Instance { get; private set; }
    
    
    [SerializeField] private Button mainButton;
    [SerializeField] private Button playingButton;


    
    private void Awake()
    {
        Instance = this;
        mainButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("MainMenuScene");
        });
        playingButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Main");
        });
        
        Hide();
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
