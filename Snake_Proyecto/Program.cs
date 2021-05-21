using Snake_Proyecto.BaseDatos;
using Snake_Proyecto.Estructura_No._1;
using Snake_Proyecto.Estructura_No._2;
using Snake_Proyecto.Estructura_No._3;
using Snake_Proyecto.Estructura_No._4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Proyecto
{
    class Program
    {

        public void metodo()
        {
            int a;
            int opcion;
            do
            {
                Console.WriteLine("ELIJA CON QUE ESTRUCTURA JUGAR SNAKE");
                Console.WriteLine("1. BiCola");
                Console.WriteLine("2. ColaCircular");
                Console.WriteLine("3. ColaLineal");
                Console.WriteLine("4. ColaConLista");
                Console.WriteLine("5. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {

                    case 1:
                        Culebrita1 snake1 = new Culebrita1();
                        snake1.Ejercicio1();
                        break;
                    case 2:
                        Culebrita2 snake2 = new Culebrita2();
                        snake2.Ejercicio2();
                        break;
                    case 3:
                        Culebrita3 snake3 = new Culebrita3();
                        snake3.Ejercicio3();
                        break;
                    case 4:
                        Culebrita4 snake4 = new Culebrita4();
                        snake4.Ejercicio4();
                        break;
                }

                //Console.SetCursorPosition(10, 30);
                // Console.Write($"Puntuación: {punteo.ToString("00000000")}");
                // Console.Write("Desea jugar 1=Si- 2=No");
                //  a = int.Parse(Console.ReadLine());
                //// a = int.Parse(Console.ReadLine());
                Console.ReadLine();

                Console.Clear();
            } while (opcion != 5);


        }

        static void Main(string[] args)
        {
            bool ejecutar = false;

            for (int k = 0; ;)
            {
                DibujaMenu(k);
                ConsoleKeyInfo cki = Console.ReadKey(true);

                switch (cki.Key)
                {

                    case ConsoleKey.UpArrow: k--; break;
                    case ConsoleKey.DownArrow: k++; break;
                    case ConsoleKey.Enter: ejecutar = true; break;
                        

                }

                Console.Beep(659,5);
                if (k < 0) k = 4; else if (k > 4) k = 0;

                if (ejecutar)
                {
                    ejecutar = false;
                    Console.Clear();
                    switch (k)
                    {
                        
                        case 0: Opcion1(); break;
                        case 1: Opcion2(); break;
                        case 2: Opcion3(); break;
                        case 3: Opcion4(); break;
                        case 4: return;
                    }
                }
            }

        }

        static void Opcion1()
        {
            Console.SetCursorPosition(5, 15);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Culebrita1 snake1 = new Culebrita1();
            snake1.Ejercicio1();
        }

        static void Opcion2()
        {
            Console.SetCursorPosition(5, 15);
            Console.ForegroundColor = ConsoleColor.Green;
            Culebrita2 snake2 = new Culebrita2();
            snake2.Ejercicio2();
        }
        static void Opcion3()
        {
            Console.SetCursorPosition(5, 15);
            Console.ForegroundColor = ConsoleColor.Green;
            Culebrita3 snake3 = new Culebrita3();
            snake3.Ejercicio3();
        }
        static void Opcion4()
        {
            Console.SetCursorPosition(5, 15);
            Console.ForegroundColor = ConsoleColor.Green;
            Culebrita4 snake4 = new Culebrita4();
            snake4.Ejercicio4();
        }

        static void DibujaMenu(int k)
        {
            ConsoleColor cc = ConsoleColor.DarkYellow;
            ConsoleColor sel = ConsoleColor.Red;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(5, 5);
            Console.ForegroundColor = k == 0 ? sel : cc;
            Console.WriteLine("1. BiCola");
            Console.SetCursorPosition(5, 7);
            Console.ForegroundColor = k == 1 ? sel : cc;
            Console.WriteLine("2. ColaCircular");
            Console.SetCursorPosition(5, 9);
            Console.ForegroundColor = k == 2 ? sel : cc;
            Console.WriteLine("3. ColaLineal");
            Console.SetCursorPosition(5, 11);
            Console.ForegroundColor = k == 3 ? sel : cc;
            Console.WriteLine("4. ColaConLista");
            Console.SetCursorPosition(5, 13);
            Console.ForegroundColor = k == 4 ? sel : cc;
            Console.WriteLine("5. Salir");
        }
    }
}
