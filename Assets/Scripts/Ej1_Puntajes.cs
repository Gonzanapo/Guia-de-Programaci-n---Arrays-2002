    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1_Puntajes : MonoBehaviour
{
    //Se ve pero no se puede cambiar dentro del juego.
    [SerializeField]int[] puntajes = new int[10];


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El mayor puntaje es "+ObtenerMayorPuntaje());
        Debug.Log("El nivel con menor puntaje es "+ObtenerNivelDeMenorPuntaje());
        Debug.Log("El promedio es " + ObtenerPuntajePromedio());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int ObtenerMayorPuntaje()
    {
        int mayorPuntaje = 0;
        
        //Foreach lo que hace es crear una variable auxiliar para ALMACENAR el valor de cada posicion del array.
        foreach(int puntaje in puntajes)
        {
            if(puntaje > mayorPuntaje)
            {
                mayorPuntaje = puntaje;
            }

        }

        return (mayorPuntaje);
    }


    int ObtenerNivelDeMenorPuntaje()
    {
        int indiceNivelDeMenorPuntaje = 0;
        int menorPuntaje = puntajes[0];
        //Foreach lo que hace es crear una variable auxiliar para ALMACENAR el valor de cada posicion del array.
        for (int i = 1; i < puntajes.Length; i++)
        {
            if (puntajes[i] < menorPuntaje)
            {
                menorPuntaje = puntajes[i];
                indiceNivelDeMenorPuntaje = i;
            }
        }
        return (indiceNivelDeMenorPuntaje);
    }

    float ObtenerPuntajePromedio()
    {
        float promedio = 0;
        float suma = 0;

        foreach(int puntaje in puntajes)
        {
            suma =+ puntaje;
         
        }

        promedio = suma/puntajes.Length;

        return (promedio);
    }
}
