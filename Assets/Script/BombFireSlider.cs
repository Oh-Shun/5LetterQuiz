using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//制限時間を伝える爆弾の導火線を短くしていくスクリプト
public class BombFireSlider : MonoBehaviour
{
    [SerializeField]
    private Slider BombSlider = default;            //Sliderの参照

    //残り時間を取得し、その分だけSliderを減らして導火線を短くしていく
    void Update()
    {
        BombSlider.value = gameObject.GetComponent<TimerManager>().RemainingSecondReturn();
    }
}
