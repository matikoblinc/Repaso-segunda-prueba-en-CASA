using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiatori : MonoBehaviour
{
    public GameObject cubo;
   
    public void Instantiaror1()
    {
        for (int i = 0; i < 2; i++)
        {
            GameObject clon;
          
            clon = Instantiate(cubo);
         
            Destroy(clon, 1);
           
        }
    }

}
