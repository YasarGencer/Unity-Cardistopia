using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{

    void Start(){
        
    }

    public void Save(){
        for(int a=0;a!=30;a++){
            PlayerPrefs.SetInt("Card"+a.ToString(), GetComponent<RandomCardGen>().mainDeck[a]);
            
        }
        PlayerPrefs.SetInt("CardCount", GameManager.cardCounter);
        PlayerPrefs.SetInt("TotalCardCount", RandomCardGen.totalCardCount);
        PlayerPrefs.SetInt("Phase", GetComponent<RandomCardGen>().phase); 
    }

    public void Load(){
        for(int a=0;a!=40;a++){
           GetComponent<RandomCardGen>().mainDeck[a]= PlayerPrefs.GetInt("Card"+a.ToString());

        }
        GameManager.cardCounter=PlayerPrefs.GetInt("CardCount");
        RandomCardGen.totalCardCount=PlayerPrefs.GetInt("TotalCardCount");
        GetComponent<RandomCardGen>().phase=PlayerPrefs.GetInt("Phase"); 
    }
}
