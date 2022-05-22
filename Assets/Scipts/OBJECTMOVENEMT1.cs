using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJECTMOVENEMT1 : MonoBehaviour
{

    public Vector3 movement;
    public Vector3 rotation1;
    public Vector3 scale1;
    public GameObject cubo;

    // Start is called before the first frame update
    void Start()
    {
        cubo.transform.position = movement; // para moverse
        cubo.transform.eulerAngles = rotation1; // para rotar se usa eulerAngles que es la forma de hacerlo
        cubo.transform.localScale = scale1; //para escalar se usa localScale
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
