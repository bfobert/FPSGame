using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TargetScript : MonoBehaviour {
	[SerializeField] private Text score;
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
			string text = score.text.Substring(6);
			int intScore = int.Parse (text);
			intScore += 100;
			Controller.setScore (intScore);
			score.text = "Score: " + intScore.ToString();

			Destroy (this.gameObject);
		}
	}
}
