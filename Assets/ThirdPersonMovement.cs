using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;   
    public float speed = 6f;

    public Transform playerSpawnLvl2;
    public Transform playerSpawnLvl3;

    Transform playerSpawn;
    Transform playerPosition;
    bool tpLevel2 = true;
    bool tpLevel3 = true;
    bool winCondition = true;
    GameObject player;


    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    // Update is called once per frame
    // From Brackeys - THIRD PERSON MOVEMENT in Unity (May 24th 2020)
    // - Uses "old Unity movement system"

    private void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
        playerSpawnLvl2 = GameObject.FindGameObjectWithTag("Respawn1").transform;
        playerSpawnLvl3 = GameObject.FindGameObjectWithTag("Respawn2").transform;
    }

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized; //.normalized makes it so the player doesn't move faster when moving diagonally (like Perfect Dark)
        
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) *Mathf.Rad2Deg + cam.eulerAngles.y; //Atan2 is a function that calculates the angle between the direction Vector3s and face the player into the correct direction
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime); //using TIme.deltaTime make movement framerate independent
        }

        Teleport();
    }

    private void Teleport()
    {
        if(ScoreManager.instance.score >= 100 && tpLevel2 == true)
        {
            //controller.transform.position = playerSpawnLvl2.transform.position;
            player.SetActive(false);
            playerPosition.position = new Vector3(playerSpawnLvl2.position.x, playerSpawnLvl2.position.y, playerSpawnLvl2.position.z);
            tpLevel2 = false;
            Spawner.instance.SetGround("Level 2");
            Debug.Log("Teleported to Lvl 2  " + playerSpawnLvl2.transform.position);
            player.SetActive(true);
        }
        
        if(ScoreManager.instance.score >= 200 && tpLevel3 == true)
        {
            //controller.transform.position = playerSpawnLvl2.transform.position;
            player.SetActive(false);
            playerPosition.position = new Vector3(playerSpawnLvl3.position.x, playerSpawnLvl3.position.y, playerSpawnLvl3.position.z);
            tpLevel3 = false;
            Spawner.instance.SetGround("Level 3");
            Debug.Log("Teleported to Lvl 3  " + playerSpawnLvl3.transform.position);
            player.SetActive(true);
        } 
        
        if(ScoreManager.instance.score >= 400 && winCondition == true)
        {
            //controller.transform.position = playerSpawnLvl2.transform.position;
            player.SetActive(false);
            playerPosition.position = new Vector3(playerSpawnLvl3.position.x, playerSpawnLvl3.position.y, playerSpawnLvl3.position.z);
            winCondition = false;
            Debug.Log("You Win!  " + playerSpawnLvl3.transform.position);
            player.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Capsule"))
        {
            ScoreManager.instance.AddCapsule();
        }

        else if (other.gameObject.CompareTag("Sphere"))
        {
            ScoreManager.instance.AddSphere();
        }

    }
}
