﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ08 : MonoBehaviour
{
//    Crear una variable entera que pueda ser modificada desde el Inspector.Suponiendo que
//el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente al
//valor de la variable “dia”. Si el día no está en el rango permitido debe emitir por pantalla el
//mensaje de error "El día ingresado no es válido".
    // Start is called before the first frame update
    public int dia = 1;
    void Start()
    {
        switch (dia)
        {
            case 1:
           Debug.Log("Es domingo");
                break;

            case 2:
                Debug.Log("Es lunes");
                break;
            case 3:
                Debug.Log("Es martes");
                break;
            case 4:
                Debug.Log("Es miercoles");
                break;
            case 5:
                Debug.Log("Es jueves");
                break;
            case 6:
                Debug.Log("Es viernes");
                break;
            case 7:
                Debug.Log("Es sabado");
                break;
            default:
                Debug.Log("El dia ingresado no es valido");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
