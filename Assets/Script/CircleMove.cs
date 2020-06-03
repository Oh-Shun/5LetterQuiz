using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//５つの円に初期微動をさせるスクリプト
public class CircleMove : MonoBehaviour
{
    [SerializeField]
    private Vector3 firstForce = new Vector3(1000.0f, 0.0f, 0.0f);   //加える力を設定

    private void Start()
    {
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();           //rigidbodyを取得
        rb.AddForce(firstForce);                                     //力を加える
    }
}
