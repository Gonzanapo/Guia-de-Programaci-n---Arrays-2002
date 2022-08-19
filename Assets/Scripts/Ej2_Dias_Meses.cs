using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ej2_Dias_Meses : MonoBehaviour
{

    [SerializeField] string[] nombresMeses = new string[12];
    [SerializeField] int[] diasMeses = new int[12];
    public string fechaIngresada;

    // Start is called before the first frame update
    void Start()
    {
        ValidarFormatoFecha(fechaIngresada);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* La regla es que sea un string de 4 caracters donde
     los dos primeros caracteres sean un número
     entre 01 y 31 y los dos últimos un número entre 01 y 12.*/
    bool ValidarFormatoFecha(string fecha)
    {
        bool fechaValida = false;

        if(fecha.Length == 4)
        {
            string dia = "";
            string mes = "";
            dia += fecha[0];
            dia += fecha[1];
            int diaNumber = int.Parse(dia);
            mes += fecha[2];
            mes += fecha[3];
            int mesNumber = int.Parse(mes);
            if( diaNumber > 0 && diaNumber <= 31 && mesNumber > 0 && mesNumber >=12)
            {
                fechaValida=true;
            }
        }
        else
        {
            Debug.Log("El largo de la fecha es incorrecto");
        }

        return (fechaValida);
    }
}
