using UnityEngine;
using System.Collections;

public class ControlScript : MonoBehaviour {
    // Script to handle control layout

	void Update () {
	    if (Input.GetAxis("Fire2") >= 0.5)
        {
            setController();
        }
	}
    public void setKeyboard()
    {
        setGameActive();
    }
    public void setController()
    {
        GameObject obj = GameObject.Find("crosshair");
        MouseAim script = (MouseAim)obj.GetComponent(typeof(MouseAim));
        script.joystick = true;
        setGameActive();
    }
    public void setTouch()
    {
        //TODO thing
        setGameActive();
    }
    public void setGameActive()
    {
        GameObject obj = GameObject.Find("DamnSpawn");
        SpiderSpawn script = (SpiderSpawn)obj.GetComponent(typeof(SpiderSpawn));
        script.setActive(true);
        this.gameObject.SetActive(false);
    }
}
