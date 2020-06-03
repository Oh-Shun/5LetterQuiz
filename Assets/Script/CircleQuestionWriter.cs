using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//５つの円に問題を表示させるスクリプト
public class CircleQuestionWriter : MonoBehaviour
{
    //問題の文字を取得するTextの配列を作成
    private Text[] circleText = new Text[5];

    private void Start()
    {
        //円に表示するテキストが５つ収納されている「CircleTexts」の子オブジェクトを参照する
        for (int Child_i = 0; Child_i < transform.childCount; Child_i++)
        {
            circleText[Child_i] = transform.GetChild(Child_i).gameObject.GetComponent<Text>();
        }
    }

    //１問目の問題を取得したテキストに渡す
    public void InsertQuestion1()
    {
        circleText[0].text = "こ";
        circleText[1].text = "う";
        circleText[2].text = "ち";
        circleText[3].text = "け";
        circleText[4].text = "ん";
    }

    //２問目の問題を取得したテキストに渡す
    public void InsertQuestion2()
    {
        circleText[0].text = "あ";
        circleText[1].text = "ひ";
        circleText[2].text = "ー";
        circleText[3].text = "じ";
        circleText[4].text = "ょ";
    }

    //３問目の問題を取得したテキストに渡す
    public void InsertQuestion3()
    {
        circleText[0].text = "も";
        circleText[1].text = "る";
        circleText[2].text = "も";
        circleText[3].text = "っ";
        circleText[4].text = "と";
    }

    //４問目の問題を取得したテキストに渡す
    public void InsertQuestion4()
    {
        circleText[0].text = "ば";
        circleText[1].text = "す";
        circleText[2].text = "け";
        circleText[3].text = "っ";
        circleText[4].text = "と";
    }

    //５問目の問題を取得したテキストに渡す
    public void InsertQuestion5()
    {
        circleText[0].text = "れ";
        circleText[1].text = "く";
        circleText[2].text = "い";
        circleText[3].text = "え";
        circleText[4].text = "む";
    }
}
