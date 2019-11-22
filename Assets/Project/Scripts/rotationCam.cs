using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotationCam : MonoBehaviour
    //Cette classe permet de garder le profil face à la caméra
{

    public GameObject cam;
    private Vector3 rotationInit;
    GameObject text;
    main perso;
    Person character;
    
    
    void Start()
    {
    TextMesh t = FindObjectOfType<TextMesh>();
        rotationInit = transform.rotation.eulerAngles;
       // t.text = main.allPerson[0].name;
      //  t.text = perso.p0.name;
       // t.text = character.name;
    }
    
    void Update()
    {
        Quaternion q=new Quaternion();
        q.eulerAngles=cam.transform.rotation.eulerAngles+rotationInit;
        transform.rotation=q;

    }
}
