using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//プレイヤーの回答を取得し、答えと照らし合わせるスクリプト
public class AnswerChecker : MonoBehaviour
{
    [SerializeField]
    private GameObject inputFeild = default;        //回答が入力されたテキストの参照
    [SerializeField]
    private GameObject sceneDirector = default;     //シーン移動機能を持つオブジェクトの参照

    private string questionAnswer;                  //クイズの答え
    private bool answerComplete = false;            //回答がされたかを確認する。trueなら「回答がされた」

    //回答がされたか、それが合っているかを確認する関数
    public void AnswerCheck(string playerAnswer)
    {
        //回答がされた時
        if (!answerComplete)
        {
            answerComplete = true;                                      //「回答がされた」事を収納
            sceneDirector.GetComponent<TimerManager>().StopTime();      //制限時間を止める

            if (playerAnswer.Contains(questionAnswer))                  //回答が正解の時、正解のUIを表示する命令を出す
                GetComponent<MarkWriter>().CorrectWrite();              
            else                                                        //回答が不正解の時、不正解のUIを表示する命令を出す
                GetComponent<MarkWriter>().NotcorrectWite();
        }

        iputFeildClern();                                               //テキストの文字を消去

        sceneDirector.GetComponent<QuestionReseter>().GameEnd();        //ゲーム終了を伝え、問題を切り替える命令を出す
    }

    //テキストの文字を消去する関数
    void iputFeildClern()
    {

        InputField form = inputFeild.GetComponent<InputField>();        //テキストを参照
        form.text = "";                                                 //テキストに空白を入れる
    }

    //問題が変わる時、「回答がされていない」状態に戻す
    public void AnswerCompleteReset()
    {
        answerComplete = false;
    }

    //１問目の回答を「questionAnswer」に渡す
    public void InsertQuestion1()
    {
        questionAnswer = "こうちけん";
    }

    //２問目の回答を「questionAnswer」に渡す
    public void InsertQuestion2()
    {
        questionAnswer = "あひーじょ";
    }

    //３問目の回答を「questionAnswer」に渡す
    public void InsertQuestion3()
    {
        questionAnswer = "もるもっと";
    }

    //４問目の回答を「questionAnswer」に渡す
    public void InsertQuestion4()
    {
        questionAnswer = "ばすけっと";
    }

    //５問目の回答を「questionAnswer」に渡す
    public void InsertQuestion5()
    {
        questionAnswer = "れくいえむ";
    }
}