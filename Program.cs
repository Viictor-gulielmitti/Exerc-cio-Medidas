using System;

namespace MEDIDAS
{
    class Program
    {
        static void Main(string[] args)
        {
            string  entrada ;
            MEDIDAS centimetros , quilometros, metros ;

           
            Console.WriteLine ( " Digite a medida em metros: " );
            entrada  =  Console.ReadLine ();
            medidas  =  Convert.ToDouble ( entrada );
            centimetros  =  metros  *  100 ;
            quilometros  =  metros  /  100 ;
            
            Console. ForegroundColor = ConsoleColor.Cyan; 
            Console.WriteLine ( " \n Equivalência" );
            Console.WriteLine ($" { centimetros } cm " );
            Console.WriteLine ($" { metros } m " );
            Console.WriteLine ($" { quilometros  } km " );
            ;
    }
}
