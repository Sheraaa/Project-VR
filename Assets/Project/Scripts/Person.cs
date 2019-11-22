using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour {
    public string _nom;
    public string _prenom;
    public int _age;
    public string _passion;
    public string _animal;
    public string _sexe;
    public int _taille;
    public string recherche ;
    public string _job;
    public int _salaire;
    public Texture2D text;

    public string Nom {
        get {
            return _nom;

        }

        set {
            _nom = value;
        }
    }

    public string Prenom {
        get {
            return _prenom;
        }

        set {
            _prenom = value;
        }
    }

    public int Age {
        get {
            return _age;

        }

        set {
            _age = value;
        }


    }
    public string Sexe {
        get {
            return _sexe;

        }

        set {
            _sexe = value;
        }
    }

    public string Job {
        get {
            return _job;

        }

        set {
            _job = value;
        }


    }

    public int Taille {
        get {
            return _taille;

        }

        set {
            _taille = value;
        }


    }

    public int Salaire {
        get {
            return _salaire;

        }

        set {
            _salaire = value;
        }


    }
    
    public string Animal {
        get {
            return _animal;
        }
        set {
            _animal = value;
        }
    }

    public string Passion {
        get {
            return _passion;
        }
        set {
            _passion = value;
        }
    }

    public void Start() {
        if (text != null) {
            GameObject bas = this.gameObject.transform.GetChild(1).gameObject;
            bas.GetComponent<SkinnedMeshRenderer>().material.SetTexture("face",text);
        }

    }


}

