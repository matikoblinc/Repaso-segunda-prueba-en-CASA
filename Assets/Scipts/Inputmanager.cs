using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inputmanager : MonoBehaviour
{
    public InputField Username;
    public Text txtUsername;

    public void button1()
    {
        Debug.Log("hola " + int.Parse(txtUsername.text) * 2); 
    }
}
