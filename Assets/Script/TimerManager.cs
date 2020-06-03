using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//経過時間を管理するスクリプト
public class TimerManager: MonoBehaviour
{
    [SerializeField]
    private GameObject answerChecker = default;             //答えわせをするオブジェクトを参照
    [SerializeField]
    private GameObject bombImage = default;                 //制限時間を表す爆弾のオブジェクトを参照

    [SerializeField]
    private float second = 0.0f;                            //経過した秒を収納する変数
    [SerializeField]
    private float remainingSecond = 0.0f;                   //現在の残り時間を収納する変数

    private bool overLimit = false;                         //制限時間が0の時に出す指示を１回のみにする変数
    private bool timeStoper = false;                        //経過時間の取得を停止させる変数

    private const float limitTime = 30.0f;                  //制限時間を収納。変更する時はSliderのMax値も変更するように

    void Update()
    {
        //経過時間を取得
        if (!timeStoper)
            second += Time.deltaTime;

        //残り時間を計算
        remainingSecond = limitTime - second;

        //制限時間を過ぎた時の処理
        if(limitTime < second && !overLimit)
        {
            overLimit = true;                                           
            bombImage.GetComponent<BombAnimation>().BombExplosion();    //爆弾を爆発するアニメに切り替える
            answerChecker.GetComponent<MarkWriter>().NotcorrectWite();  //不正解時のUIを表示
            gameObject.GetComponent<QuestionReseter>().GameEnd();       //次の問題に移る為、機能のリセットを指示
        }
    }

    //「経過時間」と「制限時間を過ぎた時の処理を１回のみにする機能」をリセット
    public void RestTime()
    {
        second = 0.0f;
        overLimit = false;
    }

    //現在の残り時間を返す
    public float RemainingSecondReturn()
    {
        return remainingSecond;
    }

    //経過時間の取得を停止
    public void StopTime()
    {
        timeStoper = true;
    }

    //経過時間の取得を再開
    public void StartTime()
    {
        timeStoper = false;
    }
}
