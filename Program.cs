using System;

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
        /// <summary>
        /// Compara las opciones
        /// </summary>
        /// <param name="option">Es la opcion seleccionado por el jugadir</param>
        /// <param name="aiOption">Es la opcion seleccionado por el AI</param>
        static void CheckWinner(int option, int aiOption){
            if(option == 1 & aiOption == 2){  //Piedra vs Papel
                Console.WriteLine("Ai wins");
            }
            else if(option == 2 & aiOption == 3){ //Papel vs Tijeras
                Console.WriteLine("Ai wins");
            }
            else if(option == 3 & aiOption == 1){ // tijera vs piedra
                Console.WriteLine("Ai wins");

            }
                else if(option == aiOption){
                Console.WriteLine("Tie");
            }

            else{
                Console.WriteLine("Player wins");
            }
        }
        /// <summary>
        /// Selecciona aleatoriamente un opcion
        /// </summary>
        /// <returns> la computadora selecciona piedra papel o tijera</returns>
        static int SelectRandom()
        {
            Random rnd = new Random();
            int option = rnd.Next(1, 4);
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
            int aiOption = SelectRandom();
            Console.WriteLine("Opcion seleccionada aleatoriamente:" + aiOption);
            //TODO: Determinar quién ganó de acuerdo a las opciones seleccionadas, y mostrar al ganador

            CheckWinner(option, aiOption);
        }
    }
}
