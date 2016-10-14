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
		pos.z = pos.z + 0.7f;
		eBullet.transform.position = pos;
	}
}
