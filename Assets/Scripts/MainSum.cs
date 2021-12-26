using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSum : MonoBehaviour
{
    public Text AuthorTxt;
    public Text AnswerTxt;

    private int _sum;
    private int _userInp = 0;
    private int _winSum=50;
    private int _step;
    
    private void Start()
    {
        AuthorTxt.text = $"Нажмите цифру от 1 до 9";
        Invoke("CalculateSum", 1.5f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            _userInp = 1;
            CalculateSum();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            _userInp = 2;
            CalculateSum();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            _userInp = 3;
            CalculateSum();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            _userInp = 4;
            CalculateSum();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            _userInp = 5;
            CalculateSum();
        }
        if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
        {
            _userInp = 6;
            CalculateSum();
        }
        if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
        {
            _userInp = 7;
            CalculateSum();
        } if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
        {
            _userInp = 8;
            CalculateSum();
        }
        if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
        {
            _userInp = 9;
            CalculateSum();
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);  // "SampleScene"
    }

    private void CalculateSum()
    {
        _sum += _userInp;
        _step++;
        if (_sum >= _winSum)
        {
            AnswerTxt.text = $"Игра окончена! Количество ходов: {_step}";
            Invoke("Restart", 2f);
        }else
            AnswerTxt.text = $"Сумма: {_sum}";
    }
}
