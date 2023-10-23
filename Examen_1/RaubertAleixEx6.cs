/*
 * Autor: Aleix Raubert Rusiñol
 * Data: 23/10/2023
 * Implementa un joc en el que el programa emmagatzemi un nombre i l’usuari hagi d’endevinar-lo. 
 * El programa haurà de donar pistes a l’usuari 
 * indicant si el nombre que ha introduït és massa alt, massa baix o l’ha encertat. 
 * L’usuari disposarà de 5 intents per encertar el número.
*/


using System;

namespace PrimeraProvaPractica;

class RaubertAleixCodeEx6 
{
    static void Main()
    {
        /*Declaració de constants i variables.*/
        const string MSG_Welcome = "El número secret ha sigut generat, tens 5 intents per endevinar-lo, endavant!";
        const string MSG_Higher = "El número secret és més gran!";
        const string MSG_Lower = "El número secret és més petit!";
        const string MSG_Win = "Enhorabona, has encertat el número secret!";
        const string MSG_Loss = "GAME OVER. T'has quedat sense intens, mala sort.";

        const int Secret_Number = 54, Max_Trys=5;

        int trys = 0, num;

        bool found = false;

        Console.WriteLine(MSG_Welcome);

        /*Bucle per al funcionament del joc, controlar per el número de intents inforiors a 5 i un boolea per a quan trobi el número correcte en cas de fer-ho.*/
        while(trys<Max_Trys && !found)
        {
            num=Convert.ToInt32(Console.ReadLine());

            if(num>Secret_Number) Console.WriteLine(MSG_Lower);
            else if(num<Secret_Number) Console.WriteLine(MSG_Higher);
            else
            {
                found = true;
            }
            trys++;
        }

        /*Comprobació per a saber si el jugador ha guanyat o ha perdut tots els intents, e imprimir el missatge corresponent en cada cas.*/
        if(found) Console.WriteLine(MSG_Win);
        else Console.WriteLine(MSG_Loss);
    }
}