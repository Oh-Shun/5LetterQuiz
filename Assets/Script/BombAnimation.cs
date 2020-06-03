using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//制限時間を伝える爆弾を、爆発するかしないかのアニメーションを扱うスクリプト
public class BombAnimation : MonoBehaviour
{
    //アニメータを参照
    private Animator animator;

    void Start()
    {
        //アニメータを取得
        animator = GetComponent<Animator>();
    }

    //爆発させる
    public void BombExplosion()
    {
         animator.SetBool("Alive", false);
    }

    //爆発していない状態にする
    public void BombAlive()
    {
        animator.SetBool("Alive", true);
    }
}
