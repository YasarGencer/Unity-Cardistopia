using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatStorage : MonoBehaviour
{
    public List<Stat> statList;
    
    private Stat endingStat;

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
