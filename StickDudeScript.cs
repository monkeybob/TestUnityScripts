using UnityEngine;
using System.Collections;

public class StickDudeScript : MonoBehaviour {
    Animator animator;
    bool timerOn = false;
    int timer = 60;
    int score = 0;
    public GameObject pointA;
    public GameObject pointB;
    float XPos;
    float YPos;
    float XLength;
    float YLength;
    bool active = true;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        XPos = pointA.transform.position.x;
        YPos = pointA.transform.position.y;
        XLength = pointB.transform.position.x - pointA.transform.position.x;
        YLength = pointB.transform.position.y - pointA.transform.position.y;

        transform.position = new Vector2(XPos, YPos);
    }
	
	// Update is called once per frame
	void Update () {
        GameObject cs = GameObject.Find("catch");
        ScoreCount countScript = (ScoreCount)cs.GetComponent(typeof(ScoreCount));
        score = countScript.getScore();

        if (timerOn)
        {
            timer -= 1;
        }
        if (timer <= 0)
        {
            timerOn = false;
            setState(0);
        }
        XPos = pointA.transform.position.x + (XLength * score / 100);
        YPos = pointA.transform.position.y + (YLength * score / 100);

        transform.position = new Vector2(XPos, YPos);
    }
    void setPos(float x, float y)
    {
        transform.position = new Vector2(x, y);
    }
    public void setState(int state)
    {
        animator.SetInteger("State", state);
    }
    public void setHit()
    {
        if (active)
        {
            setState(1);
            timer = 60;
            timerOn = true;
        }
        
    }
    public void setMiss()
    {
        if (active)
        {
            setState(2);
            timer = 60;
            timerOn = true;
        }
    }
    public void setLose()
    {
        timerOn = false;
        active = false;
        timer = 60;
        setState(3);
    }
    public void setWin()
    {
        timerOn = false;
        active = false;
        timer = 60;
        setState(4);
    }
}
