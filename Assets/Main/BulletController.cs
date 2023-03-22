using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // 弾の発射スピード
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 下から上に弾を移動
        transform.position += new Vector3(0, Speed, 0) * Time.deltaTime;

        // 画面上方に消えたら弾を消去
        if (transform.position.y >= 5.5f)
        {
            Destroy(gameObject);
           
        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
        Destroy(this.gameObject);
        GameObject.Find("Canvas").GetComponent<ScoreController>().AddScore();
    }
}
