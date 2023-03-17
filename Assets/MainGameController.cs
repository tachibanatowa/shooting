using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameController : MonoBehaviour
{
    public CharacteMove Charmove;

    public float xpos;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //キャラクターの座標の座標を取得する
        Vector2 position = GameObject.Find("character").transform.position;

        if (Input.GetKey (KeyCode.A))
        {
            //position.x -= 0.05f;
            xpos = position.x;
            Charmove.MoveA(position.x);
            position.x = Charmove.MoveReturn();

        }

        if (Input.GetKey(KeyCode.D))
        {
            //position.x += 0.05f;
            xpos = position.x;
            Charmove.MoveD(position.x);
            position.x = Charmove.MoveReturn();
        }

        GameObject.Find("character").transform.position =  position;

    }
}
