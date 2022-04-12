using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public string producto1;
    public string producto2;
    public string producto3;
    public float precioP1;
    public float precioP2;
    public float precioP3;
    public int cantP1;
    public int cantP2;
    public int cantP3;
    float totalSinD;
    float Descuento1;
    float Descuento2;
    float Descuento3;
    float montoT;
    float total;


    void Start()
    {
        if (precioP1 <= 0 || precioP2 <= 0 || precioP3 <= 0 || cantP1 <= 0 || cantP2 <= 0 || cantP3 <= 0)
        {
            Debug.Log("Se a producido un error, esto puede haber ocurrido porque el precio o la cantidad de algun producto sea menor o equivalente a cero");
        }
        else
        {
            totalSinD = precioP1 + precioP2 + precioP3;
            Debug.Log("Monto total sin descuento: $" + totalSinD);
            if (cantP1 > 3)
            {
                Descuento1 = (precioP1 * 0.2f);
                Debug.Log("Descuento para el producto 1: $" + Descuento1);
            }
            else if (cantP1 <= 3 && cantP1 > 0)
            {
                Debug.Log("Descuento para el producto 1: $0");
            }

            if (cantP2 > 3)
            {
                Descuento2 = (precioP2 * 0.2f);
                Debug.Log("Descuento para el producto 2: $" + Descuento2);
            }
            else if (cantP2 <= 3 && cantP2 > 0)
            {
                Debug.Log("Descuento para el producto 2: $0");
            }

            if (cantP3 > 3)
            {
                Descuento3 = (precioP3 * 0.2f);
                Debug.Log("Descuento para el producto 3: $" + Descuento3);
            }
            else if (cantP3 <= 3 && cantP3 > 0)
            {
                Debug.Log("Descuento para el producto 3: $0");
            }

            montoT = Descuento1 + Descuento2 + Descuento3;
            Debug.Log("El monto de los descuentos aplicados es de $" + montoT);

            total = totalSinD - montoT;
            Debug.Log("El total a pagar es de $" + total);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
