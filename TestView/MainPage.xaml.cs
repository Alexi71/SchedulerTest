using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestView.Model;
using Xamarin.Forms;

namespace TestView
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            barItem.Clicked += (sender, e) =>
            {
                schedule.MoveToDate = DateTime.Now;
            };

        }

        //void listView_ItemTapped(System.Object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        //{
        //    var item = e.ItemData as BookInfo;
        //    DisplayAlert("Info", item.BookName, "Cancel");

        //}

        //void listView_ItemDoubleTapped(System.Object sender, Syncfusion.ListView.XForms.ItemDoubleTappedEventArgs e)
        //{
        //    var item = e.ItemData as BookInfo;
        //    DisplayAlert("Info", item.BookName, "Cancel");
        //}
    }
}
