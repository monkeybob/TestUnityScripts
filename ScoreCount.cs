using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour {
    // Script to handle game score
    public Text countText;
    public Text speedText;
    public int Amount;
    private int count;
    private float speed;
    public float initSpeed = 120f;
    public bool isLive = true;
    public GameObject panel;
    private bool isWon = false;
    public int winAmount = 100;
    public GameObject GameOverPanel;
    public Text GameOverStateText;
    public Text GameOverScoreText;

    // Use this for initialization
    void Start () {
        count = 0;
        GameObject go = GameObject.Find("DamnSpawn");
        SpiderSpawn speedScript = (SpiderSpawn)go.GetComponent(typeof(SpiderSpawn));
        speedScript.setSpeed(initSpeed);
        speed = initSpeed;
        SetCountText();

    }
	
	// Update is called once per frame
	void Update () {
        
        
    }

    // detects collision with specific game object
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            /*if (isLive)
            {
                count = count + 1;
            }
            else
            {
            }*/
            SetCountText();
        }
    }

    // sets score counter
    void SetCountText()
    {
        
        /*if (count >= amount) {
			winText.text = win;
		}*/


        // set speed
        if (isLive)
        {
            if (isWon)
            {
                countText.text = "";
                speedText.text = "";
                //panel.SetActive(true);
                speed = 6000000;
                GameOverPanel.SetActive(true);
                GameOverScoreText.text = "Final Score: " + count.ToString();
                GameOverStateText.text = "You Win!";
                GameObject dude = GameObject.Find("stick-dude");
                StickDudeScript dudeScript = (StickDudeScript)dude.GetComponent(typeof(StickDudeScript));
                dudeScript.setWin();

            }
            else
            {
                countText.text = "Score: " + count.ToString();

                speed = initSpeed - (count * 1f);

                int intspd = (int)initSpeed - (int)speed;
                // display speed
                speedText.text = "Speed: " + intspd.ToString();
            }
            
        }
        else
        {
            countText.text = "";
            speedText.text = "";
            //panel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            GameOverPanel.SetActive(true);
            GameOverScoreText.text = "Final Score: " + count.ToString();
            GameOverStateText.text = "You Lose";
        }

        if (speed >= 0)
        {
            GameObject go = GameObject.Find("DamnSpawn");
            SpiderSpawn speedScript = (SpiderSpawn)go.GetComponent(typeof(SpiderSpawn));
            speedScript.setSpeed(speed);
        }
    }

    public void setLose()
    {
        isLive = false;
        speed = 3;
        SetCountText();
        GameObject dude = GameObject.Find("stick-dude");
        StickDudeScript dudeScript = (StickDudeScript)dude.GetComponent(typeof(StickDudeScript));
        dudeScript.setLose();
    }

    public void incrementScore(int val)
    {
        if (isLive)
        {
            count = count + val;
            if (count >= winAmount)
            {
                isWon = true;
            }
            else
            {
                GameObject dude = GameObject.Find("stick-dude");
                StickDudeScript dudeScript = (StickDudeScript)dude.GetComponent(typeof(StickDudeScript));
                dudeScript.setHit();
            }
        }
        SetCountText();
    }
    public int getScore()
    {
        return count;
    }
}
