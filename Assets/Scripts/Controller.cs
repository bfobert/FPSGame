using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	
	[SerializeField] private TargetScript targetPrefab;

	private float offsetX = 3.0f;
	private float offsetZ = 5.0f;

	// Use this for initialization
	void Start () {
		Vector3 startPos = targetPrefab.transform.position;
		Vector3 pos = Vector3.zero;
		for (int i = 0; i < 5; i++) {
			TargetScript target;

			if (i == 0) {
				target = targetPrefab;
			} else {
				target = Instantiate (targetPrefab) as TargetScript;
			}

			float posX = (offsetX * i) + startPos.x;
			target.transform.position = new Vector3 (posX, startPos.y, startPos.z);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
