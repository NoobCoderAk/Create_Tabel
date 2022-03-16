﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Create_Tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.CreateTabel();
        }

        public void CreateTabel()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-4U0SN21\\ABIDAKBAR;DATABASE=ProdiTI;Integrated Security = TRUE");
                con.Open();

                SqlConnection cm = new SqlConnection("create table Mahasiswa_Coba (NIM char(12) not null primary key, Nama Varchar(50), Alamat varchar(255), Jenis_Kelamin char(1))");
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel sukses dibuat!");
                Console.ReadKey();
            } catch (Exception e)
            {
                Console.WriteLine("Oops, Sepertinya ada yang salah. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }

        }
    }
}
