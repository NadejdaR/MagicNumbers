using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainGuess : MonoBehaviour
{
  public Text AuthorTxt;
  public MainGuessConfig GuessConfig;

  private int _guess;
  private int _step = 0;
  private int _min;
  private int _max;
  private bool _isGameOver = true;

  private void Awake()
  {
    _min = GuessConfig.MinNum;
    _max = GuessConfig.MaxNum;
  }

  private void Start()
  {
    AuthorTxt.text = $"Загадай число от {_min} до {_max}";
    Invoke(nameof(CalculateGuess), 2f);
  }

  private void Update()
  {
    if (_isGameOver == false)
    {
      if (Input.GetKeyDown(KeyCode.DownArrow))
      {
        _max = _guess;
        CalculateGuess();
      }

      if (Input.GetKeyDown(KeyCode.UpArrow))
      {
        _min = _guess;
        CalculateGuess();
      }

      if (Input.GetKeyDown(KeyCode.Space))
      {
        _isGameOver = true;
        AuthorTxt.text = $"Победа! Затрачено ходов: {_step}";
        Invoke(nameof(Restart), 1.5f);
      }
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
    int guess = _guess;
    _guess = (_min + _max) / 2;
    if (guess == _guess)
    {
      _isGameOver = true;
      AuthorTxt.text = $"Не ври! Твое число {_guess}.\n Затрачено ходов: {_step}";
      Invoke(nameof(Restart), 1.5f);
    }
    else
    {
      AuthorTxt.text = $"Твое число {_guess}?";
      _step++;
      _isGameOver = false;
    }
  }

  private void Restart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
}