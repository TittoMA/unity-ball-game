using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timeText;
    public static string time;
    float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(!Goal.isGoal) {
            timer += Time.deltaTime;
        }
        time = timer.ToString("0.00") + "s";
        timeText.text = time;
        Debug.Log(timer);
    }
}
