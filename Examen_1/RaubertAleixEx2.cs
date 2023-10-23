/*
 * Autor: Aleix Raubert Rusiñol
 * Data: 23/10/2023
 *  Implementa un programa que demani a l’usuari que 
 *  introdueixi dos números i retorno la suma de tots els valors que hi ha 
 *  entre ells. Els números introduïts per l’usuari no s’han d’incloure en la suma.
*/


using System;

namespace PrimeraProvaPractica;

class RaubertAleixCodeEx2
{
    static void Main()
    {
        /*Declaració de variables i constants.*/
        const string MSG_Welcome = "Introdueix dos nombres per a saber la suma dels nombres entre ells: ";
        const string MSG_Finish = "El resultat de la suma dels nombres és: ";

        int first_num, second_num, sum = 0, temp;

        Console.WriteLine(MSG_Welcome);

        /*Introducció dels dos nombres per teclat.*/

        first_num = Convert.ToInt32(Console.ReadLine());
        second_num = Convert.ToInt32(Console.ReadLine());

        if(second_num<first_num) /*Comprobacio per si el segon es més petit que el primer, per a cambiarlos d'ordre i que el bucli de abaix funcioni correctament.*/
        {
            temp= first_num;
            first_num= second_num;
            second_num= temp;
        }

        for (int i = first_num + 1; i < second_num; i++) sum += i; /*Bucle per calcular la suma entre els dos nombres, int i=first_num+1 ja que no esta inclos i i<second_num ja que tampoc esta inclos.*/

        Console.WriteLine(MSG_Finish + sum);
    }
}