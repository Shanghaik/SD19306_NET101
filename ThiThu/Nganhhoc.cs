﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu
{
    internal class Nganhhoc
    {
        int id; string ten; int sokihoc; // Bước 1
        public Nganhhoc()// ctor tab tab
        {
        }
        public Nganhhoc(int id, string ten, int sokihoc) // Bôi đen xong ctrl . => generate constructor
        {
            this.Id = id;
            this.Ten = ten;
            this.Sokihoc = sokihoc;
        }
        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Sokihoc { get => sokihoc; set => sokihoc = value; }

        public void InThongTin()
        {
            Console.WriteLine($"ID: {Id}, Tên: {Ten}, Số kì: {Sokihoc}");
        }
    }
}
