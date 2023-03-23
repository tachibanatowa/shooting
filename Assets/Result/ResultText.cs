using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultText : MonoBehaviour
{
    Text textComponent;
    // Start is called before the first frame update
    void Start()
    {
        int resultScore = PlayerPrefs.GetInt("SCORE");
        //アタッチしているオブジェクトからTextを探し、コンポーネントを取得する
        this.textComponent = GameObject.Find("Text").GetComponent<Text>();
        //Score numを表示させる
        this.textComponent.text = "Score " + resultScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
