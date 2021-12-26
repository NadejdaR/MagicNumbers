using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainGuess : MonoBehaviour
{
    public Text AuthorTxt;
    
    [SerializeField]private int _min;
    [SerializeField]private int _max;
    
    private int _guess;
    private int _step=0;
    private void Start()
    {
        AuthorTxt.text = $"Загадай число от {_min} до {_max}";
        Invoke("CalculateGuess", 2f);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            _max = _guess;
            CalculateGuess();
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            _min = _guess;
            CalculateGuess();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            AuthorTxt.text = $"Победа! Затрачено ходов: {_step}";
            Invoke("Restart", 1.5f);
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

    private void CalculateGuess()
    {
        _guess = (_min + _max)/2;
        AuthorTxt.text = $"Твое число {_guess}?"; _step++;
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);  // "SampleScene"
    }
}
