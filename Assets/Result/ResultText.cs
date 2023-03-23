using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultText : MonoBehaviour
{
    //private Count Count;
    Text textComponent;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        //アタッチしているオブジェクトからTextを探し、コンポーネントを取得する
        var Count = FindObjectOfType<Count>();
        //int count = 0;
        count = Count.scoreresult();

        this.GetComponent<Text>().text = "クリック回数は" + count.ToString() + "でした";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
