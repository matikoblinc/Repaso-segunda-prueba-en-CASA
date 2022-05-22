using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float num1;

    // Update is called once per frame
    void Update()
    {
       // if (transform.position.x < 10)
       // {
       //     transform.position += new Vector3(0.1f, 0, 0);
       // }
       // Para que el objeto se mueva hasta los 10 M de donde comenzó

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(num1, 0, 0);
        }
        // para que se mueva cuando tocas la letra D hacia la derecha.
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(num1, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, num1, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, num1, 0);
        }
        // para hacer que se mueva en todas direcciones. 
    }
}
