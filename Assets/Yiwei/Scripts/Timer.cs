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
    public GUISkin skin;


    private void Awake() {
     //   text = GetComponent<Text>();
    }

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

    //void OnGUI() {

    //    string niceTime = string.Format("{0:0}:{1:00}", minute, sec);

    //    GUI.Label(new Rect(250, 90, 250, 100), niceTime);

    //    string point = "120";
    //    string score = "SCORE: ";

    //    if (minute < 0) {
    //        JEU FINI, AFFICHER LE SCORE
    //        Application.Quit();
    //        GUI.Label(new Rect(300, 230, 350, 500), score);
    //        GUI.Label(new Rect(300, 250, 350, 500), point);
    //        return;
    //    }
    //}
}
