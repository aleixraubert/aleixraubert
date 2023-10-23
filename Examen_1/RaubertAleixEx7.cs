/*
 * Autor: Aleix Raubert Rusiñol
 * Data: 23/10/2023
 *  Implementa en C# el següent disseny de solució en pseudocodi. Si hi ha alguna manera 
 *  d’optimitzar-la, aplica-la directament en el teu programa, comentant-la:
*/


using System;

namespace PrimeraProvaPractica;

class RaubertAleixCodeEx7 
{
    static void Main()
    {
        /*Declaració de constants i variables.*/
        const int DIVIDER = 2;
        const int ZERO = 0;

        const string UNEVEN = "És no parell";
        const string EVEN = "És parell";
        const string MSG_Welcome = "Introdueix un nombre per a saber si és parell o no: ";

        int num;

        Console.WriteLine(MSG_Welcome);

        /*Introducció del nombre per teclat.*/
        num=Convert.ToInt32(Console.ReadLine());

        /*Comproació si es parell o no.*/
        if (num%DIVIDER != ZERO) Console.WriteLine(UNEVEN);
        else Console.WriteLine(EVEN);

        /*No crec que hi hagi forma de optimitzar el programa, ja que només consta de un if amb una condició simple, i cualsevol modificació que facis, per tal de fer-ho de una altre manera implicaria fer ús de mínim una condició.*/
    }
}