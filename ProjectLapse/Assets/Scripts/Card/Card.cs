using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    [TextArea] public string text;
    public Sprite art;

    public List<StatPair> leftStats = new List<StatPair>();
    public List<StatPair> rightStats = new List<StatPair>();
}

[System.Serializable]
public struct StatPair
{
    public Stat stat;
    public int changeValue;
}
