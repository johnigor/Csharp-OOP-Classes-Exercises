using System;
using ProblemaDoDiamante.Devices;

namespace ProblemaDoDiamante
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Herança múltipla e o problema do diamante:
            
            A herança múltipla pode gerar o probelma do diamante: uma ambiguidade causada pela existência
            do mesmo método em mais de uma superclasse

            Herança múltipla não é permitida na maioria das linguagens
            */


            //Instanciando a impressora
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
