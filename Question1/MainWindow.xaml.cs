using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Question1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int Search<T>(T[] arr, T key) where T : IComparable<T>
        {
            for(int index = 0; index < arr.Length; index++)
            {
                if (arr[index].CompareTo(key) == 0) return index;
            }
            return -1;   
        }

        public void ButtonGenerateRandomIntegers_Click(object sender, RoutedEventArgs e)
        {
            int arrLength = 20; // generate 20 random integer numbers
            int[] arrInt = new int[arrLength]; 
            Random random = new Random();
            for(int i = 0; i < arrLength; i++)
                arrInt[i] = random.Next();

            dataGrid.ItemsSource = arrInt;
            SearchKeyTextBox.Text = null;
            SearchResult.Text = null;
        }

        private void ButtonGenerateRandomDoubles_Click(object sender, RoutedEventArgs e)
        {
            int arrLength = 20; // generate 20 random double numbers
            double[] arrDouble = new double[arrLength];
            Random random = new Random();
            for (int i = 0; i < arrLength; i++)
                arrDouble[i] = Math.Round(random.NextDouble(), 15);

            dataGrid.ItemsSource = arrDouble;
            SearchKeyTextBox.Text = null;
            SearchResult.Text = null;
        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {   
            Array n = dataGrid.ItemsSource as Array;
            Type t = n.GetType();
            
            if(t == typeof(Int32[]))
            {
                SearchResult.Text = $"Index of '{SearchKeyTextBox.Text}': " 
                    + Search(n as int[], int.Parse(SearchKeyTextBox.Text)).ToString();
            }
            else if(t == typeof(Double[]))
            {
                SearchResult.Text = $"Index of '{SearchKeyTextBox.Text}': " 
                    + Search(n as double[], double.Parse(SearchKeyTextBox.Text)).ToString();
            }
        }
    }
}
