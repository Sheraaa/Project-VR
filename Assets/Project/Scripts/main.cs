using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour {

    private List<Person> listPersonne = new List<Person>();
    private Dictionary<int, List<Person>> DPerson = new Dictionary<int, List<Person>>();
    public static Person[] allPerson;

    public Person p0 = null;
    public Person p1 = null;
    public AudioSource sound;


    public void CheckMatch() {
        //Si pas attraper > ne rien faire et attendre que le joueur attrape une poupée pour faire le match
        if (p0 == null || p1 == null) {
            return;
        }

        // MATCH MAKING

        if (p0.Age - p1.Age >= 10) {
            sound.Play();  //sad
            return;
        }else if(p1.Age - p0.Age >= 10) {
            sound.Play();  //sad
            return;
        }
    
        if (p0.Sexe=="homme") {
            if (p0.Salaire < p1.Salaire) {
                sound.Play();  //sad
                return;
            }
        }else if(p0.Sexe == "femme") {
            if (p0.Salaire > p1.Salaire) {
                sound.Play();  //sad
                return;
            }
        }
        if (p0 != null || p1 != null) {
            //Match afficher Win
            sound.Play();  //MATCH
        }
    }

    public void Grabbed(GameObject o) {
        if (o.GetComponent<PersonRef>() != null) {
            Person p = o.GetComponent<PersonRef>().reference;
            if (p == null) {
                return;
            }
            if (p0 == null) {
                p0 = p;
            }
            else if (p0 != p && p1 == null) {
                p1 = p;
                if (p1 == p0) {
                    p1 = null;
                }
            }
            CheckMatch();
        }
        
    }

    public void Released(GameObject o) {
        if (o.GetComponent<PersonRef>() != null) {
            Person p = o.GetComponent<PersonRef>().reference;
            if (p == null) {
                return;
            }
            if (p0 == p) {
                p0 = null;
            }
            else if (p1 == p) {
                p1 = null;
            }
        }
    }

    private void Start() {
        //pour aller chercher toutes les données de toutes les poupées!
        allPerson = UnityEngine.Object.FindObjectsOfType<Person>();
        

    }
}


