using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameController : MonoBehaviour
{
    public CharacteMove Charmove;

    public float xpos=0;
    
    // Start is called before the first frame update
    void Start()
    {
        Charmove = new CharacteMove();
    }

    // Update is called once per frame
    void Update()
    {
        //キャラクターの座標の座標を取得する
        Vector2 position = transform.position;
        
        if (Input.GetKey (KeyCode.A))
        {
            xpos = position.x;
            Charmove.MoveA(xpos);
            position.x = Charmove.MoveReturn();

        }

        if (Input.GetKey(KeyCode.D))
        {
            xpos = position.x;
            Charmove.MoveD(xpos);
            position.x = Charmove.MoveReturn();
        }
        transform.position = position;

    }
}
