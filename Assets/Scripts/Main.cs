using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Text AuthorTxt;
    public Text StartTxt;
    
    [SerializeField]private int _min;
    [SerializeField]private int _max;
    
    private int _guess;
    private int _step=0;
    private void Start()
    {
        StartTxt.text = $"Загадай число от {_min} до {_max}";
        Calculate();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            _max = _guess;
            Calculate();
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            _min = _guess;
            Calculate();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            AuthorTxt.text = $"Победа! Затрачено ходов: {_step}";
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);  // "SampleScene"
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void Calculate()
    {
        _guess = (_min + _max)/2;
        AuthorTxt.text = $"Твое число {_guess}?";
        _step++;
    }
}
