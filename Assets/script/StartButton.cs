using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
   [SerializeField] private Button temporaryPlayerButton;

   private void Awake()
   {
      Time.timeScale = 1;
      
      temporaryPlayerButton.onClick.AddListener(() =>
      {
         SceneManager.LoadScene("select");
      });
   }
}
