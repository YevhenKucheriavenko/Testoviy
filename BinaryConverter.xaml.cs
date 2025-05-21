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

namespace BinaryConverterControl
{
    /// <summary>
    /// Логика взаимодействия для BinaryConverter.xaml
    /// </summary>
    public partial class BinaryConverter : UserControl
    {
        public event EventHandler<string> BinaryValueClick;

        public int DecimalValue
        {
            get => int.TryParse(InputTextBox.Text, out int value) ? value : 0;
            set => InputTextBox.Text = value.ToString();
        }

        public BinaryConverter()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputTextBox.Text, out int value))
            {
                string binary = Convert.ToString(value, 2);
                ResultTextBox.Text = binary;
                BinaryValueClick?.Invoke(this, binary);
            }
            else
            {
                MessageBox.Show("Invalid number.");
            }
        }
    }
}
