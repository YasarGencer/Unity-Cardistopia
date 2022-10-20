using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class BlackScreenAnimator : MonoBehaviour
{
    public Image blackScreen;

    private void Start()
    {
        StartCoroutine(ChangeTransparency());
    }
    public IEnumerator ChangeTransparency()
    {
        float targetValue = blackScreen.color.a <= 0.01f ? 1 : 0.01f;
        var tweener = DOTween.ToAlpha(() => blackScreen.color, x => blackScreen.color = x, targetValue, 2).SetEase(Ease.InOutQuad);

        while (tweener.IsActive()) { yield return null; }
        
    }
}
