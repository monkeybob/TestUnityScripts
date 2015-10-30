using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShipControl : MonoBehaviour {
	
    public float rotationSpeed;
    public float absoluteSpeed;
    public Scrollbar SpeedScrollbar; 

	private Rigidbody rb;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
	{
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 Rotation = new Vector3(0, moveHorizontal, 0);

        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * absoluteSpeed * SpeedScrollbar.value);
        rb.AddRelativeTorque(Rotation * rotationSpeed);
    }
	

}