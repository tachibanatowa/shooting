using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{
    // カウント用変数
    public int score;
    public int score1;
    //tachiに渡す用
    public int resultscore;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        resultscore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Score2()
    {
        //scoreに1体倒すたびに＋1
        score++;
        resultscore = score;
    }
    public int scoreNam()
    {
        ++score;
        return score;
    }

    public int scoreresult()
    {
        return resultscore;
    }

}
