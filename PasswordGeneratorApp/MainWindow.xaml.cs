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

namespace PasswordGeneratorApp
{
    public partial class MainWindow : Window
    {
        private string lowercase = "abcdefghijklmnoprstuvwqxyz";
        private string uppercase = "ABCDEFGHIJKLMNOPRSTUVWQXYZ";
        private string numbers = "1234567890";
        private string specials = "!@#$%^&*()-_=+:;<>,./}{[]";
        private string characters = "";
        private int indexOfChars;
        private int id;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SmallLetters_Checked(object sender, RoutedEventArgs e)        
        {
            characters += lowercase;
        }
        private void smallLetters_Unchecked(object sender, RoutedEventArgs e)
        {
            
            if (characters.Contains(lowercase))
            {
                indexOfChars = characters.IndexOf(lowercase);
                characters = characters.Remove(indexOfChars, lowercase.Length);
            }
        }

        private void BigLetters_Checked(object sender, RoutedEventArgs e)
        {
            characters += uppercase;
        }

        private void BigLetters_Unchecked(object sender, RoutedEventArgs e)
        {
            if (characters.Contains(uppercase))
            {
                indexOfChars = characters.IndexOf(uppercase);
                characters = characters.Remove(indexOfChars, uppercase.Length);
            }
        }

        private void Numbers_Checked(object sender, RoutedEventArgs e)
        {
            characters += numbers;
        }

        private void Numbers_Unchecked(object sender, RoutedEventArgs e)
        {
            if (characters.Contains(numbers))
            {
                indexOfChars = characters.IndexOf(numbers);
                characters = characters.Remove(indexOfChars, numbers.Length);
            }
        }

        private void SpedcialChars_Checked(object sender, RoutedEventArgs e)
        {
            characters += specials;
        }

        private void SpecialChars_Unchecked(object sender, RoutedEventArgs e)
        {
            if (characters.Contains(specials))
            {
                indexOfChars = characters.IndexOf(specials);
                characters = characters.Remove(indexOfChars, specials.Length);
            }
        }

        private void ComboBox_PassLenght(object sender, SelectionChangedEventArgs e)
        {
            if (PLenght.SelectedIndex == 0)
                id = 6;
            if (PLenght.SelectedIndex == 1)
                id = 7;
            if (PLenght.SelectedIndex == 2)
                id = 8;
            if (PLenght.SelectedIndex == 3)
                id = 9;
            if (PLenght.SelectedIndex == 4)
                id = 10;
            if (PLenght.SelectedIndex == 5)
                id = 11;
            if (PLenght.SelectedIndex == 6)
                id = 12;
            if (PLenght.SelectedIndex == 7)
                id = 13;
            if (PLenght.SelectedIndex == 8)
                id = 14;
            if (PLenght.SelectedIndex == 9)
                id = 15;
            if (PLenght.SelectedIndex == 10)
                id = 16;

        }
        private void GeneratePassword(object sender, RoutedEventArgs e)
        {
            if (characters.Length > 0)
            {
                Random rand = new Random();
                char[] pass = new char[id];

                for (int i = 0; i < id; i++)
                {
                    pass[i] = characters[rand.Next(characters.Length - 1)];
                }
                Haslo.Text = String.Join("", pass);
            }
            else
                Haslo.Text = "Wybierz jedną z opcji";
        }
        private void Copy(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Haslo.Text);
        }
    }
}
