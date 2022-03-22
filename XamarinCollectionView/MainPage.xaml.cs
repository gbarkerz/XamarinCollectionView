using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinCollectionView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var items = new ObservableCollection<TestItem>();

            var item = new TestItem();
            item.Name = "Tree";
            items.Add(item);

            item = new TestItem();
            item.Name = "Bird";
            items.Add(item);

            item = new TestItem();
            item.Name = "Fish";
            items.Add(item);

            item = new TestItem();
            item.Name = "River";
            items.Add(item);

            TestCollectionView.ItemsSource = items;
        }
    }

    public class TestItem
    {
        public string Name { get; set; }
    }
}
