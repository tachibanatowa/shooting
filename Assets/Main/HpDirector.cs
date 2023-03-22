using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpDirector : MonoBehaviour
{
    GameObject hpGauge;
    float PlayerHp=0.999f;
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.333f;
        PlayerHp -= 0.333f;
        if (PlayerHp == 0)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }

    
}
