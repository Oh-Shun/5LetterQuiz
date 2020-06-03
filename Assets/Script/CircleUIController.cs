using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//円にテキスト表示させるスクリプト
public class CircleUIController : MonoBehaviour
{
    [SerializeField]
    private Transform targetObject = default;                   //円を参照

    private RectTransform myRectTfm;                            //スクリーン座標を参照
    private Vector3 offset = new Vector3(0.05f, -0.25f, 0);     //テキストの位置調整用

    void Start()
    {
        //スクリーン座標を取得
        myRectTfm = GetComponent<RectTransform>();
    }

    void Update()
    {
        //円のワールド座標を取得し、テキストを追従させる
        myRectTfm.position = RectTransformUtility.WorldToScreenPoint(Camera.main, targetObject.position + offset);
    }
}
