using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text spheresText;
    public Text capsulesText;

    public int score = 0;
    int capsules = 0;
    int spheres = 0;

    CharacterController characterController;

    public Vector3 startPosition;
    public Vector3 playerSpawnLvl2;
    public Vector3 playerSpawnLvl3;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "POINTS: " + score.ToString();
        capsulesText.text = "Capsules: " + capsules.ToString();
        spheresText.text = "Spheres: " + spheres.ToString();

    }

    private void Update()
    {

    }

    public void AddPoint(int v)
    {
        score += v;
        scoreText.text = "POINTS: " + score.ToString();    
    }
    public void AddCapsule()
    {
        capsules ++;
        capsulesText.text = "Capsules: " + capsules.ToString();
    }
    public void AddSphere()
    {
        spheres ++;
        spheresText.text = "Spheres: " + spheres.ToString();
    }
      
    }

