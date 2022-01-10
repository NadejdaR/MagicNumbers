using UnityEngine;

[CreateAssetMenu(fileName = nameof(MainGuessConfig), menuName = "ScriptableObject/MainGuess")]
public class MainGuessConfig : ScriptableObject
{
  public int MinNum;
  public int MaxNum;
}