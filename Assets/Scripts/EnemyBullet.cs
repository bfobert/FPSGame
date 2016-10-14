using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyBullet : MonoBehaviour {
	public float speed = 12f;
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
		Debug.Log (transform.eulerAngles.y);
		if (transform.eulerAngles.y > 89 && transform.eulerAngles.y < 91) {
			pos.x += speed * Time.deltaTime;
		} else if (transform.eulerAngles.y > 170 && transform.eulerAngles.y < 181) {
			pos.z -= speed * Time.deltaTime;
		} else if (transform.eulerAngles.y > 269 && transform.eulerAngles.y < 271) {
			pos.x -= speed * Time.deltaTime;
		} else {
			pos.z += speed * Time.deltaTime;
		}

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
