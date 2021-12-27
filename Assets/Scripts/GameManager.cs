using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public InputField FromNum;
    public InputField ToNum;
    
    public static int MinNum = 0;
    public static int MaxNum = 1000;

    private void Start()
    {
        FromNum.GetComponent<InputField>().placeholder.GetComponent<Text>().text = Convert.ToString(MinNum);
        ToNum.GetComponent<InputField>().placeholder.GetComponent<Text>().text = Convert.ToString(MaxNum);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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

    public void SubmitOptions()
    {
        MinNum = Convert.ToInt32(FromNum.text);
        MaxNum = Convert.ToInt32(ToNum.text);
        MainMenu.SetActive (true);
        OptionsMenu.SetActive (false);
    }
}
