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
        statList[0].currentValue = 500;
        statList[1].currentValue = 500;
        statList[2].currentValue = 500;
        statList[3].currentValue = 500;
        statList[4].currentValue = 500;
        statList[5].currentValue = 0;
        statList[6].currentValue = 0;
        statList[7].currentValue = 0;
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
        return false;
    }

    public Stat GetStat()
    {
        return endingStat;
    }
}
