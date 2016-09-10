using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BackgroundGenerator
{
    /// <summary>
    /// Interaction logic for GeneratorWindow.xaml
    /// </summary>
    public partial class GeneratorWindow : Window
    {
        public GeneratorWindow()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            //This is going to call up a database and then randomly pick a set of name components to combine
        }

        private void MutateButton_Click(object sender, RoutedEventArgs e)
        {
            //This calls the name mutator to do a random change to the name based on linguistic rules.
        }
    }
}