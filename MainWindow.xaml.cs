using System.Text;

using System.Windows;

namespace Task01;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>

[System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1515:Unlike a class library, an application's API isn't typically referenced publicly, so types can be marked internal", Justification = "Required for XAML binding or external project references.")]

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BinaryControl_BinaryValueClick(object sender, string binaryValue)
    {
        MessageBox.Show($"Binary: {binaryValue}", "Conversion Result");
    }

}