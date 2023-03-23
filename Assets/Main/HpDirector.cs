using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpDirector : MonoBehaviour
{
    //HPのアセットを指定
    GameObject hpGauge;
    //HPのMAX値を設定
    float PlayerHp=0.999f;
    // Start is called before the first frame update
    void Start()
    {
        //hpGaugeにGameObjectをさがして入れる
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    public void DecreaseHp()
    {
        //EnemyMoveより
        //プレイヤーのいるyラインより後ろに行った際に動作
        //hpGaugeというコンポーネントのfillAmountを取得して,画像のhpGaugeの表示1/3を消す
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.333f;
        //このメソッドが呼ばれた時hpが減る
        PlayerHp -= 0.333f;
        //hpが0になった時リザルト画面に遷移
        if (PlayerHp == 0)
        {
            SceneManager.LoadScene("ResultScene");
        }
    }

    
}
