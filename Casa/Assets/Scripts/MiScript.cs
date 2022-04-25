using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiScript : MonoBehaviour
{
    public string mensajeBienvenida;
    public string miNombre;
    public string suNombre;
    public int edad;
    public int suEdad;
    //public float b;
    private int suma;
    //public bool estaArriba;
    // Start is called before the first frame update
    void Start()
    {
        suma = edad + suEdad;
        Debug.Log(mensajeBienvenida);

        Debug.Log("Hola, Mundo");
        Debug.Log(miNombre + "y" + suNombre + "van a invadir polonia" + "ellos quieren conquistar polonia por que les gusta que la edad de los dos se junten");
        Debug.Log("la edad de mi amigo es" + suEdad);
        Debug.Log("Mi edad es" + edad);

        //Debug.Log(miNombre + "La edad es" + edad);

        //Debug.Log(suNombre + "La edad es" + suEdad);

        //Debug.Log(edad + suEdad + suma);

        Debug.Log("Nuestras edades juntas son" + suma);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Onjump()
    {

    }
}
