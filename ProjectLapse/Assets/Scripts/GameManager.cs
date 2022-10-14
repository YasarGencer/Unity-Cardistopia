using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Card card;
    private bool leftSwiped => Input.GetKeyDown(KeyCode.LeftArrow);
    private bool rightSwiped => Input.GetKeyDown(KeyCode.RightArrow);
    void Start()
    {
        
    }

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
