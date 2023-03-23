using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnControl : MonoBehaviour
{
	//prefabを設定できるように対応
	public GameObject enemyPrefab;
	
	//public GameManager GameM;
	//スポーンインターバルを設定
	private float interval = 1.0f;
	//経過時間を入れる箱を設定
	private float timeElapsed = 0.0f;
	//経過時間を入れる箱の2個めを設定
	private float timeElapsed1 = 0.0f;
	//y座標を入れる箱を設定
	private float enemyx;
	

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		//経過時間を入れる箱に経過時間を入れる
		timeElapsed += Time.deltaTime;

		timeElapsed1 += Time.deltaTime;
		//経過時間がインターバル時間より≧になるとき動く
		if (timeElapsed >= interval)
		{
			//経過時間の箱を初期化
			timeElapsed = 0.0f;
			//x5~-5の間でランダムで数字を出す
			enemyx = Random.Range(5.0f, -5.0f);
			//上で出したx座標＋y座標は画面上部を設定した　座標を作る
			Vector3 randamPos = new Vector3(enemyx, 6.0f, 0);
			//上記座標にてprefabを生成する
			Instantiate(enemyPrefab, randamPos, Quaternion.identity);
		}

		//10秒経過毎にスポーンするスピードを1/3早める
		if(timeElapsed1 >= 10.0f)
        {
			timeElapsed1 = 0.0f;
			interval = interval / 1.5f;
		}

	}


}