using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//ウィンドウに問題内容を表示するスクリプト
public class QuestionWriter : MonoBehaviour
{
    //テキストを参照する
    private Text question = default; 

    void Start()
    {
        //テキストを取得
        question = GetComponent<Text>();
    }

    //１問目をテキストに表示
    public void InsertQuestion1()
    {
        question.text = "Q.桂浜や四万十川などの観光地を持つ、\n日本の四国地方に位置する都道府県の名前は？";
    }

    //２問目をテキストに表示
    public void InsertQuestion2()
    {
        question.text = "Q.スペイン発祥の、ニンニクとオリーブオイルで\n魚介類や野菜を煮込む料理の名前は？";
    }

    //３問目をテキストに表示
    public void InsertQuestion3()
    {
        question.text = "Q.テンジクネズミ科の哺乳類であり、\n実験動物として養殖されている動物の名前は？";
    }

    //４問目をテキストに表示
    public void InsertQuestion4()
    {
        question.text = "Q.サッカーは「蹴球」、テニスは「庭球」。\nでは「籠球(ろうきゅう)」は〇〇〇〇〇ボール？";
    }

    //５問目をテキストに表示
    public void InsertQuestion5()
    {
        question.text = "Q.死者の安息を神に願う為の\nカトリック教会のミサを何という？";
    }

}
