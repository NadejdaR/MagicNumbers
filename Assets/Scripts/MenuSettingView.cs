using System;
using UnityEngine;
using UnityEngine.UI;

public class MenuSettingView : MonoBehaviour
{
  public GameObject MainMenu;
  public GameObject OptionsMenu;
  public InputField FromNum;
  public InputField ToNum;
  public MainGuessConfig GuessConfig;

  private void Start()
  {
    if (FromNum.text != String.Empty && ToNum.text != String.Empty)
    {
      GuessConfig.MinNum = Convert.ToInt32(FromNum.text);
      GuessConfig.MaxNum = Convert.ToInt32(ToNum.text);
    }
    else
    {
      GuessConfig.MinNum = 0;
      GuessConfig.MaxNum = 1000;
    }

    FromNum.GetComponent<InputField>().placeholder.GetComponent<Text>().text = Convert.ToString(GuessConfig.MinNum);
    ToNum.GetComponent<InputField>().placeholder.GetComponent<Text>().text = Convert.ToString(GuessConfig.MaxNum);
  }

  public void SubmitOptions()
  {
    if (int.TryParse(FromNum.text, out int fromValue))
      GuessConfig.MinNum = fromValue;
    else
      Debug.LogError("fromValue / error");

    if (int.TryParse(ToNum.text, out int toValue))
      GuessConfig.MaxNum = toValue;
    else
      Debug.LogError("toValue / error");

    MainMenu.SetActive(true);
    OptionsMenu.SetActive(false);
  }
}