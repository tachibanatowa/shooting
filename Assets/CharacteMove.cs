using System.Collections;
using System.Collections.Generic;

public class CharacteMove
{
    //キャラクターの移動速度
    public float speed;
    //キャラクターの座標取得用
    public float posx;

    // Start is called before the first frame update
    public void Start()
    {
        speed = 0.05f;
        posx = 0.0f;
    }

    // Update is called once per frame
    
    public void MoveA(float posx)
    {
        posx += speed;
    }

    public void MoveD(float posx)
    {
        posx -= speed;
    }

    public float MoveReturn()
    {
        return posx;
    }

    public void Update()
    {

    }
}
