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
            while (s1.value > GetComponent<StatStorage>().statList[0].currentValue)
            {
                s1.value -= 1;
                yield return new WaitForSeconds(0.001f);
            }
            while (s1.value < GetComponent<StatStorage>().statList[0].currentValue)
            {
                s1.value += 1;
                yield return new WaitForSeconds(0.001f);
            }
        }
        yield return null;
    }
    IEnumerator S2()
    {
        if (s2.value != GetComponent<StatStorage>().statList[1].currentValue)
        {
            while (s2.value > GetComponent<StatStorage>().statList[1].currentValue)
            {
                s2.value -= 1;
                yield return new WaitForSeconds(0.001f);
            }
            while (s2.value < GetComponent<StatStorage>().statList[1].currentValue)
            {
                s2.value += 1;
                yield return new WaitForSeconds(0.001f);
            }
        }
        yield return null;
    }
    IEnumerator S3()
    {
        if (s3.value != GetComponent<StatStorage>().statList[2].currentValue)
        {
            while (s3.value > GetComponent<StatStorage>().statList[2].currentValue)
            {
                s3.value -= 1;
                yield return new WaitForSeconds(0.001f);
            }
            while (s3.value < GetComponent<StatStorage>().statList[2].currentValue)
            {
                s3.value += 1;
                yield return new WaitForSeconds(0.001f);
            }
        }
        yield return null;
    }
    IEnumerator S4()
    {
        if (s4.value != GetComponent<StatStorage>().statList[3].currentValue)
        {
            while (s4.value > GetComponent<StatStorage>().statList[3].currentValue)
            {
                s4.value -= 1;
                yield return new WaitForSeconds(0.001f);
            }
            while (s4.value < GetComponent<StatStorage>().statList[3].currentValue)
            {
                s4.value += 1;
                yield return new WaitForSeconds(0.001f);
            }
        }
        yield return null;
    }
}
