using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner instance;

    public GameObject[] scoreItems;
    public GameObject obstacles;
    public Vector3 spawnValues;
    public float spawnWait;    
    public float spawnMostWait; //decides what time increments to spawn with 
    public float spawnLeastWait; //decides what time increments to spawn with
    public int startWait;

    public GameObject ground;

    int randScoreItems;
    int randObstacles;

    private void Start()
    {
        instance = this;
        SetGround("Level 1");
    }

    public void SetGround(string GroundObjectName)
    {
        ground = GameObject.Find(GroundObjectName);
        
    }

    public void spawnScoreItems()
    {
        randScoreItems = Random.Range(0, 2);

        var groundLocation = ground.gameObject.transform.position;
        //var groundLocation = new Vector3(-50, 1, -50);
        var groundCollider = ground.GetComponent<BoxCollider>();
        var temp = groundCollider.size;
        var actualSize = Vector3.Scale(groundCollider.size, ground.gameObject.transform.localScale);
        Vector3 spawnPosition = new Vector3(Random.Range(groundLocation.x, groundLocation.x + actualSize.x), 1, Random.Range(groundLocation.z, groundLocation.z + actualSize.z));

        Instantiate(scoreItems[randScoreItems], spawnPosition, gameObject.transform.rotation);

    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Backspace))
        {
            spawnScoreItems();
        }
    }
        
}
