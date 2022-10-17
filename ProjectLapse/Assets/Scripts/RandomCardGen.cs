using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCardGen : MonoBehaviour
{
    public int phase = 0, randNumber = 0, firstStoryCardNumber = 25, lastStoryCardNumber = 30;
    public static int totalCardCount = 0;
    public int[] mainDeck = new int[30];
    public int[] deck_1 = new int[70];
    public int[] deck_2 = new int[70];
    public int[] deck_3 = new int[70];
    public int[] deck_4 = new int[70];
    public int[] deck_5 = new int[70];
    public int[] deck_6 = new int[70];

    void Start()
    {
        RandomCardset(deck_1,firstStoryCardNumber, lastStoryCardNumber);
        RandomCardset(deck_2,firstStoryCardNumber, lastStoryCardNumber);
        RandomCardset(deck_3,firstStoryCardNumber, lastStoryCardNumber);
        RandomCardset(deck_4,firstStoryCardNumber, lastStoryCardNumber);
        RandomCardset(deck_5,firstStoryCardNumber, lastStoryCardNumber);
        RandomCardset(deck_6,firstStoryCardNumber, lastStoryCardNumber);
    }

    void Update()
    {
        Phases();
        PhaseProgress();
    }

    public void PhaseProgress()
    {
        //donum noktasýndaki kartlarin saga ya da sola kaydirildiginda secim yapilacak mekanik eklenmeli

        if ((phase == 1) && (CardMovement.storyCardValue == 1))//ilk donum noktasý sola kaydirilirsa
        {
            phase = 2;
            CardMovement.storyCardValue = 0;
            Debug.Log("Devleti sectin.");
        }
        else if ((phase == 1) && (CardMovement.storyCardValue == 2))//ikinci donum noktasi sola kaydirilirsa
        {
            phase = 3;
            CardMovement.storyCardValue = 0;
            Debug.Log("Direnisi sectin.");
        }
        else if ((phase == 2) && (CardMovement.storyCardValue == 1))//ikinci donum noktasi saga kaydirilirsa
        {
            phase = 4;
            CardMovement.storyCardValue = 0;
            Debug.Log("Kaldin.");
        }
        else if ((phase == 2) && (CardMovement.storyCardValue == 2))//ilk donum noktasý saga kaydirilirsa
        {
            phase = 5;
            CardMovement.storyCardValue = 0;
            Debug.Log("Kactin.");

        }
        else if ((phase == 3) && (CardMovement.storyCardValue == 1))//ucuncu donum noktasý sola kaydirilirsa
        {
            phase = 5;
            CardMovement.storyCardValue = 0;
            Debug.Log("Kactin.");
        }
        else if ((phase == 3) && (CardMovement.storyCardValue == 2))//ucuncu donum noktasý saga kaydirilirsa
        {
            phase = 6;
            CardMovement.storyCardValue = 0;
            Debug.Log("Kaldin.");
        }

    }

    public void Phases()
    {
        if (phase == 0)
        {
            DeckCopy(deck_1);
            totalCardCount = GameManager.cardCounter + totalCardCount;
            GameManager.cardCounter = 0;

        }
        else if (phase == 1)
        {
            DeckCopy(deck_2);
            totalCardCount = GameManager.cardCounter + totalCardCount;
            GameManager.cardCounter = 0;
        }
        else if (phase == 2)
        {
            DeckCopy(deck_3);
            totalCardCount = GameManager.cardCounter + totalCardCount;
            GameManager.cardCounter = 0;
        }
        else if (phase == 3)
        {
            DeckCopy(deck_4);
            totalCardCount = GameManager.cardCounter + totalCardCount;
            GameManager.cardCounter = 0;
        }
        else if (phase == 4)
        {
            DeckCopy(deck_5);
            totalCardCount = GameManager.cardCounter + totalCardCount;
            GameManager.cardCounter = 0;
        }
        else if (phase == 5)
        {
            DeckCopy(deck_6);
            totalCardCount = GameManager.cardCounter + totalCardCount;
            GameManager.cardCounter = 0;
        }
    }

    public void RandomCardset(int[] Deck, int firstCardNumb, int lastCardNumb)
    {
        for (int i = 0; i < Deck.Length; i++)
        {
            Deck[i] = i;
        }

        for (int t = 0; t < Deck.Length; t++)
        {
            int tmp = Deck[t];
            int r = Random.Range(t, Deck.Length);
            Deck[t] = Deck[r];
            Deck[r] = tmp;
        }

        randNumber = Random.Range(firstCardNumb, lastCardNumb + 1);
        Deck[randNumber] = 100; //hikaye kartinin destede sirasi
    }
    public void DeckCopy(int[] Deck)
    {
        for (int i = 0; i < 30; i++)
        {
            mainDeck[i] = Deck[i];
        }
    }
}