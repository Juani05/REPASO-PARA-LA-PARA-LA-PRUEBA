using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej02 : MonoBehaviour
{
    public float precioproducto1;
    public float precioproducto2;
    public float precioproducto3;
    public float montodisponible;
    // Start is called before the first frame update
    void Start()
    {
        // 2.Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.
        float resta;
        float sumadeproductos;
        sumadeproductos = precioproducto1 + precioproducto2 + precioproducto3;
        resta = montodisponible - sumadeproductos; 
        if (sumadeproductos < montodisponible)
        {
            Debug.Log("La suma de productos no supera el monto disponible");
            Debug.Log("A usted le quedan $" + resta + " disponibles");
        }
        else
        {
            Debug.Log("La suma de productos supera el monto disponible");
            Debug.Log("Le faltan $" + resta*-1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
