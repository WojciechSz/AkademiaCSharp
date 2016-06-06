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

namespace CSharpAcademiProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public enum compareResult { equal, notEqual }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Game ourGame = new Game();
            Match ourMatch = new Match(1);
        }
        public SolidColorBrush colorChange(Brush actualBackground)
        {
            string actualBackgroundString;
            SolidColorBrush newColor = Brushes.Red;
            actualBackgroundString = actualBackground.ToString();
            switch (actualBackgroundString)
            {
                case "#FF008000":
                    newColor = Brushes.Red;
                    break;
                case "#FFFF0000":
                    newColor = Brushes.Orange;
                    break;
                case "#FFFFA500":
                    newColor = Brushes.Yellow;
                    break;
                case "#FFFFFF00":
                    newColor = Brushes.Violet;
                    break;
                case "#FFEE82EE":
                    newColor = Brushes.Blue;
                    break;
                case "#FF0000FF":
                    newColor = Brushes.Green;
                    break;
                default:
                    break;
            }
            return newColor;
        }
        public compareResult colorCompare(Brush actualBackground, Brush goalBackground)
        {
            if (actualBackground == goalBackground)
            {
                return compareResult.equal;
            }
            else
                return compareResult.notEqual;
        }
        private void buttonSet_click(object sender, RoutedEventArgs e)
        {
            compareResult result;
            result = colorCompare(buttonPart6Field1.Background, SetField1.Background);
            if (result == compareResult.equal)
            {
                SetField2.Background = Brushes.Red;
            }
            Match ourMatch = new Match(1);
            //ODBLOKOWANIE NASTEPNYCH BUTTONOW
        }

        private void buttonPart6Field1_Click(object sender, RoutedEventArgs e)
        {
            buttonPart6Field1.Background = colorChange(buttonPart6Field1.Background);
        }

        private void buttonPart5Field1_Click(object sender, RoutedEventArgs e)
        {
            buttonPart5Field1.Background = colorChange(buttonPart5Field1.Background);
        }

        private void buttonPart4Field1_Click(object sender, RoutedEventArgs e)
        {
            buttonPart4Field1.Background = colorChange(buttonPart4Field1.Background);
        }

        private void buttonPart3Field1_Click(object sender, RoutedEventArgs e)
        {
            buttonPart3Field1.Background = colorChange(buttonPart3Field1.Background);
        }

        private void buttonPart2Field1_Click(object sender, RoutedEventArgs e)
        {
            buttonPart2Field1.Background = colorChange(buttonPart2Field1.Background);
        }

        private void buttonPart1Field1_Click(object sender, RoutedEventArgs e)
        {
            buttonPart1Field1.Background = colorChange(buttonPart1Field1.Background);
        }

        private void buttonPart6Field2_Click(object sender, RoutedEventArgs e)
        {
            buttonPart6Field2.Background = colorChange(buttonPart6Field2.Background);
        }

        private void buttonPart5Field2_Click(object sender, RoutedEventArgs e)
        {
            buttonPart5Field2.Background = colorChange(buttonPart5Field2.Background);
        }

        private void buttonPart4Field2_Click(object sender, RoutedEventArgs e)
        {
            buttonPart4Field2.Background = colorChange(buttonPart4Field2.Background);
        }

        private void buttonPart3Field2_Click(object sender, RoutedEventArgs e)
        {
            buttonPart3Field2.Background = colorChange(buttonPart3Field2.Background);
        }

        private void buttonPart2Field2_Click(object sender, RoutedEventArgs e)
        {
            buttonPart2Field2.Background = colorChange(buttonPart2Field2.Background);
        }

        private void buttonPart1Field2_Click(object sender, RoutedEventArgs e)
        {
            buttonPart1Field2.Background = colorChange(buttonPart1Field2.Background);
        }

        private void buttonPart6Field3_Click(object sender, RoutedEventArgs e)
        {
            buttonPart6Field3.Background = colorChange(buttonPart6Field3.Background);
        }

        private void buttonPart5Field3_Click(object sender, RoutedEventArgs e)
        {
            buttonPart5Field3.Background = colorChange(buttonPart5Field3.Background);
        }

        private void buttonPart4Field3_Click(object sender, RoutedEventArgs e)
        {
            buttonPart4Field3.Background = colorChange(buttonPart4Field3.Background);
        }

        private void buttonPart3Field3_Click(object sender, RoutedEventArgs e)
        {
            buttonPart3Field3.Background = colorChange(buttonPart3Field3.Background);
        }

        private void buttonPart2Field3_Click(object sender, RoutedEventArgs e)
        {
            buttonPart2Field3.Background = colorChange(buttonPart2Field3.Background);
        }

        private void buttonPart1Field3_Click(object sender, RoutedEventArgs e)
        {
            buttonPart1Field3.Background = colorChange(buttonPart1Field3.Background);
        }

        private void buttonPart6Field4_Click(object sender, RoutedEventArgs e)
        {
            buttonPart6Field4.Background = colorChange(buttonPart6Field4.Background);
        }

        private void buttonPart5Field4_Click(object sender, RoutedEventArgs e)
        {
            buttonPart5Field4.Background = colorChange(buttonPart5Field4.Background);
        }

        private void buttonPart4Field4_Click(object sender, RoutedEventArgs e)
        {
            buttonPart4Field4.Background = colorChange(buttonPart4Field4.Background);
        }

        private void buttonPart3Field4_Click(object sender, RoutedEventArgs e)
        {
            buttonPart3Field4.Background = colorChange(buttonPart3Field4.Background);
        }

        private void buttonPart2Field4_Click(object sender, RoutedEventArgs e)
        {
            buttonPart2Field4.Background = colorChange(buttonPart2Field4.Background);
        }

        private void buttonPart1Field4_Click(object sender, RoutedEventArgs e)
        {
            buttonPart1Field4.Background = colorChange(buttonPart1Field4.Background);
        }

 

    }
}
