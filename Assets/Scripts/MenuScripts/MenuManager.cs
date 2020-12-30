using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private Transform kafa, startBtn;

    void Start()
    {
        kafa.transform.GetComponent<RectTransform>().DOLocalMoveX(0, 1f).SetEase(Ease.OutBack);
        startBtn.transform.GetComponent<RectTransform>().DOLocalMoveY(-270, 1f).SetEase(Ease.OutBack);
    }

    public void OyunuBaslat()
    {
        SceneManager.LoadScene("GameLevel");
    }

}
