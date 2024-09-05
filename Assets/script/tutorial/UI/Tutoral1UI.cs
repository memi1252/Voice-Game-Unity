using System;
using UnityEngine;

public class tutoral1UI : MonoBehaviour
{
    public static tutoral1UI Instance { get; private set; }
    
    private void Awake()
    {
        Instance = this;
        
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
