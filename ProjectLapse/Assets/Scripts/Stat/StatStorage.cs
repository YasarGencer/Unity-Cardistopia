using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatStorage : MonoBehaviour
{
    public List<Stat> statList;
    
    [SerializeField] private Stat stat1;
    [SerializeField] private Stat stat2;

    private Stat endingStat;
    private void Start()
    {
        statList.Add(stat1);
        statList.Add(stat2);
    }
    public bool CheckStats()
    {
        foreach (Stat stat in statList)
        {
            if (stat.currentValue >= 1000 || stat.currentValue <= 0)
                endingStat = stat;
                return true;
        }
        return false;
    }

    public Stat GetStat()
    {
        return endingStat;
    }
}
