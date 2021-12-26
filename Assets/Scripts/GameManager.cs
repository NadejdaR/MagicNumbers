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
    public static int minNum =0;
    public static int maxNum=1000;

    private void Start()
    {
        FromNum.GetComponent<InputField>().placeholder.GetComponent<Text>().text = Convert.ToString(minNum);
        ToNum.GetComponent<InputField>().placeholder.GetComponent<Text>().text = Convert.ToString(maxNum);
    }

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

    public void SubmitOptions()
    {
        minNum = Convert.ToInt32(FromNum.text);
        maxNum = Convert.ToInt32(ToNum.text);
        MainMenu.SetActive (true);
        OptionsMenu.SetActive (false);
    }
}
