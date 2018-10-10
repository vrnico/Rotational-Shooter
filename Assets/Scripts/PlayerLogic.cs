using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLogic : MonoBehaviour {


	void Start () {
		
	}
	

	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D tempCollision) {
		if (tempCollision.gameObject.tag == "Enemy") {
			SceneManager.LoadScene ("GameScene");
		}
	}
}
