/*
 * Autor: Aleix Raubert Rusiñol
 * Data: 23/10/2023
 * Implementa un programa que demani a l’usuari 5 números per teclat. El programa retornarà la mitjana de tots aquests nombres.
*/


using System;

namespace PrimeraProvaPractica;

class RaubertAleixCodeEx5
{
    static void Main()
    {
        /*Declaració de constants i variables.*/

        const string MSG_Welcome = "Introdueix 5 nombres per a obtenir la mitjana d'aquestos: ";
        const string MSG_Finish = "La mitjana és: ";

        const double total_nums = 5;

        double first_num, second_num, third_num, fourth_num, fifth_num, result;

        Console.WriteLine(MSG_Welcome);

        /*Introducció dels nombres per teclat.*/

        first_num = Convert.ToDouble(Console.ReadLine());
        second_num = Convert.ToDouble(Console.ReadLine());
        third_num = Convert.ToDouble(Console.ReadLine());
        fourth_num = Convert.ToDouble(Console.ReadLine());
        fifth_num = Convert.ToDouble(Console.ReadLine());

        result = first_num + second_num + third_num + fourth_num + fifth_num; /*Suma de tots els valors.*/

        result /= total_nums; /*Divisió per calcular la mitjana.*/

        Console.WriteLine(MSG_Finish + result);
    }
}