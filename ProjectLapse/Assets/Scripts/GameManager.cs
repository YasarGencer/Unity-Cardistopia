using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    public Image cardOnDisplay;
    public Card card;
    public TextMeshProUGUI text, Rtext, Ltext, DescriptionText;
    public static int cardCounter = 0;
    public void SwipeEffect(bool value)
    {
        if (value)
            foreach (var statPair in card.leftStats)
                statPair.stat.ApplyStats(statPair.changeValue);

        if (!value)
            foreach (var statPair in card.rightStats)
                statPair.stat.ApplyStats(statPair.changeValue);

        cardCounter++;
        
        GetComponent<SaveLoad>().Save();
    }
    void ChangeCard()
    {
        Rtext.text = card.Rtext;
        Ltext.text = card.Ltext;
        text.text = card.text;
        cardOnDisplay.sprite = card.art;
        DescriptionText.text = card.description;
    }
}
