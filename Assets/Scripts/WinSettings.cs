using UnityEngine;
using UnityEngine.UI;

public class WinSettings : MonoBehaviour
{
  public Text StepTxt;
  public Text GuessTxt;
  public WinSO WinObj;

  private void Awake()
  {
    StepTxt.text = $"Steps: {WinObj.StepGuess.ToString()}";
    GuessTxt.text = $"Your number: {WinObj.GuessNum.ToString()}";
  }
}
