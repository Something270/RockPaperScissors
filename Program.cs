﻿using System;

namespace RockPaperScissors
{
    class Program
    {
        /// <summary>
        /// Solicita al usuario una opcion a jugar
        /// </summary>
        /// <returns>La opcion seleccionada: 1 - piedra, 2 - papel, 3 - tijera</returns>
        static int SelectOption()
        {
            Console.WriteLine("Selecciona la opcion a jugar:");
            Console.WriteLine("1) Piedra");
            Console.WriteLine("2) Papel");
            Console.WriteLine("3) Tijera");

            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
        static void Main(string[] args)
        {
           int option = SelectOption();
           //TODO: Seleccionar opción a jugar (piedra, papel o tijera)
           // 1: piedra
           // 2: papel
           // 3: tijera
           Console.WriteLine("Opcion Seleccionada: " + option);

           //TODO: La computadora genera su opción a jugar de manera aleatoria (piedra, papel o tijera)
           //TODO: Determinar quién ganó de acuerdo a las opciones seleccionadas, y mostrar al ganador
           //TODO: Jugar 3 partidas, y mencionar quién ganó al final (jugador o computadora)
        }
    }
}
