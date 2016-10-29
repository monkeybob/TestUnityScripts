using UnityEngine;
using System.Collections;

public class ProjectileSource : MonoBehaviour {
    // Script that handles the source of the projectile
    public GameObject projectile;
    private GameObject clone;
    private bool canFire = true;
    public ScoreCount scs;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float triggerValue = Input.GetAxis("Fire2");
        if (canFire)
        {
            if (Input.GetButtonDown("Fire1") || Input.GetAxis("Fire2") >= 0.5)
            {
                Instantiate(projectile, transform.position, transform.rotation);
                //scs.incrementScore(1);
                canFire = false;
            }
        }
        else if (Input.GetAxis("Fire2") < 0.5)
        {
            canFire = true;
        }
        
    }
}
