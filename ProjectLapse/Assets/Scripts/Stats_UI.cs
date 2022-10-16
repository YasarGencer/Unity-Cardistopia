using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Stats_UI : MonoBehaviour
{
    public Slider s1, s2, s3, s4;

    public void UpdateStats()
    {
        StartCoroutine(S1());
        StartCoroutine(S2());
        StartCoroutine(S3());
        StartCoroutine(S4());
    }
    IEnumerator S1()
    {
        if(s1.value != GetComponent<StatStorage>().statList[0].currentValue)
        {

        }
        yield return null;
    }
    IEnumerator S2()
    {
        yield return null;
    }
    IEnumerator S3()
    {
        yield return null;
    }
    IEnumerator S4()
    {
        yield return null;
    }
}
