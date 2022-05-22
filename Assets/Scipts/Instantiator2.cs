using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator2 : MonoBehaviour
{
    public GameObject cubo1;
    public Text txtNumero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Instantiaror1()
    {
        for (int i = 0; i < int.Parse(txtNumero.text); i++)
        {
            GameObject clon;

            clon = Instantiate(cubo1);

            clon.transform.Translate(i, 0, 0);

           Destroy(clon, 2);

        }
    }
}
