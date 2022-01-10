using UnityEngine;

[CreateAssetMenu(fileName = nameof(WinSO), menuName = "ScriptableObject/WinGuess")]
public class WinSO : ScriptableObject
{
  public int StepGuess;
  public int GuessNum;
}