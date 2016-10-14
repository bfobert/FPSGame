using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {
	
	[SerializeField] private TargetScript targetPrefab;
	[SerializeField] private Text scoreText;
	[SerializeField] private Text livesText;
	[SerializeField] private EndGameCanvas loseGame;
	[SerializeField] private EndGameCanvas winGame;

	private float offsetX = 3.0f;
	private float offsetZ = 5.0f;
	private static int score;
	private static int lives;

	// Use this for initialization
	void Start () {
		loseGame.Close ();
		winGame.Close ();
		score = 0;
		lives = 3;

		Vector3 startPos = targetPrefab.transform.position;
		Vector3 pos = Vector3.zero;
		for (int i = 0; i < 6; i++) {
			TargetScript target;

			if (i == 0) {
				target = targetPrefab;
			} else {
				target = Instantiate (targetPrefab) as TargetScript;
			}

			float posZ = -(offsetX * i) + startPos.z;
			target.transform.position = new Vector3 (startPos.x, startPos.y, posZ);
		}

		scoreText.text = "Score: " + score;
		livesText.text = "Lives: " + lives;
	}
	
	// Update is called once per frame
	void Update () {
		if(lives <= 0){
			loseGame.Open ();
		}

		GameObject[] enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		if(enemies.Length <= 0){
			winGame.Open ();
		}

		if(Input.GetKeyDown(KeyCode.Return)){
			SceneManager.LoadScene ("Level1");
		}
	}

	public static void setScore(int newScore){
		score = newScore;
	}

	public static void setLives(int newLives){
		lives = newLives;
	}
		
}
