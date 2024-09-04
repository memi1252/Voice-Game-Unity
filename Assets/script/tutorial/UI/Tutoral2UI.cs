using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutoral2UI : MonoBehaviour
{
    public static Tutoral2UI Instance { get; private set; }
    
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
