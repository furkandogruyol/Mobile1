using Homework.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Homework.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Altyapi : ContentPage
    {
        public Altyapi()
        {
            List<Classes> classes = new List<Classes>(); 
            InitializeComponent();
            

            classes.Add(new Classes("Derslik-B1", "Kapasite: 36", "http://ceng.eskisehir.edu.tr/Documents/Class_B1_icon.jpg"));
            classes.Add(new Classes("Derslik-B2", "Kapasite: 15", "http://ceng.eskisehir.edu.tr/Documents/Class_B2_icon.jpg"));
            classes.Add(new Classes("Derslik-B3", "Kapasite: 18", "http://ceng.eskisehir.edu.tr/Documents/Class_B3_icon.jpg"));
            classes.Add(new Classes("Derslik-B4", "Kapasite: 24", "http://ceng.eskisehir.edu.tr/Documents/Class_B4_icon.jpg"));
            classes.Add(new Classes("Derslik-B5", "Kapasite: 15", "http://ceng.eskisehir.edu.tr/Documents/Class_B5_icon.jpg"));
            classes.Add(new Classes("Derslik-B6", "Kapasite: 24", "http://ceng.eskisehir.edu.tr/Documents/Class_B6_icon.jpg"));
            classes.Add(new Classes("Derslik-B7", "Kapasite: 54", "http://ceng.eskisehir.edu.tr/Documents/Class_B7_icon.jpg"));
            classes.Add(new Classes("Lab-01", "Kapasite: 61", "http://ceng.eskisehir.edu.tr/Documents/Lab_PC1_icon.jpg"));
            classes.Add(new Classes("Lab-02", "Kapasite: 24", "http://ceng.eskisehir.edu.tr/Documents/Lab_Mac1_icon.jpg"));
            listView.ItemsSource = classes;
        }

        }
    }
