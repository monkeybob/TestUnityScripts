using UnityEngine;
using System.Collections;

public class ProjectileSwooce : MonoBehaviour {
    // Script to handle projectile movement

    public float speed = 10f;
    public float InitSpeed = 7500f;
    public Vector2 TargetPosition;

    
    void Start () {
        //Debug.Log(GameObject.Find("crosshair").transform.position.ToString());
        Vector2 source = new Vector2(transform.position.x, transform.position.y);
        Vector2 dir = (Vector2)GameObject.Find("crosshair").transform.position - (Vector2)(transform.position);
        dir.Normalize();
        GetComponent<Rigidbody2D>().AddForce(dir * InitSpeed, ForceMode2D.Force);
    }
	
	// Update is called once per frame
	void Update () {
        //Vector2 aimPos = new Vector2(aim.transform.position.x, aim.transform.position.y);
        ////Vector2 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Vector2 source = new Vector2(transform.position.x, transform.position.y);
        //Vector2 dir = aimPos - (Vector2)(transform.position);
        //dir.Normalize();
        //GetComponent<Rigidbody2D>().AddForce(dir * speed, ForceMode2D.Force);
    }
}
