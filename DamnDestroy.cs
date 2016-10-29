using UnityEngine;
using System.Collections;

public class DamnDestroy : MonoBehaviour {
    // Script to handle destroying objects, such as on bullet hit or when leaving camera view

    public string TagToCompare;
    public bool IsScore;
    public int ScoreIncrement;
    public bool InstantiateSomething;
    public GameObject Something;
    public bool IsMiss;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag (TagToCompare))
		{
            if (IsScore)
            {
                GameObject go = GameObject.Find("catch");
                ScoreCount CountScript = (ScoreCount)go.GetComponent(typeof(ScoreCount));
                CountScript.incrementScore(ScoreIncrement);
            }
            if (IsMiss)
            {
                GameObject go = GameObject.Find("Ground");
                MissCount MissScript = (MissCount)go.GetComponent(typeof(MissCount));
                MissScript.incrementMiss();
            }
            if (InstantiateSomething)
            {
                Instantiate(Something, transform.position, transform.rotation);
            }
            Destroy(gameObject);
		}
	}
}
