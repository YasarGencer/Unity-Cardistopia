using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    
    [TextArea] public string text;
    [TextArea] public string description;
    [TextArea] public string Rtext;
    [TextArea] public string Ltext;
    public Sprite art;

    
    public List<StatPair> rightStats = new List<StatPair>();
    public List<StatPair> leftStats = new List<StatPair>();
}

[System.Serializable]
public struct StatPair
{
    public Stat stat;
    public int changeValue;
}
