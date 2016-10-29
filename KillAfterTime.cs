using UnityEngine;
using System.Collections;

public class KillAfterTime : MonoBehaviour {

    public float killtime;

    void Update () {
        killtime -= 1.0F * Time.deltaTime;

        if (killtime <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    
    }
}
