/*
 Muhammad Taufiq Al Fauzi || 22.11.5338
 M. Hafiz Muhandzib || 22.11.5350
Charli Marsilino Jitmau || 22.11.5368
Rizal ARVIAN || 22.11.5332
AHMAD ILMAN HUDA || 22.11.5336
 
 
 
 */


using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;

namespace Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Dosen dosen = new Dosen(1,"Dosen Pengampu",123,"laki-laki","Mata Kuliah");
            Console.WriteLine("Default Dosen Pengampu:");
            dosen.display();

            Console.WriteLine("\nMasukan Nama dan NIK Dosen Baru:");
            dosen.attDosen(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("\nMasukan Mata Kuliah Baru:");
            dosen.addCourse(Console.ReadLine());
            dosen.display();

            Console.ReadLine();
        }
    }
}