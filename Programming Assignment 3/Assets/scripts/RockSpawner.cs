using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour {

	//needed for spawning
	[SerializeField]
	GameObject prefabRock;

	// saved for efficiency
	[SerializeField]
	Sprite greenrock;
	[SerializeField]
	Sprite magentarock;
	[SerializeField]
	Sprite whiterock;

	// spawn control
	const float MinSpawnDelay = 1;
	const float MaxSpawnDelay = 2;
	Timer		spawnTimer;

	// spawn location support
	const int SpawnBorderSize = 100;

	// Use this for initialization
	void Start() {

		//create and start timer
		spawnTimer = gameObject.AddComponent<Timer>();
		spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
		spawnTimer.Run();
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] count = GameObject.FindGameObjectsWithTag("Rock");
		if (spawnTimer.Finished && count.Length < 3)
		{
			SpawnRock();

			//change spawn timer duration and restart
			spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
			spawnTimer.Run();
		}
	}

	void SpawnRock()
    {
		// set location at center and create new rock
		GameObject rock = Instantiate(prefabRock) as GameObject;

		//set random sprite for new rock
		SpriteRenderer spriteRenderer = rock.GetComponent<SpriteRenderer>();
		int spriteNumber = Random.Range(0, 3);
		if (spriteNumber == 0)
			spriteRenderer.sprite = greenrock;
		else if (spriteNumber == 1)
			spriteRenderer.sprite = magentarock;
		else
			spriteRenderer.sprite = whiterock;
	}
}
