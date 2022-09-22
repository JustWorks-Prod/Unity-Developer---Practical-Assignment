using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItems : MonoBehaviour
{

    public int value;
    public int capsule;
    public int sphere;

       private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            Destroy(gameObject);
            ScoreManager.instance.AddPoint(value);
            Spawner.instance.spawnScoreItems();
        } 
    }
}
