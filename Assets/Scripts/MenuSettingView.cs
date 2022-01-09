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

  private int _min;
  private int _max;

  private void Awake()
  {
    _min = GuessConfig.MinNum;
    _max = GuessConfig.MaxNum;
  }

  private void Start()
  {
    if (FromNum.text != String.Empty && ToNum.text != String.Empty)
    {
      _min = Convert.ToInt32(FromNum.text);
      _max = Convert.ToInt32(ToNum.text);
    }
    else
    {
      _min = 0;
      _max = 1000;
    }

    FromNum.GetComponent<InputField>().placeholder.GetComponent<Text>().text = Convert.ToString(_min);
    ToNum.GetComponent<InputField>().placeholder.GetComponent<Text>().text = Convert.ToString(_max);
  }

  public void SubmitOptions()
  {
    if (int.TryParse(FromNum.text, out int fromValue))
      _min = fromValue;
    else
      Debug.LogError("fromValue / error");

    if (int.TryParse(ToNum.text, out int toValue))
      _max = toValue;
    else
      Debug.LogError("toValue / error");

    MainMenu.SetActive(true);
    OptionsMenu.SetActive(false);
  }
}