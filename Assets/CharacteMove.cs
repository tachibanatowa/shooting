using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacteMove : MonoBehaviour
{

    //キャラクターの移動
    public float idouzahyou;
    //キャラクターの座標取得用
    public float position;

    // Start is called before the first frame update
    public void Start()
    {
        idouzahyou = 0.05f;
    }

    // Update is called once per frame
    
    public void MoveA(float posx)
    {
        if (posx >= -5 )
        {
            position = posx - idouzahyou;
        }
    }

    public void MoveD(float posx)
    {
        if (posx <= 5)
        {
            position = posx + idouzahyou;
        }
    }

    public float MoveReturn()
    {
        return position;
    }

    public void Update()
    {

    }
}
