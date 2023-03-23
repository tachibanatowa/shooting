using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText: MonoBehaviour
{
    int score = 0;
    Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        //アタッチしているオブジェクトからTextを探し、コンポーネントを取得する
        this.textComponent = GameObject.Find("ScoreText").GetComponent<Text>();
        //Score numを表示させる
        this.textComponent.text = "Score " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //BulletControllerより弾駕的に当たるとよばれる
    public void AddScore()
    {
        //scoreに1体倒すたびに＋10
        this.score += 10;
        //Score numを表示させる
        this.textComponent.text = "Score " + score.ToString();
        PlayerPrefs.SetInt("SCORE", this.score);
        PlayerPrefs.Save();
    }
}