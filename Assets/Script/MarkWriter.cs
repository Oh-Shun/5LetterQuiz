using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//正解時、不正解時の２つのUIをそれぞれ表示するスクリプト
public class MarkWriter : MonoBehaviour
{
    [SerializeField]
    private GameObject correctMark = default;       //正解時のUIを参照
    [SerializeField]
    private GameObject notcorrectMark = default;    //不正解時のUIを参照

    //最初にUIを非アクティブに
    void Start()
    {
        MarkReset();
    }

    //正解時のUIを表示
    public void CorrectWrite()
    {
        correctMark.SetActive(true);
    }

    //不正解時のUIを表示
    public void NotcorrectWite()
    {
        notcorrectMark.SetActive(true);
    }

    //UIを非アクティブにリセット
    public void MarkReset()
    {
        correctMark.SetActive(false);
        notcorrectMark.SetActive(false);
    }
}
