using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameController : MonoBehaviour
{
    public CharacteMove Charmove;
    public GunMove Gunmove;

    public float xpos1;

    public float xpos;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //キャラクターの座標を取得する
        Vector2 position = GameObject.Find("character").transform.position;
        //銃の座標を取得
        Vector2 position1 = GameObject.Find("Gun").transform.position;

        if (Input.GetKey (KeyCode.A))
        {
            //position.x -= 0.05f;
            //キャラクターの移動
            xpos = position.x;
            Charmove.MoveA(position.x);
            position.x = Charmove.MoveReturn();
            //銃の移動
            xpos = position1.x;
            Gunmove.gunMoveA(position1.x);
            position1.x = Gunmove.gunMoveReturn();

        }

        if (Input.GetKey(KeyCode.D))
        {
            //position.x += 0.05f;
            //キャラクターの移動
            xpos = position.x;
            Charmove.MoveD(position.x);
            position.x = Charmove.MoveReturn();
            //銃の移動
            xpos = position1.x;
            Gunmove.gunMoveD(position1.x);
            position1.x = Gunmove.gunMoveReturn();
        }
        //キャラクターの座標を移動後に設定
        GameObject.Find("character").transform.position =  position;
        //銃の座標を移動後に設定
        GameObject.Find("Gun").transform.position = position1;

    }
}
