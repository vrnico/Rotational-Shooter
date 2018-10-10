using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour {

	ScoreLogic addToScore;

	void Start () {
		
	}
	

	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D transformCollision) {
		if (transformCollision.gameObject.tag == "Enemy") {
			callScoreLogicScript ();
			Destroy (transformCollision.gameObject);
		}
	}

	void callScoreLogicScript(){
		addToScore = GameObject.FindGameObjectWithTag ("GUI").GetComponent<ScoreLogic> ();
		addToScore.addToScoreVOID ();
	}
}
