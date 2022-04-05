using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Realizá un programa que resuelva el siguiente problema:
//Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje del
//total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
//por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
//mostrar lo pedido en el siguiente formato:
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….
public class EJ09 : MonoBehaviour
{
    public float p1;
    public float p2;
    public float p3;
    float total;
    public string nombre1;
    public string nombre2;
    public string nombre3;
    void Start()
    {
        total = p1 + p2 + p3;
        Debug.Log(nombre1 + " aporto " + p1 + "$ de capital, el porcentaje es " + (total/100 *p1) + " y el monto total es " + total + "$");
        Debug.Log(nombre2 + " aporto " + p2 + "$ de capital, el porcentaje es " + (total / 100 * p2) + " y el monto total es " + total + "$" );
        Debug.Log(nombre2 + " aporto " + p3 + "$ de capital, el porcentaje es " + (total / 100 * p3) + " y el monto total es " + total + "$" );

    }

}
