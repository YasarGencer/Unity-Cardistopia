using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatStorage : MonoBehaviour
{
    public List<Stat> statList;
    
    private Stat endingStat;
    void Start()
    {
        StatReset();
    }
    public void StatReset()
    {
        statList[0].currentValue = 500;//Money
        statList[1].currentValue = 500;//Free Time
        statList[2].currentValue = 500;//Sanity
        statList[3].currentValue = 500;
        statList[4].currentValue = 500;
        statList[5].currentValue = 0;//ending 1
        statList[6].currentValue = 0;//ending 2
        statList[7].currentValue = 0;//ending 3
        statList[8].currentValue = 500;//NGC
    }
    public bool CheckStats()
    {
        for (int a=0;a<5;a++)
        {
            if (statList[a].currentValue >= 1000 || statList[a].currentValue <= 0)
            {
                endingStat = statList[a];
                return true;
            }
        }
        if(statList[8].currentValue != 500)
        {
            if (statList[8].currentValue == 501)//continue
            {
                GetComponent<SaveLoad>().Load();
                statList[8].currentValue = 500;
            }
            else
            {
                GetComponent<GameManager>().ChangeCard();
                statList[8].currentValue = 500;
            }
        }
        return false;
    }

    public Stat GetStat()
    {
        return endingStat;
    }
}
