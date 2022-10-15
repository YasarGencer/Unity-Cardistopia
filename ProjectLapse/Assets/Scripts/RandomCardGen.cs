using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCardGen : MonoBehaviour
{
    public int phase = 0, randNumber = 0, firstStoryCardNumber = 30, lastStoryCardNumber = 35;
    public static int totalCardCount = 0;
    public int[] mainDeck = new int[40];
    public int[] deck_1 = new int[40];
    public int[] deck_2 = new int[40];
    public int[] deck_3 = new int[40];
    public int[] deck_4 = new int[40];
    public int[] deck_5 = new int[40];
    public int[] deck_6 = new int[40];

    void Start()
    {
        randomCardset(deck_1, 40, firstStoryCardNumber, lastStoryCardNumber);
        randomCardset(deck_2, 40, firstStoryCardNumber, lastStoryCardNumber);
        randomCardset(deck_3, 40, firstStoryCardNumber, lastStoryCardNumber);
        randomCardset(deck_4, 40, firstStoryCardNumber, lastStoryCardNumber);
        randomCardset(deck_5, 40, firstStoryCardNumber, lastStoryCardNumber);
        randomCardset(deck_6, 40, firstStoryCardNumber, lastStoryCardNumber);
    }
    
    void Update()
    {
        phases();
        phaseProgress();
    }

    public void phaseProgress()
    {
        //donum noktasýndaki kartlarin saga ya da sola kaydirildiginda secim yapilacak mekanik eklenmeli
        /*
        if ()//ilk donum noktasý sola kaydirilirsa
        {
            phase = 1;
            Debug.Log("Direnisi sectin.");
            
        }
        else if ()//ikinci donum noktasi sola kaydirilirsa
        {
            phase = 3;
            Debug.Log("Kaldin.");
        }
        else if ()//ikinci donum noktasi saga kaydirilirsa
        {
            phase = 4;
            Debug.Log("Kactin.");
        }
        else if ()//ilk donum noktasý saga kaydirilirsa
        {
            phase = 2;
            Debug.Log("Devleti sectin.");
        }
        else if ()//ucuncu donum noktasý sola kaydirilirsa
        {
            phase = 4;
            Debug.Log("Kactin.");
        }
        else if ()//ucuncu donum noktasý saga kaydirilirsa
        {
            phase = 5;
            Debug.Log("Kaldin.");
        }
        */
    }

    public void phases()
    {
        if (phase == 0)
        {
            mainDeck = deck_1;
            totalCardCount = GameManager.cardCounter + totalCardCount;
            GameManager.cardCounter = 0;

        }
        else if (phase == 1)
        {
            mainDeck = deck_2;
            totalCardCount = GameManager.cardCounter + totalCardCount;
            GameManager.cardCounter = 0;
        }
        else if (phase == 2)
        {
            mainDeck = deck_3;
            totalCardCount = GameManager.cardCounter + totalCardCount;
            GameManager.cardCounter = 0;
        }
        else if (phase == 3)
        {
            mainDeck = deck_4;
            totalCardCount = GameManager.cardCounter + totalCardCount;
            GameManager.cardCounter = 0;
        }
        else if (phase == 4)
        {
            mainDeck = deck_5;
            totalCardCount = GameManager.cardCounter + totalCardCount;
            GameManager.cardCounter = 0;
        }
        else if (phase == 5)
        {
            mainDeck = deck_6;
            totalCardCount = GameManager.cardCounter + totalCardCount;
            GameManager.cardCounter = 0;
        }
    }

    public void randomCardset(int[] Deck, int deckLength, int firstCardNumb, int lastCardNumb)
    {
        for (int i = 0; i < deckLength; i++)
        {
            Deck[i] = i;
        }

        for (int t = 0; t < deckLength; t++)
        {
            int tmp = Deck[t];
            int r = Random.Range(t, deckLength);
            Deck[t] = Deck[r];
            Deck[r] = tmp;
        }

        randNumber = Random.Range(firstCardNumb, lastCardNumb + 1);
        Deck[randNumber] = 100; //hikaye kartinin destede sirasi
    }
}
