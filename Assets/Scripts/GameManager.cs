using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);  // "SampleScene"
    }
    
    public void Exit()
    {
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
