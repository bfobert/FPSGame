using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	[SerializeField] private EnemyBullet enemyBullet;

	public float secondsBetweenShots = 1.2f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Shoot", 2f, secondsBetweenShots);
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	public void Shoot(){
		EnemyBullet eBullet = Instantiate (enemyBullet) as EnemyBullet;
		Vector3 pos = transform.position;
		Transform enemy = this.transform.parent;
		//Debug.Log (enemy.eulerAngles.y);
		if (enemy.eulerAngles.y > 89 && enemy.eulerAngles.y < 91) {
			pos.x = pos.x + 0.7f;
			eBullet.transform.eulerAngles = new Vector3(0, 90, 0);

		} else if (enemy.eulerAngles.y > 170 && enemy.eulerAngles.y < 181) {
			pos.z = pos.z - 0.7f;
			eBullet.transform.eulerAngles = new Vector3(0, 180, 0);

		} else if (enemy.eulerAngles.y > 269 && enemy.eulerAngles.y < 271) {
			pos.x = pos.x - 0.7f;
			eBullet.transform.eulerAngles = new Vector3(0, 270, 0);
		} else {
			pos.z = pos.z + 0.7f;
		}

		eBullet.transform.position = pos;
	}
}
