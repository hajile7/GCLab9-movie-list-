﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab9__movie_database_
{
    internal class Movies
    {
        //properties
        public string title {  get; set; }
        public string category { get; set; }
        public int year { get; set; }

        //constructor 
        public Movies(string _title, string _category, int _year)
        {
            title = _title;
            category = _category;
            year = _year;
        }

        //methods

    }
}
