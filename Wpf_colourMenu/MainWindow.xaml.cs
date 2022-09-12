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

namespace Wpf_colourMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int index = 0;
        public ColorRGB mcolor { get; set; }
        public Color clr { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            mcolor = new ColorRGB();
            mcolor.red = 0;
            mcolor.green = 0;
            mcolor.blue = 0;
        }
        public class ColorRGB
        {
            public byte red { get; set; }
            public byte green { get; set; }
            public byte blue { get; set; }           
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {    
            var slider = sender as Slider;
            string crlName = slider.Name;          
            double value = slider.Value; 
            if (crlName.Equals("RedColor"))
            {
                lblRed.Content = Convert.ToString(slider.Value);
                mcolor.red = Convert.ToByte(value);
            }
            if (crlName.Equals("GreenColor"))
            {
                lblGreen.Content = Convert.ToString(slider.Value);
                mcolor.green = Convert.ToByte(value);
            }
            if (crlName.Equals("BlueColor"))
            {
                lblBlue.Content = Convert.ToString(slider.Value);
                mcolor.blue = Convert.ToByte(value);
            }
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.sel_colour.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            RedColor.IsEnabled = false;
        }

        private void GreenCheck_Checked(object sender, RoutedEventArgs e)
        {
            GreenColor.IsEnabled = false;
        }

        private void BlueCheck_Checked(object sender, RoutedEventArgs e)
        {
            BlueColor.IsEnabled = false;
        }

        private void RedCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            RedColor.IsEnabled = true;
        }

        private void GreenCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            GreenColor.IsEnabled = true;
        }

        private void BlueCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            BlueColor.IsEnabled = true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*ListBox1.Items.Add(sel_colour.Background);*/ // #F4304023
            Button b1 = new Button();
            b1.Content = "Удалить";
            ListBoxItem myListBoxItem = new ListBoxItem();
            ListBoxItem col = new ListBoxItem();
            col.Content = "                                                    ";
            col.Foreground = sel_colour.Background;
            col.Background = sel_colour.Background;
            myListBoxItem.Content = b1;         
            ListBox1.Items.Add(sel_colour.Background);
            ListBox1.Items.Add(col);
            ListBox1.Items.Add(myListBoxItem);          
            b1.Click += b1_Click;
        }
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Кнопка не доступна");
            //this.b2.IsEnabled = false;        

            //ListBox1.Items.RemoveAt();

            //for (int i = 0; i < ListBox1.Items.Count; i++)
            //{
            //    //MessageBox.Show(Convert.ToString(ListBox1.Items[i]));
            //    if ("System.Windows.Controls.ListBoxItem: Удалить" == Convert.ToString(ListBox1.Items[i]))
            //    {
            //    }
            //}

            //ListBox1.SelectedItem = this.b1;
            //index = ListBox1.SelectedIndex;
            //MessageBox.Show(Convert.ToString(index));
        }
    }
}
