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

namespace wpf_project_wegwijzer
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

        private void ClosingAllPages()
        {
            grid_NieuwsPagina.Visibility = Visibility.Hidden;
            grid_StandpuntPagina.Visibility = Visibility.Hidden;
        }
        private void btn_NieuwsPagina_Click(object sender, RoutedEventArgs e)
        {
            ClosingAllPages();
            grid_NieuwsPagina.Visibility = Visibility.Visible;
        }

        private void btn_StandpuntPagina_Click(object sender, RoutedEventArgs e)
        {
            ClosingAllPages();
            grid_StandpuntPagina.Visibility = Visibility.Visible;
        }
    }
}