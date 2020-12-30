using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TrueFalseManager : MonoBehaviour
{
    [SerializeField]
    private Transform trueIcon, falseIcon;

    private void Start()
    {
        ScaleKapat();
    }

    public void TrueFalseScaleAc(bool dogrumuYanlismi)
    {
        if (dogrumuYanlismi)
        {
            trueIcon.GetComponent<RectTransform>().DOScale(1, 0.4f).SetEase(Ease.OutBack);
            falseIcon.GetComponent<RectTransform>().localScale = Vector3.zero;
        }
        else
        {
            falseIcon.GetComponent<RectTransform>().DOScale(1, 0.4f).SetEase(Ease.OutBack);
            trueIcon.GetComponent<RectTransform>().localScale = Vector3.zero;
        }

        Invoke("ScaleKapat", 0.5f);
    }

    void ScaleKapat()
    {
        trueIcon.GetComponent<RectTransform>().localScale = Vector3.zero;
        falseIcon.GetComponent<RectTransform>().localScale = Vector3.zero;
    }
}
