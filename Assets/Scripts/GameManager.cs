using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button RestartBtn;
    public Button ExitBtn;
        
    void Start()
    {
        RestartBtn = GetComponent<Button>();
        RestartBtn.onClick.AddListener(Restart);
        
        ExitBtn = GetComponent<Button>();
        ExitBtn.onClick.AddListener(Exit);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);  // "SampleScene"
    }
    
    public void Exit()
    {
        Application.Quit();
    }
   
}
