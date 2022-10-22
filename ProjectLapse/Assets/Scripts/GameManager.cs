using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    public Image cardOnDisplay;
    public Card currentCard;
    public Card[] deck,specialDeck;
    public TextMeshProUGUI text, Rtext, Ltext, DescriptionText;
    public static int cardCounter = 0;
    public int cardCounterDisplay = 0, specialCardID;
    public void Update()
    {
        cardCounterDisplay = cardCounter;
    }
    private StatStorage statStorage;
    private void Start()
    {
        statStorage = GetComponent<StatStorage>();
        ChangeCard();
    }
    public void SwipeEffect(bool value)
    {
        if (value)
            foreach (var statPair in currentCard.leftStats)
                statPair.stat.ApplyStats(statPair.changeValue);

        if (!value)
            foreach (var statPair in currentCard.rightStats)
                statPair.stat.ApplyStats(statPair.changeValue);

        cardCounter++;
        if (statStorage.CheckStats())
        {
            Debug.Log(statStorage.GetStat().name); // statStorage.GetStat().GetEndingCards ile oyun sonu kartlarý çekilip ekrana getirilecek.
        }
        GetComponent<Stats_UI>().UpdateStats();
        GetComponent<SaveLoad>().Save();
        ChangeCard();
    }
    public void ChangeCard()
    {
        CurrentCard();
        Rtext.text = currentCard.Rtext;
        Ltext.text = currentCard.Ltext;
        text.text = currentCard.text;
        cardOnDisplay.sprite = currentCard.art;
        DescriptionText.text = currentCard.description;
    }
    void CurrentCard()
    {
        if (specialCardID==0)
        {
            currentCard = deck[GetComponent<RandomCardGen>().mainDeck[cardCounter]];
        }
        else
        {
            currentCard = specialDeck[specialCardID];
            specialCardID = 0;
        }
    }
}
