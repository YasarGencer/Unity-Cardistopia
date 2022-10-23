using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public bool saved = true;//debug false olmali
    /*void Start(){
        for (int a = 0; a != 30; a++)//debug komple silinmeli
        {
            PlayerPrefs.SetInt("Card" + a.ToString(), 10);
        }
        PlayerPrefs.SetInt("CardCount", 1);
        PlayerPrefs.SetInt("TotalCardCount", 1);
        PlayerPrefs.SetInt("Phase", 1);
    }
    */
    public void Save(){
        for(int a=0;a!=30;a++)
        {
            PlayerPrefs.SetInt("Card"+a.ToString(), GetComponent<RandomCardGen>().mainDeck[a]);
        }
        PlayerPrefs.SetInt("CardCount", GameManager.cardCounter);
        PlayerPrefs.SetInt("TotalCardCount", RandomCardGen.totalCardCount);
        PlayerPrefs.SetInt("Phase", GetComponent<RandomCardGen>().phase);
        saved = true;
    }

    public void Load(){
        for (int a=0;a!=30;a++)
        {
            GetComponent<RandomCardGen>().mainDeck[a]= PlayerPrefs.GetInt("Card"+a.ToString());
        }
        GameManager.cardCounter=PlayerPrefs.GetInt("CardCount");
        RandomCardGen.totalCardCount=PlayerPrefs.GetInt("TotalCardCount");
        GetComponent<RandomCardGen>().phase=PlayerPrefs.GetInt("Phase");
        saved = false;
    }
}
