/*
 * Autor: Aleix Raubert Rusiñol
 * Data: 23/10/2023
 * Implementa un programa mostri els valors desde 1 fins al número introduït per l’usuari.
*/


using System;

namespace PrimeraProvaPractica;

class RaubertAleixCodeEx4 
{
    static void Main() 
    {
        /*Declaració de constants i variables.*/

        const string MSG_Welcome = "Introdueix un nombre per a obtenir els valor de 1 a n: ";

        int num;

        Console.WriteLine(MSG_Welcome);

        /*Declaració del nombre per teclat.*/

        num=Convert.ToInt32(Console.ReadLine());

        if(num==0) Console.WriteLine(num); /*Comprobació per si el número és 0, ja que comencem a imprimir desde el 1.*/
        else
        {
            for (int i = 1; i <= num; i++) Console.WriteLine(i); /*Bucle per imprimir per pantalla tots els nombres de 1 al nombre introduit.*/
        }
    }
}