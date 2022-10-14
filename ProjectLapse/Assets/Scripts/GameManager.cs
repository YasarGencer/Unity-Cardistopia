using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Card card;
    private bool leftSwiped => Input.GetKeyDown(KeyCode.LeftArrow); // Bu kýsým saða sola atmayý simüle etmek için yapýldý silinecek
    private bool rightSwiped => Input.GetKeyDown(KeyCode.RightArrow);
    void Update()
    {
        if (leftSwiped)
            foreach(var statPair in card.leftStats)
                statPair.stat.ApplyStats(statPair.changeValue);
        if (rightSwiped)
            foreach (var statPair in card.rightStats)
                statPair.stat.ApplyStats(statPair.changeValue);
    }
}
