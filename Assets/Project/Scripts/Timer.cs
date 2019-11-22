using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float sec = 59;
    public int minute = 5;
    public float startTime;
    private string time;
    Text text;
    
    void Update() {
        if (sec >= 0) {

            sec -= Time.deltaTime;
        }
        else {
            minute--;
            sec = 59;
        }

        time = string.Format("{0:0}", sec);
        text.text = "Temps restant: " + time;
        
    }
}
