using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyBullet : MonoBehaviour {
	public float speed = 10f;
	private GameObject scoreObject;
	private Text livesText;

	// Use this for initialization
	void Start () {
		scoreObject = GameObject.Find("Lives");
		livesText = scoreObject.GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.z += speed * Time.deltaTime;
		transform.position = pos;
	}

	public void Remove(){
		Destroy (this.gameObject);
	}

	void OnCollisionEnter(Collision col){
		GameObject obj = col.gameObject;

		if(obj.tag == "Player"){
			string text = livesText.text.Substring(6);
			int intLives = int.Parse (text);
			intLives -= 1;
			livesText.text = "Lives: " + intLives.ToString();

			Controller.setLives (intLives);
		}

		Destroy (this.gameObject);
	}
}
