using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatStorage : MonoBehaviour
{
    public List<Stat> statList;
    
    [SerializeField] private Stat stat1;
    [SerializeField] private Stat stat2;
    [SerializeField] private Stat stat3;
    [SerializeField] private Stat stat4;
    [SerializeField] private Stat stat5;
    [SerializeField] private Stat stat6;
    [SerializeField] private Stat stat7;
    [SerializeField] private Stat stat8;
    private Stat endingStat;
    private void Start()
    {
        statList.Add(stat1);
        statList.Add(stat2);
        statList.Add(stat3);
        statList.Add(stat4);
        statList.Add(stat5);
        statList.Add(stat6);
        statList.Add(stat7);
        statList.Add(stat8);
    }
    public bool CheckStats()
    {
        for (int a=0;a!=5;a++)
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
