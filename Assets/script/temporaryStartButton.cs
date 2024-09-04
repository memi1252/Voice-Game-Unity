using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class temporaryStartButton : MonoBehaviour
{
   [SerializeField] private Button temporaryPlayerButton;

   private void Awake()
   {
      temporaryPlayerButton.onClick.AddListener(() =>
      {
         SceneManager.LoadScene("Main");
      });
   }
}
