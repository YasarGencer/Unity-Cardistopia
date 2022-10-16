using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Stat", menuName = "Stat")]
public class Stat : ScriptableObject
{

    [Range(0,1000)]  public int currentValue;
    [SerializeField] private List<Card> maxStatCards;
    [SerializeField] private List<Card> minStatCards;
    public void ApplyStats(int value)
    {
        currentValue += value;
    }

    public List<Card> GetEndingCards(bool value)
    {
        if(value)
            return maxStatCards;
        return minStatCards;
    }
}
