﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ10 : MonoBehaviour
{
    // Start is called before the first frame update
    //    10. Realizá un programa que resuelva el siguiente problema: Nos piden desarrollar un
    //programa que informe si un estacionamiento se encuentra o no abierto según la hora
    //ingresada por el usuario.
    //Nosotros sabemos que el estacionamiento se encuentra abierto entre las 10 y las 18hs.
    //(Crear constante HoraApertura = 10, y HoraCierre = 18).
    //Al iniciar el programa, se tomará como hora actual el valor de una variable expuesta en el
    //Inspector, y deberemos setear una variable booleana llamada estaAbierto en true o false,
    //según corresponda, e informar por pantalla mediante la misma si el estacionamiento se
    //encuentra abierto o no.Obs: En el caso de que el valor de la variable correspona a una hora
    //menor a 0 o mayor a 24, mostrar el mensaje: “Ha ingresado una hora incorrecta”

    public const int HoraApertura = 10;
    public const int HoraCierre = 18;
    public int horaActual;
    bool estaAbierto;
    void Start()
    {
        if (horaActual > 24 || horaActual < 0 )
        {
            Debug.Log("Ha ingresado una hora incorrecta");
        }
        else if (horaActual >= HoraApertura || horaActual <= HoraCierre)
        {
            estaAbierto = true;
            Debug.Log("Estacionamient abierto: " + estaAbierto);
        }

        else if (horaActual > HoraCierre)
        {
            estaAbierto = false;
            Debug.Log("Estacionamiento abierto: " + estaAbierto);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
