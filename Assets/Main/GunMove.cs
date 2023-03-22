using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMove : MonoBehaviour
{
     //銃の移動
    public float gunidouzahyou;
    //銃の座標取得用
    public float gunposition;

    // Start is called before the first frame update
    public void Start()
    {
        gunidouzahyou = 0.05f;
    }

    // Update is called once per frame
    
    public void gunMoveA(float posx1)
    {
        if (posx1 >= -5)
        {
            gunposition = posx1 - gunidouzahyou;
        }
    }

    public void gunMoveD(float posx1)
    {
        if (posx1 <= 5)
        {
            gunposition = posx1 + gunidouzahyou;
        }
    }

    public float gunMoveReturn()
    {
        return gunposition;
    }

    public void Update()
    {

    }
}
