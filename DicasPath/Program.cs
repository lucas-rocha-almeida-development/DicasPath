using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicasPath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\MinhaPasta\NewFolder\Arquivoteste.txt";// diretorio
            Console.WriteLine("PathSeparator " + Path.PathSeparator);// \ 
            Console.WriteLine("DirectorySeparatorChar " + Path.DirectorySeparatorChar);// separador ;
            Console.WriteLine("GetFileName " + Path.GetDirectoryName(path));//nome da pasta/subpasta
            Console.WriteLine("GetFileName " + Path.GetFileName(path));//nome e tipo do arquivo
            Console.WriteLine("GetFileNameWithoutExtension " + Path.GetFileNameWithoutExtension(path));//nome do arquivo
            Console.WriteLine("GetExtension " + Path.GetExtension(path));//tipo do arquivo
            Console.WriteLine("GetFullPath " + Path.GetFullPath(path));//imprimir todo diretorio - endereço
            Console.WriteLine("GetTempPath" + Path.GetTempPath());// pasta temporaria do sistema



        }
    }
}
