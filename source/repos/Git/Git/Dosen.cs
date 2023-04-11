using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Git
{
    public class Dosen
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public int Nik { get; set; }
        public string Gender { get; set; }
        public string Course { get; set; }

        public Dosen(int id, string nama, int nik, string gender, string course)
        {
            Id = id;
            Nama = nama;
            Nik = nik;
            Gender = gender;
            Course = course;
        }

        public void display()
        {
            Console.WriteLine("Id : "+ Id);
            Console.WriteLine("Name :" +  Nama);
            Console.WriteLine("Nik : " + Nik);
            Console.WriteLine("Gender : " + Gender);
            Console.WriteLine("Course : " + Course);
        }

        public void attDosen(string name,int nik)
        {
            Nama = name;
            Nik = nik;
        }

        public void addCourse(string newCourse)
        {
            Course += ", " + newCourse;
        }

        
    }
}
