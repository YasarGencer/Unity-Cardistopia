using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Card card;
    public static int cardCounter = 0;
    public void SwipeEffectt(bool value)
    {
        if (value)
            foreach (var statPair in card.leftStats)
                statPair.stat.ApplyStats(statPair.changeValue);
        if (!value)
            foreach (var statPair in card.rightStats)
                statPair.stat.ApplyStats(statPair.changeValue);

        cardCounter++;
    }
}
