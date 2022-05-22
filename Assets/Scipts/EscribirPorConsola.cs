using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscribirPorConsola : MonoBehaviour
{
   

    public void EscribirConsola()
    {
        int i = 1;

        while (i < 100)
        {
            Debug.Log(i);
            i++;
        }
        
    }
}
