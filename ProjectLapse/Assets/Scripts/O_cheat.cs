using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O_cheat : MonoBehaviour
{

   
    public void Cheat()
    {
            Debug.Log("O");
            GetComponent<StatStorage>().StatReset();
            GetComponent<RandomCardGen>().RandomCardset(GetComponent<RandomCardGen>().deck_1, GetComponent<RandomCardGen>().firstStoryCardNumber, GetComponent<RandomCardGen>().lastStoryCardNumber);
            GetComponent<RandomCardGen>().DeckCopy(GetComponent<RandomCardGen>().deck_1);
            GetComponent<GameManager>().ChangeCard();
            GetComponent<Stats_UI>().UpdateStats();
    }
}
