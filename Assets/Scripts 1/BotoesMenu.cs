using UnityEngine;
using UnityEngine.SceneManagement;

public class BotoesMenu : MonoBehaviour
{
    public void IniciarJogo()
    {
       SceneManager.LoadScene("GameScene");
    }

      public void VoltarAoMenu()
      {
        SceneManager.LoadScene("Menu");
      }

      public void SairDoJogo()
      {
        Application.Quit();
      }



  }
