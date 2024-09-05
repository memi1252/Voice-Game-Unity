using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DieUI : MonoBehaviour
{
    public static DieUI Instance { get; private set; }
    
    [SerializeField] private Button RePlayerButton;

    private void Awake()
    {
        Instance = this;
        
        Hide();
        
        RePlayerButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("MainMenuScene");
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