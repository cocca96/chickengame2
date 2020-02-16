using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public Text TimeText;
    public float TimeStamp;
    public bool usingTimer = false;
    public GameObject timer;
    public bool lacca = true;
  
    
    void Start()
    {

        //SetTimer(600);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (usingTimer)
            SetUIText();
        
    }
    public void SetTimer(float time)
    {
        if (usingTimer)
            return;

        TimeStamp = Time.time + time;
        usingTimer = true;
    }
    public void SetUIText()
    {
        float timeLeft = TimeStamp - Time.time;
        if (timeLeft < 41)
        {
            timer = GameObject.Find("TimerText");
            Text img = timer.GetComponent<Text>();
            img.color=Color.red;
            img.fontSize = 20;
            



        }
        if (timeLeft <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        float hours;
        float minutes;
        float seconds;
        float miniseconds;
        GetTimeValues(timeLeft, out hours, out minutes, out seconds, out miniseconds);
        if(hours>0)
            TimeText.text = string.Format("{0}:{1}",hours,minutes);
        else if(minutes>0)
            TimeText.text = string.Format("{0}:{1}", minutes,seconds);
        else
            TimeText.text = string.Format("{0}:{1}", seconds,miniseconds);

    }
  
  

    public void GetTimeValues(float time, out float hours, out float minutes, out float seconds, out float miniseconds)
    {
        hours = (int)(time / 3600f);
        minutes= (int)((time - hours * 3600) / 60f);
        seconds = (int)((time - hours * 3600 - minutes * 60));
        miniseconds = (int)((time - hours * 3600 - minutes) * 100);

    }
    
}
