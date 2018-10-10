using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

	public GameObject enemyToSpawn;
	public float enemySpawnTimeFLOAT0 = 1.0f;
	public float enemySpawnTimeFLOAT1 = 2.0f;
	public float enemySpawnTimeFLOAT2 = 3.3f;
	public float enemySpawnTimeFLOAT3 = 1.5f;

	public bool canSpawn = true;

	void Start () {
		StartCoroutine (enemySpawnTimer0 ());
		StartCoroutine (enemySpawnTimer1 ());
		StartCoroutine (enemySpawnTimer2 ());
		StartCoroutine (enemySpawnTimer3 ());
	}

	void Update () {
		
	}

	IEnumerator enemySpawnTimer0() {
		while (canSpawn == true) {

			spawnEnemy0 ();
			yield return new WaitForSeconds (enemySpawnTimeFLOAT0);
		}
	}
	IEnumerator enemySpawnTimer1() {
		while (canSpawn == true) {

			spawnEnemy1 ();
			yield return new WaitForSeconds (enemySpawnTimeFLOAT1);
		}
	}
	IEnumerator enemySpawnTimer2() {
		while (canSpawn == true) {

			spawnEnemy2 ();
			yield return new WaitForSeconds (enemySpawnTimeFLOAT2);
		}
	}
	IEnumerator enemySpawnTimer3() {
		while (canSpawn == true) {

			spawnEnemy3 ();
			yield return new WaitForSeconds (enemySpawnTimeFLOAT3);
		}
	}

	void spawnEnemy0 (){
		Instantiate (enemyToSpawn, new Vector3 (-28, 20, 0), Quaternion.identity);
	}

	void spawnEnemy1 (){
		Instantiate (enemyToSpawn, new Vector3 (28, 20, 0), Quaternion.identity);
	}

	void spawnEnemy2 (){
		Instantiate (enemyToSpawn, new Vector3 (-28, -20, 0), Quaternion.identity);
	}

	void spawnEnemy3 (){
		Instantiate (enemyToSpawn, new Vector3 (28, -20, 0), Quaternion.identity);
	}
}
