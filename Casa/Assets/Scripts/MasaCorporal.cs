using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasaCorporal : MonoBehaviour
{
    public string Nombre;
    public float alturaDeLaPersona;
    public float pesoKilogramos;
 
    
    // Start is called before the first frame update
    void Start()
    {
        float imc;
        float Altura;

        Altura = alturaDeLaPersona * alturaDeLaPersona;
        imc = pesoKilogramos / Altura;


        //Debug.Log("Nombre del usuario" + Nombre);
        //Debug.Log("La altura del usuario" + alturaDeLaPersona)
        //Debug.Log("Peso del usuario" + pesoKilogramos);
        Debug.Log(imc);

        if (imc < 18f)
        {
            Debug.Log("Bajo peso");
        }
        if (imc >18.1f && imc <24.1f)
        {
            Debug.Log("Esta en peso normal");
        }
        if(imc > 25f && imc < 26.9f)
        {
            Debug.Log("estas en sobre peso");
        }
        if (imc > 27f && imc < 29.9f)
        {
            Debug.Log("Estas en obecidad");
        }
        if (imc > 30f && imc < 34.9f)
        {
            Debug.Log("Estas en obesidad tipo uno");
        }
        if(imc > 35f && imc <39.9f)
        {
            Debug.Log("Estas en obesidad tipo dos");
        }
        if(imc > 40f)
        {
            Debug.Log("Estas en obesidad tipo tres");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
