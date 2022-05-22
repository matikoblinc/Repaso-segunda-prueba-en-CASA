using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumerosEntreDos : MonoBehaviour
{
    public int num1;
    public int num2;

    public void NumEntreDos()
    {
        if (num1 == num2)
        {
            Debug.Log("los numeros son iguales");
        }
        else if (num2 > num1)
        {
            Debug.Log("el primer numero debe ser mayor");
        }
        else
        {
            while (num1 >= num2)
            {
                Debug.Log(num1);
                num1--;
            }
        }
    }
}
