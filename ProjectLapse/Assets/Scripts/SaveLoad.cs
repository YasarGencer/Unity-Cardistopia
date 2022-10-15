using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public GameObject GameManager;
    void Start(){
        GameManager=GameObject.Find("Game_Manager");
    }

    void Save(){
        for(int a=0;a!=40;a++){
            PlayerPrefs.SetInt("Card"+a.ToString(), GameManager.GetComponent<RandomCardGen>().mainDeck[a]);
        }
        
    }

    void Load(){
        for(int a=0;a!=40;a++){
           GameManager.GetComponent<RandomCardGen>().mainDeck[a]= PlayerPrefs.GetInt("Card"+a.ToString());
        }
    }
}
