using UnityEngine;

[CreateAssetMenu(fileName = nameof(MainGuessConfig), menuName = "Config/MainGuess")]
public class MainGuessConfig : ScriptableObject
{
  public int MinNum;
  public int MaxNum;
}