using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practic_8_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double[] length_list,height_list;
        int counter=0;
        Shape[] shapes = new Shape[1];
        private void Add_item_button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            counter++;
            Array.Resize(ref shapes, counter);
           
            if (Square_radiobutton.IsChecked == true)
            {
                Square square = new Square();
                square.length = (float)(random.NextDouble() * 100);
                shapes[counter-1] = square;
            }
            else
            {
                Triangle triangle = new Triangle();
                triangle.length = (float)random.NextDouble() * 100;
                triangle.height = (float)(random.NextDouble() * 100);
                shapes[counter-1] = triangle;
            }
        }
        private void button_Show_list_Click(object sender, RoutedEventArgs e)
        {
            showing_Items_TextBlock.Text = null;
            Shape current_item;
            for (int i = 0; i < counter; i++)
            {
                current_item = shapes[i];
                showing_Items_TextBlock.Text += "Item " + (i + 1) +" "+ current_item.ToString()+  " \n";
            }
        }
        private void calculate_areas_button_Click(object sender, RoutedEventArgs e)
        {
            Shape current_item;
            for (int i = 0; i < counter; i++)
            {
                current_item = shapes[i];
                showing_Area_TextBlock.Text += "Item " + (i+1) + " Area: " + current_item.Area() + " \n";
            }
        }
        private void Terminator_button_click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}