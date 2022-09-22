//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Runtime.CompilerServices;
//using UnityEngine;

//public class Teleport : MonoBehaviour
//{

//    public static Teleport instance;

//    Vector3 currentPosition;
//    Transform playerLocation, destination;

//    GameObject player;
//    public Transform playerSpawnLvl2;
//    public Transform playerSpawnLvl3;

//    // Start is called before the first frame update
//    void Awake()
//    {
//        instance = this;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        //OnTriggerEnter(Collider other);
//    }

  

//    public void Teleporter()
//    {
//        if (gameObject.CompareTag("Player"))
//            {
//                playerLocation.transform.position = playerSpawnLvl2;
//            }
//    }

//    //if (ScoreManager.instance.score >= 100 && tpLevel2 == true)
//    //{
//    //    //Teleport();
//    //    //return;
//    //    controller.transform.position = playerSpawnLvl2.transform.position;
//    //    tpLevel2 = false;
//    //    Debug.Log("teleported lvl2" + controller.transform.position);
//    //}

//    //if (ScoreManager.instance.score >= 150 && tpLevel3 == true)
//    //{
//    //    //Teleport();
//    //    //return;
//    //    controller.transform.position = playerSpawnLvl3.transform.position;
//    //    tpLevel3 = false;
//    //    Debug.Log("teleported lvl3" + controller.transform.position);
//    //}
//}


