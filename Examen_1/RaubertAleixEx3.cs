/*
 * Autor: Aleix Raubert Rusiñol
 * Data: 23/10/2023
 * Implementa un programa que mostri la taula de multiplicar d’un número introduït per l’usuari.
*/


using System;

namespace PrimeraProvaPractica;

class RaubertAleixCodeEx3 
{
    static void Main() 
    {
        /* Declaració de variables i constants.*/

        const string MSG_Welcome = "Introdueix un nombre per a obtenir la seva taula de multiplicar: ";

        int num, max_mult=10;

        Console.WriteLine(MSG_Welcome);

        /*Introducció del nombre per teclat.*/

        num=Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= max_mult; i++) Console.WriteLine(i + " * " + num + " = " + i * num); /*Bucle per imprimir per pantalla la taula de multiplicar.*/
    }
}