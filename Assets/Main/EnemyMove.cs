using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //これが設定されているobjectの座標を変更する
        transform.Translate(0, -0.01f, 0);

        //もし設定地点に到達した場合
        if (transform.position.y < -6.0f)
        {
            //HpDirectorに敵が倒せなかったことを伝えるため
            GameObject director = GameObject.Find("HpDirector");
            director.GetComponent<HpDirector>().DecreaseHp();
            //敵プレハブを殺す
            Destroy(gameObject);  
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
        Destroy(this.gameObject);
        GameObject.Find("ScoreController(Clone)").GetComponent<Count>().Score2();
        GameObject.Find("Canvas").GetComponent<ScoreText>().AddScore();
        
    }
}