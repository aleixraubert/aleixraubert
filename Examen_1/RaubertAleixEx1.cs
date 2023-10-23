/*
 * Autor: Aleix Raubert Rusiñol
 * Data: 23/10/2023
 *  Implementa un programa que demani a l’usuari tres números i mostri per 
 *  pantalla quin dels tres és més gran o si són iguals. Important! Ha d’informar 
 *  quin número és el més gran (ordre d’entrada, no el valor introduït).
*/


using System;

namespace PrimeraProvaPractica;

class RaubertAleixCodeEx1 
{
    static void Main() 
    {
        /*Definició de constants i variables.*/
        const string MSG_First_Number = "El més gran és el primer número.";
        const string MSG_Second_Number = "El més gran és el segon número.";
        const string MSG_Third_Number = "El més gran és el tercer número.";
        const string MSG_Equal = "Els tres números són iguals.";

        int first_num, second_num, third_num;

        /*Entrada de les variables per teclat.*/

        first_num=Convert.ToInt32(Console.ReadLine());
        second_num=Convert.ToInt32(Console.ReadLine());
        third_num=Convert.ToInt32(Console.ReadLine());


        if (first_num == second_num && second_num == third_num) /*Comprobació si son iguals*/
        {
            Console.WriteLine(MSG_Equal);
        }
        else /*En cas de no ser iguals comprobar quin és més gran.*/
        {
            if (first_num > second_num)
            {
                if (first_num > third_num) Console.WriteLine(MSG_First_Number);
                else if (third_num > second_num) Console.WriteLine(MSG_Third_Number);
                else Console.WriteLine(MSG_Second_Number);
            }
            else if (second_num > third_num) Console.WriteLine(MSG_Second_Number);
            else Console.WriteLine(MSG_Third_Number);
        }
    }
}