using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace C__Sprint1_Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            GenerateCode();
            AddColor();
        }

        private void GenerateCode()

        {
            Random code = new Random();
            const int numberOfColorsCode = 4;
            const int minNumber = 1;
            const int maxNumber = 7;
            int colorRed = 1;
            int colorYellow = 2;
            int colorOrange = 3;
            int colorWhite = 4;
            int colorGreen = 5;

            for (int i = 1; i <= numberOfColorsCode; i++)
            {
                int colorCode = code.Next(minNumber, maxNumber);
                if (colorCode == colorRed)
                {
                    this.Title += " Red";
                }
                else if (colorCode == colorYellow)
                {
                    this.Title += " Yellow";
                }
                else if (colorCode == colorOrange)
                {
                    this.Title += " Orange";
                }
                else if (colorCode == colorWhite)
                {
                    this.Title += " White";
                }
                else if (colorCode == colorGreen) 
                {
                    this.Title += " Green";
                }
                else
                {
                    this.Title += " Blue";
                }
            }
        }
        private void AddColor()
        {
            comboBox1.Items.Add(new SolidColorBrush(Colors.Red));
            comboBox1.Items.Add(new SolidColorBrush(Colors.Yellow));
            comboBox1.Items.Add(new SolidColorBrush(Colors.Orange));
            comboBox1.Items.Add(new SolidColorBrush(Colors.White));
            comboBox1.Items.Add(new SolidColorBrush(Colors.Green));
            comboBox1.Items.Add(new SolidColorBrush(Colors.Blue));

            comboBox2.Items.Add(new SolidColorBrush(Colors.Red));
            comboBox2.Items.Add(new SolidColorBrush(Colors.Yellow));
            comboBox2.Items.Add(new SolidColorBrush(Colors.Orange));
            comboBox2.Items.Add(new SolidColorBrush(Colors.White));
            comboBox2.Items.Add(new SolidColorBrush(Colors.Green));
            comboBox2.Items.Add(new SolidColorBrush(Colors.Blue));

            comboBox3.Items.Add(new SolidColorBrush(Colors.Red));
            comboBox3.Items.Add(new SolidColorBrush(Colors.Yellow));
            comboBox3.Items.Add(new SolidColorBrush(Colors.Orange));
            comboBox3.Items.Add(new SolidColorBrush(Colors.White));
            comboBox3.Items.Add(new SolidColorBrush(Colors.Green));
            comboBox3.Items.Add(new SolidColorBrush(Colors.Blue));

            comboBox4.Items.Add(new SolidColorBrush(Colors.Red));
            comboBox4.Items.Add(new SolidColorBrush(Colors.Yellow));
            comboBox4.Items.Add(new SolidColorBrush(Colors.Orange));
            comboBox4.Items.Add(new SolidColorBrush(Colors.White));
            comboBox4.Items.Add(new SolidColorBrush(Colors.Green));
            comboBox4.Items.Add(new SolidColorBrush(Colors.Blue));
        }
    }
} 
        
            
        
    


