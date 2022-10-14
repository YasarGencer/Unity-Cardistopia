using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCardGen : MonoBehaviour
{
    public int phase = 0, currentCard = 0, randNumber = 0, firstStoryCardNumber = 30, lastStoryCardNumber = 35;
    public int[] mainDeck = new int[40];
    public int[] deck_1 = new int[40];
    public int[] deck_2 = new int[40];
    public int[] deck_3 = new int[40];
    public int[] deck_4 = new int[40];
    public int[] deck_5 = new int[40];
    public int[] deck_6 = new int[40];

    void Start()
    {
        inOrderCardSet();
        randomCardSet_1();
        randomCardSet_2();
        randomCardSet_3();
        randomCardSet_4();
        randomCardSet_5();
        randomCardSet_6();
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
        if ()//ikinci donum noktasi sola kaydirilirsa
        {
            phase = 3;
            Debug.Log("Kaldin.");
        }
        if ()//ikinci donum noktasi saga kaydirilirsa
        {
            phase = 4;
            Debug.Log("Kactin.");
        }
        if ()//ilk donum noktasý saga kaydirilirsa
        {
            phase = 2;
            Debug.Log("Devleti sectin.");
        }
        if ()//ucuncu donum noktasý sola kaydirilirsa
        {
            phase = 4;
            Debug.Log("Kactin.");
        }
        if ()//ucuncu donum noktasý saga kaydirilirsa
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
        }
        if (phase == 1)
        {
            mainDeck = deck_2;
        }
        if (phase == 2)
        {
            mainDeck = deck_3;
        }
        if (phase == 3)
        {
            mainDeck = deck_4;
        }
        if (phase == 4)
        {
            mainDeck = deck_5;
        }
        if (phase == 5)
        {
            mainDeck = deck_6;
        }
    }


    public void inOrderCardSet()
    {
        for (int i = 0; i < deck_1.Length; i++)
        {
            deck_1[i] = i;
            deck_2[i] = i;
            deck_3[i] = i;
            deck_4[i] = i;
            deck_5[i] = i;
            deck_6[i] = i;
        }

    }
    public void randomCardSet_1()
    {

        for (int t = 0; t < deck_1.Length; t++)

        {
            int tmp = deck_1[t];
            int r = Random.Range(t, deck_1.Length);
            deck_1[t] = deck_1[r];
            deck_1[r] = tmp;
        }
        randNumber = Random.Range(firstStoryCardNumber, lastStoryCardNumber + 1);
        deck_1[randNumber] = 100;
    }

    public void randomCardSet_2()
    {
        for (int t = 0; t < deck_2.Length; t++)
        {
            int tmp = deck_2[t];
            int r = Random.Range(t, deck_2.Length);
            deck_2[t] = deck_2[r];
            deck_2[r] = tmp;
        }
        randNumber = Random.Range(firstStoryCardNumber, lastStoryCardNumber + 1);
        deck_2[randNumber] = 100;
    }
    public void randomCardSet_3()
    {
        for (int t = 0; t < deck_3.Length; t++)
        {
            int tmp = deck_3[t];
            int r = Random.Range(t, deck_3.Length);
            deck_3[t] = deck_3[r];
            deck_3[r] = tmp;
        }
        randNumber = Random.Range(firstStoryCardNumber, lastStoryCardNumber + 1);
        deck_3[randNumber] = 100;
    }
    public void randomCardSet_4()
    {
        for (int t = 0; t < deck_4.Length; t++)
        {
            int tmp = deck_4[t];
            int r = Random.Range(t, deck_4.Length);
            deck_4[t] = deck_4[r];
            deck_4[r] = tmp;
        }
        randNumber = Random.Range(firstStoryCardNumber, lastStoryCardNumber + 1);
        deck_4[randNumber] = 100;
    }
    public void randomCardSet_5()
    {
        for (int t = 0; t < deck_5.Length; t++)
        {
            int tmp = deck_5[t];
            int r = Random.Range(t, deck_5.Length);
            deck_5[t] = deck_5[r];
            deck_5[r] = tmp;
        }
        randNumber = Random.Range(firstStoryCardNumber, lastStoryCardNumber + 1);
        deck_5[randNumber] = 100;
    }
    public void randomCardSet_6()
    {
        for (int t = 0; t < deck_6.Length; t++)
        {
            int tmp = deck_6[t];
            int r = Random.Range(t, deck_6.Length);
            deck_6[t] = deck_6[r];
            deck_6[r] = tmp;
        }
        randNumber = Random.Range(firstStoryCardNumber, lastStoryCardNumber + 1);
        deck_6[randNumber] = 100;
    }
}
