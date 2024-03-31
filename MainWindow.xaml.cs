using System;
using System.Windows;
using System.Windows.Controls;


namespace CalculatorApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                currentTextBox.Text += button.Content.ToString();
            }
        }

        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                currentTextBox.Text += button.Content.ToString();
            }
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            currentTextBox.Text = "";
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            currentTextBox.Text = "";
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (currentTextBox.Text.Length > 0)
            {
                currentTextBox.Text = currentTextBox.Text.Substring(0, currentTextBox.Text.Length - 1);
            }
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = new System.Data.DataTable().Compute(currentTextBox.Text, null);
                currentTextBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                currentTextBox.Text = "Error";
            }
        }
    }
}
