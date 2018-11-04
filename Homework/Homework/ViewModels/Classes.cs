using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ViewModels
{
    
    class Classes
    {
        public string Derslik { get; set; }
        public string Kapasite { get; set; }
        public string Resim { get; set; }

        public Classes(string Derslik, string Kapasite,string Resim) {
            this.Derslik = Derslik;
            this.Kapasite = Kapasite;
            this.Resim = Resim;
        }
       
    }
}
