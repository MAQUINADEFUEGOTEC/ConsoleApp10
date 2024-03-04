using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2_Banco
{
    internal class CuentaBancaria
    {
        private int NumCuenta;
        private int Saldo;
        private string Nombre;

        public CuentaBancaria(int numCuenta, int saldo, string nombre)
        {
            NumCuenta = numCuenta;
            Saldo = saldo;
            Nombre = nombre;
        }

        public void Operacion()
        {
            Console.WriteLine("Que operacion deseas realizar");
            Console.WriteLine("1(Retirar)");
            Console.WriteLine("2(Depositar)");
            Console.WriteLine("3(Consultar saldo)");
            int opcion = 0;
            Console.WriteLine(" ");
            opcion = int.Parse(Console.ReadLine());

            int saldo = Saldo;
            int reti = 0, resta = 0, depo = 0, suma = 0;
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Retirar");
                    reti = int.Parse(Console.ReadLine());
                    resta = saldo - reti;
                    Console.WriteLine("Su saldo ahora es: " + resta);
                    break;
                case 2:
                    Console.WriteLine("Depositar");
                    depo = int.Parse(Console.ReadLine());
                    suma = saldo + depo;
                    Console.WriteLine("Su saldo aumento a: " + suma);
                    break;
                case 3:
                    Console.WriteLine("Consultar saldo");
                    Console.WriteLine("Su saldo es de " + saldo);

                    break;
                default:
                    Console.WriteLine("Esa operacion no existe!");
                    break;
            }

        }
    }
}