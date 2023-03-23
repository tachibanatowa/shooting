using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText: MonoBehaviour
{
    private Count count;
    private Count count1;
    public Count countprefab;

    int score ;
    Text textComponent;

    //private Count count1;

    // Start is called before the first frame update
    public void Start()
    {
        count = new Count();

        
        //アタッチしているオブジェクトからTextを探し、コンポーネントを取得する
        this.textComponent = GameObject.Find("ScoreText").GetComponent<Text>();
        //Score numを表示させる
        this.textComponent.text = "Score " + score.ToString();


        var hozi = FindObjectOfType<Count>();

        //シーン上にクローンがあれば、instantiateとdontdestroyをしない
        if (null == hozi)
        {
            count1 = Instantiate<Count>(countprefab);
            DontDestroyOnLoad(count1.gameObject);
        }
        else
        {
            Destroy(hozi.gameObject);
            count1 = Instantiate<Count>(countprefab);
            DontDestroyOnLoad(count1.gameObject);

        }



    }

    // Update is called once per frame
    void Update()
    {

    }

    //BulletControllerより弾駕的に当たるとよばれる
    public void AddScore()
    {
        score = count.scoreNam();
        //Score numを表示させる
        this.textComponent.text = "Score " + score.ToString();

    }
}