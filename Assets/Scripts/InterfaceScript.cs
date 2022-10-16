using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InterfaceScript : MonoBehaviour
{
    public GameObject panel;
    public TMP_Text timeResult;
    public GameObject animation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Goal.isGoal) {
            timeResult.text = Timer.time;
            panel.gameObject.SetActive(true);
            animation.GetComponent<Animator>().enabled = false;
        }
    }
}
