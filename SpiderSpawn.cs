using UnityEngine;
using System.Collections;

public class SpiderSpawn : MonoBehaviour {
    // Script to handle random spawning of enemies
    public bool active = false;

	float posX;
	float posY;
	float randX;
	float randY;
    int randSpawn;

	int timer = 0;
    public GameObject[] spawnArray;
    public GameObject spawnEffect;

	public float MinimumX = 0;
	public float MaximumX = 0;
	public float MinimumY = 0;
	public float MaximumY = 0;
	public int Timer;
    
	// Use this for initialization
	void Start () {
		posX = transform.position.x;
		posY = transform.position.y;
	}
	public void setActive(bool state)
    {
        enabled = state;
    }
    public void setSpeed(float speed)
    {
        Timer = (int)speed;
    }

    public float getSpeed()
    {
        return Timer;
    }
	// Update is called once per frame
	void Update () {
        if (enabled)
        {
            if (timer >= Timer)
            {
                timer = 0;
                randomPos();
                spawnRandom();
            }
            else
            {
                timer = timer + 1;
            }
        }
		
	}
    void randomPos()
    {
        float minX = MinimumX;
        float maxX = MaximumX;
        float minY = MinimumY;
        float maxY = MaximumY;
        randX = Random.Range(minX, maxX);
        posX = randX;
        randY = Random.Range(minY, maxY);
        posY = randY;

    }
    void spawnRandom()
    {
        randSpawn = Random.Range(0, spawnArray.Length);
        transform.position = new Vector2(posX, posY);
        GameObject spawn = spawnArray[randSpawn];
        Instantiate(spawn, transform.position, transform.rotation);
        Instantiate(spawnEffect, transform.position, transform.rotation);
    }
}
