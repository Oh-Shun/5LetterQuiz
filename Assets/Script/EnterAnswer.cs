using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//InputFieldに入力された内容を参照するスクリプト
public class EnterAnswer : MonoBehaviour
{
    private InputField inputField;                  //Inputfieldの参照

    [SerializeField]
    private GameObject answerChecker = default;     //答え合わせをするオブジェクト「answerChecker」の参照

    private void Start()
    {
        // InputFieldコンポーネントを格納
        inputField = GetComponent<InputField>();
    }

    // InputFieldに入力された内容を「AnswerCheck」に渡して答え合わせをする
    public void OnEnterAnswer()
    {
        answerChecker.GetComponent<AnswerChecker>().AnswerCheck(inputField.text);
    }

}
