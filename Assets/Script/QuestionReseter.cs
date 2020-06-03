using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//問題が終了した時、様々な機能をリセットする指示を出すスクリプト
public class QuestionReseter : MonoBehaviour
{
    [SerializeField]
    private GameObject questionDecisiton = default;     //問題表示と回答内容を設定するオブジェクトの参照
    [SerializeField]
    private GameObject answerChecker = default;         //答え合わせをするオブジェクトの参照
    [SerializeField]
    private GameObject bombImage = default;             //制限時間を表す爆弾のオブジェクトを参照

    private float waitTime = 3.0f;                      //問題終了時の余韻の時間

    //ゲーム終了時に、呼び出される関数
    public void GameEnd()
    {
        //コールチンを呼び出す
        StartCoroutine("SceneReset");
    }

    //様々な機能をリセットする指示を出すコールチン
    private IEnumerator SceneReset()
    {
        yield return new WaitForSeconds(waitTime);                                  //指定した時間分、問題終了時に余韻を作る

        GetComponent<TimerManager>().StartTime();                                   //時間制限を始める指示を出す
        bombImage.GetComponent<BombAnimation>().BombAlive();                        //爆弾が爆発していないアニメーションに変更する
        answerChecker.GetComponent<MarkWriter>().MarkReset();                       //正解不正解のUIを非表示に戻す
        questionDecisiton.GetComponent<QuestionDecisiton>().QuestionSwitching();    //クイズ内容を次に移す指示を出す
        answerChecker.GetComponent<AnswerChecker>().AnswerCompleteReset();          //テキストの中身を空っぽにする
        gameObject.GetComponent<TimerManager>().RestTime();                         //制限時間を過ぎた時の処理を１回のみにする機能をリセット
    }
}
