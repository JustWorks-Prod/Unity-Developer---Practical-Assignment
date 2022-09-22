using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeStamp : MonoBehaviour
{
    //public static TimeStamp instance;
    //public Text timeCounter;

    //private TimeSpan timePlaying;
    //private bool timerGoing;

    //private float elapsedTime;

    //private void Awake()
    //{
    //    instance = this;
    //}

    //Variables to display system time
    public GameObject theDisplay;
    public int hour;
    public int minutes;
    public int seconds;

    // Start is called before the first frame update
    void Start()
    {
        //timeCounter.text = "Time: 00:00:00";
        //timerGoing = false;

        //Timer that displays system time
        hour = System.DateTime.Now.Hour;
        minutes = System.DateTime.Now.Minute;
        seconds = System.DateTime.Now.Second;
        theDisplay.GetComponent<Text>().text = "" + hour + ":" + minutes + ":" + seconds;
    }

    //public void BeginTimer()
    //{
    //    timerGoing = true;
    //    elapsedTime = 0f;

    //    StartCoroutine(UpdateTimer());
    //}

    //public void EndTimer()
    //{
    //    timerGoing = false;
    //}

    //private IEnumerator UpdateTimer()
    //{
    //    while (timerGoing)
    //    {
    //        elapsedTime += Time.deltaTime;
    //        timePlaying = TimeSpan.FromSeconds(elapsedTime);
    //        string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
    //        timeCounter.text = timePlayingStr;

    //        yield return null;
    //    }
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
