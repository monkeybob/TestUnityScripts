using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuzzMovement : MonoBehaviour {
    // Script to handle main player movement

	float currX;
	float currY;
	//float speedX;
	//float speedY;
	public float speed = 10.0F;



	private Rigidbody2D rb;
	
	// Use this for initialization
	void Start () {
		currX = transform.position.x;
		currY = transform.position.y;

		rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
		float moveY = Input.GetAxis ("Vertical") * speed;
		float moveX = Input.GetAxis ("Horizontal") * speed;
		moveY *= Time.deltaTime;
		moveX *= Time.deltaTime;
		currX = currX + moveX;
		currY = currY + moveY;

		transform.position = new Vector2 (currX, currY);
    }

	

	

}