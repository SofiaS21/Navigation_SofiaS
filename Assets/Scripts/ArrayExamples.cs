using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExamples : MonoBehaviour
{
    public int[] edades = new int[4];  
    public int sumaDeLasEdades;

    public int[] notas;
    public int cantReprobados;

    public int[] distancias;
    public int mayorDe100;


    //Crear un array que almacene distancias en km y devuelva cuantos valores 
    //son mayores que 100


    // Start is called before the first frame update
    void Start()
    {
        sumaDeLasEdades = SumaValoresDelArray(edades);
        cantReprobados = CantidadDeReprobados(notas);
        mayorDe100 = MayorDistanciasDe100(distancias);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int SumaValoresDelArray(int[] arr)
    {
        int resultado = 0;

        for(int i = 0; i < arr.Length; i++)  //(variableContadora;condicion ;variacion) 
        {
            resultado = resultado + arr[i]; //resultado = resultado + arr[i]
        }

        return resultado;
    }

    int CantidadDeReprobados(int[] valores) //valores tambien puede ser arr
    {
        int reprobados = 0;

        for(int i = 0; i < valores.Length; i++)
        {
            if(valores[i] < 6)
            {
                reprobados++;
            }
        }

        return reprobados; //cuando no hay void tenes que poner return
    }

    int MayorDistanciasDe100(int[] km)
    {
        int distancia = 0;

        for(int i = 0; i < km.Length; i++)
        {
            if(km[i] > 100)
            {
                distancia++;
            }
        }

        return distancia;
    }
}
