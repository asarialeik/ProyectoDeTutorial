using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{

    //Variable
    //Tipo De Dato       nombreVariable
    int numDeSaltos = 0;
    public int primerLogroSaltos = 5;
    public int segundoLogroSaltos = 10;
    public int tercerLogroSaltos = 15;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        numDeSaltos = numDeSaltos + 1;
        // Debug.Log("Collision!! message: " + gameObject.name + " ha chocado con " + collision.gameObject.name + " " + miVariable + " veces.");

        if (numDeSaltos == primerLogroSaltos || numDeSaltos == segundoLogroSaltos || numDeSaltos == tercerLogroSaltos)
        {
                print(gameObject.name + " ha chocado " + numDeSaltos + " veces.");
        }
       /*
        else if ()
       {

       }
        else
        {

        }
       */

    }
}
