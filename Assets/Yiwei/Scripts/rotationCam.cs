using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotationCam : MonoBehaviour
{

    public GameObject cam;
    private Vector3 rotationInit;
    GameObject text;
    main perso;
    Person character;
    

    // Start is called before the first frame update
    void Start()
    {
    TextMesh t = FindObjectOfType<TextMesh>();
        rotationInit = transform.rotation.eulerAngles;
       // t.text = main.allPerson[0].name;
      //  t.text = perso.p0.name;
       // t.text = character.name;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion q=new Quaternion();
        q.eulerAngles=cam.transform.rotation.eulerAngles+rotationInit;
        transform.rotation=q;

    }
}
