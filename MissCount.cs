using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MissCount : MonoBehaviour {
    // Script to handle enemies which have evaded being hit and have fallen to the ground
    public Text missText;
    public int MissInt = 5;
    private int count;

	void Start () {
        count = MissInt;
        setMissText();
	}

    public void incrementMiss()
    {
        count = count - 1;
        setMissText();
        if (count > 0)
        {
            GameObject dude = GameObject.Find("stick-dude");
            StickDudeScript dudeScript = (StickDudeScript)dude.GetComponent(typeof(StickDudeScript));
            dudeScript.setMiss();
        }
    }
    void setMissText()
    {
        if (count <= 0)
        {
            missText.text = "";
            GameObject go = GameObject.Find("catch");
            ScoreCount sc = (ScoreCount)go.GetComponent(typeof(ScoreCount));
            sc.setLose();
        }
        else
        {
            missText.text = "Lives: " + count.ToString();
            
        }
    }
}
