using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFechas
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos una variable de tipo cadena o palabra
            string dia = "";
            //Obtenemos la fecha de la computadora
            DateTime fecha = DateTime.Parse(DateTime.Now.ToShortDateString());
            //Obtenemos solo el dia de la semana de la fecha de la computadora
            dia = fecha.ToString("dddd");
            //mostramos la fecha completa y el dia de la computadora
            Console.WriteLine(fecha);
            Console.WriteLine(dia);
            //declaramos una variable de tipo numero real con decimales
            double costo = 0;
            //preguntamos en un switch que dia es hoy y de esta manera darle el valor del la variable costo
            //No olvides que los dias tienen acento para iogual al sistema de computadora, á, é, í, ó, ú.
            switch (dia)
            {
                case "domingo": costo = 2;break;
                case "lunes":
                case "martes":
                case "miércoles":
                case "jueves": costo = 4; break;
                case "viernes":
                case "sabado":costo = 7; break;
            }
            //mostramos el valor de costo, tomando en cuenta el dia de la semana
            Console.WriteLine(costo.ToString("C"));
            Console.ReadKey();
        }
    }
}
