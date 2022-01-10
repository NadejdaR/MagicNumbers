using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainGuess : MonoBehaviour
{
  public Text AuthorTxt;
  public MainGuessConfig GuessConfig;
  public WinSO WinObj;

  private int _min;
  private int _max;
  private int _minGuess;
  private int _maxGuess;
  private int _guess;
  private int _step = 0;
  private bool _isGameOver = true;

  public void MinBtn()
  {
    _maxGuess = _guess;
    CalculateGuess();
  }

  public void EqualsBtn()
  {
    Win();
  }

  public void MaxBtn()
  {
    _minGuess = _guess;
    CalculateGuess();
  }

  private void Awake()
  {
    _min = GuessConfig.MinNum;
    _max = GuessConfig.MaxNum;
    _minGuess = _min;
    _maxGuess = _max;
  }

  private void Start()
  {
    AuthorTxt.text = $"Загадай число от {_minGuess} до {_maxGuess}";
    Invoke(nameof(CalculateGuess), 2f);
  }

  private void Update()
  {
    if (!_isGameOver)
    {
      if (Input.GetKeyDown(KeyCode.DownArrow))
      {
        _maxGuess = _guess;
        CalculateGuess();
      }

      if (Input.GetKeyDown(KeyCode.UpArrow))
      {
        _minGuess = _guess;
        CalculateGuess();
      }

      if (Input.GetKeyDown(KeyCode.Space))
      {
        Win();
      }
    }

    if (Input.GetKeyDown(KeyCode.R))
    {
      Restart();
    }

    if (Input.GetKeyDown(KeyCode.Escape))
    {
#if UNITY_EDITOR
      UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }
  }

  private void CalculateGuess()
  {
    int stepguess = 0;
    _guess = (_minGuess + _maxGuess) / 2;
    if (stepguess == _guess)
    {
      _isGameOver = true;
      AuthorTxt.text = $"Не ври!";
      Invoke(nameof(Win), 1.0f);
    }
    else
    {
      AuthorTxt.text = $"Твое число {_guess}?";
      _step++;
      _isGameOver = false;
      stepguess = _guess;
    }
  }

  private void Restart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }

  private void Win()
  {
    _isGameOver = true;
    WinObj.GuessNum = _guess;
    WinObj.StepGuess = _step;
    SceneManager.LoadScene("Win");
  }
}