using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//問題を各々のオブジェクトにセットする指示を出すスクリプト
public class QuestionDecisiton : MonoBehaviour
{
    [SerializeField]
    private GameObject questionText = default;      //問題文を表示するテキストを参照
    [SerializeField]
    private GameObject circleTexts = default;       //問題文を円に表示するテキストを参照
    [SerializeField]
    private GameObject answerChecker = default;     //答えわせをするオブジェクトを参照

    [SerializeField]
    private int questionNumber = 1;                 //現在の問題番号を収納

    private const int minQuestionNumber = 1;        //最初の問題番号を収納
    private const int maxQuestionNumber = 5;        //最後の問題番号を収納

    private void Update()
    {
        //１問目の問題を取得
        InsertQuestion();
    }

    //問題番号に応じて、テキスト表示と答えわせの内容を各々のオブジェクトににセットする指示を出す関数
    private void InsertQuestion()
    {
        switch (questionNumber)
        {
            case 1:
                questionText.GetComponent<QuestionWriter>().InsertQuestion1();
                circleTexts.GetComponent<CircleQuestionWriter>().InsertQuestion1();
                answerChecker.GetComponent<AnswerChecker>().InsertQuestion1();
                break;
            case 2:
                questionText.GetComponent<QuestionWriter>().InsertQuestion2();
                circleTexts.GetComponent<CircleQuestionWriter>().InsertQuestion2();
                answerChecker.GetComponent<AnswerChecker>().InsertQuestion2();
                break;
            case 3:
                questionText.GetComponent<QuestionWriter>().InsertQuestion3();
                circleTexts.GetComponent<CircleQuestionWriter>().InsertQuestion3();
                answerChecker.GetComponent<AnswerChecker>().InsertQuestion3();
                break;
            case 4:
                questionText.GetComponent<QuestionWriter>().InsertQuestion4();
                circleTexts.GetComponent<CircleQuestionWriter>().InsertQuestion4();
                answerChecker.GetComponent<AnswerChecker>().InsertQuestion4();
                break;
            case 5:
                questionText.GetComponent<QuestionWriter>().InsertQuestion5();
                circleTexts.GetComponent<CircleQuestionWriter>().InsertQuestion5();
                answerChecker.GetComponent<AnswerChecker>().InsertQuestion5();
                break;
        }
    }

    //問題番号を変更する変数
    public void QuestionSwitching()
    {
        //問題番号を+1
        questionNumber ++;

        //５問目以降はないので、１問目にもどる
        if (maxQuestionNumber < questionNumber)
        {
            questionNumber = minQuestionNumber;
        }

    }
}
