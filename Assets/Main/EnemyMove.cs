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
        transform.Translate(0, -0.01f, 0);

        if (transform.position.y < -6.0f)
        {
            //HpDirectorに敵が倒せなかったことを伝えるため
            GameObject director = GameObject.Find("HpDirector");
            director.GetComponent<HpDirector>().DecreaseHp();
            //敵プレハブを削
            Destroy(gameObject);  
        }
    }
}