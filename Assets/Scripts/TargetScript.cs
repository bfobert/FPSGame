using UnityEngine;
using System.Collections;

public class TargetScript : MonoBehaviour {

	public GameObject targetPrefab;




	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision coll){
		GameObject collidedWith = coll.gameObject;

		if(collidedWith.tag == "Bullet"){
			Destroy (this.gameObject);
		}
	}
}
