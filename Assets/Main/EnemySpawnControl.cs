using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnControl : MonoBehaviour
{
	public GameObject enemyPrefab;
	
	//public GameManager GameM;
	private float interval = 1.0f;
	private float timeElapsed = 0.0f;
	private float enemyy;
	

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		//bool s = GameM.GameOverflag;
		enemyy=Random.Range(5.0f, -5.0f);
		timeElapsed += Time.deltaTime;
		if (timeElapsed >= interval)
		{
			timeElapsed = 0.0f;
			Vector3 randamPos = new Vector3(enemyy, 6.0f, 0);
			Instantiate(enemyPrefab, randamPos, Quaternion.identity);
		}
	}


}