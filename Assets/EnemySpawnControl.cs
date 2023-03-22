using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnControl : MonoBehaviour
{
	public GameObject enemyPrefab;
	private float interval = 1.0f;
	private float timeElapsed = 0.0f;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		timeElapsed += Time.deltaTime;
		if (timeElapsed >= interval)
		{
			timeElapsed = 0.0f;
			Vector3 randamPos = new Vector3(Random.Range(3.7f, -3.7f), 6.0f, 0);
			Instantiate(enemyPrefab, randamPos, Quaternion.identity);
		}
	}
}