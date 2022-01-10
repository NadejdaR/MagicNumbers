using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHelper : MonoBehaviour
{
  public void Restart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }

  public void Exit()
  {
    EditorApplication.isPlaying = false;
    Application.Quit();
  }

  public void PlayGuessGame()
  {
    SceneManager.LoadScene("GuessNumbers");
  }

  public void PlaySumGame()
  {
    SceneManager.LoadScene("SumNumbers");
  }

  public void Menu()
  {
    SceneManager.LoadScene("Menu");
  }
}