using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameController : MonoBehaviour
{
    public CharacteMove Charmove;

    // 弾のプレハブ
    public GameObject bulletPrefab;


    //----キャラクター-----
    //キャラクターの座標を入れる用
    public float xpos;

    //一定間隔での連射用
    private float timeReset;
    private float time;


    // Start is called before the first frame update
    void Start()
    {
        //初期値設定
        time = 0;
        timeReset = 0.1f;
        
    }

    // Update is called once per frame
    void Update()
    { 

        //キャラクターの座標を取得する
        Vector2 position = GameObject.Find("character").transform.position;



        if (Input.GetKey (KeyCode.A))
        {
            //position.x -= 0.05f;
            //キャラクターの移動
            xpos = position.x;
            Charmove.MoveA(position.x);
            position.x = Charmove.MoveReturn();
           

        }

        if (Input.GetKey(KeyCode.D))
        {
            //position.x += 0.05f;
            //キャラクターの移動
            xpos = position.x;
            Charmove.MoveD(position.x);
            position.x = Charmove.MoveReturn();
            
        }
        //キャラクターの座標を移動後に設定
        GameObject.Find("character").transform.position =  position;


        //---銃の弾--
        //一定時間で射出準備可能に
        time += Time.deltaTime;
        if (time > timeReset)
        {
            if (Input.GetMouseButton(0))
            {
                Instantiate(bulletPrefab, position, Quaternion.identity);
                time = 0;
            }
        }

    }

    
}
