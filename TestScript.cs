using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {
	float currX;
	float currY;
	float speedX;
	float speedY;

	// Use this for initialization
	void Start () {
		currX = transform.position.x;
		currY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		speedX = Random.Range(-0.1f, 0.1f);
		speedY = Random.Range(-0.1f, 0.1f);
		currX = currX - speedX;
		currY = currY - speedY;

		transform.position = new Vector2 (currX, currY);
	}
}
