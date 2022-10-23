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
        
        PhaseProgress();
    }

    public void PhaseProgress()
    {
        //donum noktasýndaki kartlarin saga ya da sola kaydirildiginda secim yapilacak mekanik eklenmeli
        if (GetComponent<StatStorage>().statList[9].currentValue == 501)
        {
            phase = 2;
            Phases();
            GameManager.cardCounter = 0;
            CardMovement.storyCardValue = 0;
            Debug.Log("Devleti sectin.");
            GetComponent<StatStorage>().statList[9].currentValue = 500;
        }
        else if (GetComponent<StatStorage>().statList[9].currentValue == 499)
        {
            phase = 2;
            Phases();
            GameManager.cardCounter = 0;
            CardMovement.storyCardValue = 0;
            Debug.Log("Direnisi sectin.");
            GetComponent<StatStorage>().statList[9].currentValue = 500;
        }
        else if (GetComponent<StatStorage>().statList[10].currentValue == 501)
        {
            phase = 4;
            Phases();
            GameManager.cardCounter = 0;
            CardMovement.storyCardValue = 0;
            Debug.Log("Devlette kalmayi sectin.");
            GetComponent<StatStorage>().statList[10].currentValue = 500;
        }
        else if (GetComponent<StatStorage>().statList[10].currentValue == 499)
        {
            phase = 5;
            Phases();
            GameManager.cardCounter = 0;
            CardMovement.storyCardValue = 0;
            Debug.Log("Kacmayi sectin.");
            GetComponent<StatStorage>().statList[10].currentValue = 500;
        }
        else if (GetComponent<StatStorage>().statList[11].currentValue == 501)
        {
            phase = 6;
            Phases();
            GameManager.cardCounter = 0;
            CardMovement.storyCardValue = 0;
            Debug.Log("Direniste kalmayi sectin.");
            GetComponent<StatStorage>().statList[11].currentValue = 500;
        }
        else if (GetComponent<StatStorage>().statList[11].currentValue == 499)
        {
            phase = 5;
            Phases();
            GameManager.cardCounter = 0;
            CardMovement.storyCardValue = 0;
            Debug.Log("Kacmayi sectin.");
            GetComponent<StatStorage>().statList[11].currentValue = 500;
        }
        

    }

    public void Phases()
    {
        if (phase == 0)
        {
            DeckCopy(deck_1);
            totalCardCount = GameManager.cardCounter + totalCardCount;

        }
        else if (phase == 1)
        {
            DeckCopy(deck_2);
            totalCardCount = GameManager.cardCounter + totalCardCount;
        }
        else if (phase == 2)
        {
            DeckCopy(deck_3);
            totalCardCount = GameManager.cardCounter + totalCardCount;
        }
        else if (phase == 3)
        {
            DeckCopy(deck_4);
            totalCardCount = GameManager.cardCounter + totalCardCount;

        }
        else if (phase == 4)
        {
            DeckCopy(deck_5);
            totalCardCount = GameManager.cardCounter + totalCardCount;
        }
        else if (phase == 5)
        {
            DeckCopy(deck_6);
            totalCardCount = GameManager.cardCounter + totalCardCount;

        }
    }

    public void RandomCardset(int[] Deck, int firstCardNumb, int lastCardNumb)
    {
        for (int i = 0; i < Deck.Length; i++)
        {
            Deck[i] = i;
        }

        for (int t = 7; t < Deck.Length; t++)
        {
            int tmp = Deck[t];
            int r = Random.Range(t, Deck.Length);
            Deck[t] = Deck[r];
            Deck[r] = tmp;
        }
        Deck[0] = 0;
        Deck[1] = 1;
        Deck[2] = 2;
        Deck[3] = 3;
        Deck[4] = 4;
        Deck[5] = 5;
        Deck[6] = 6;
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