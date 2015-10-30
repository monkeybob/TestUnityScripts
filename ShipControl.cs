using UnityEngine;
using System.Collections;

public class ShipControl : MonoBehaviour {
	
	public float speed;
    public float rotationSpeed;

	private Rigidbody rb;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (0, 0, moveVertical);
        Vector3 Rotation = new Vector3 (0, moveHorizontal, 0);

		rb.AddRelativeForce (movement * speed);
        rb.AddRelativeTorque(Rotation * rotationSpeed);
	}
	

}