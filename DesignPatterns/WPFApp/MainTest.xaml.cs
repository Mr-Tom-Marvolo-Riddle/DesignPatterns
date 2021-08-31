using System.Windows;

using WPFApp.ViewModels;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainTest.xaml
    /// </summary>
    public partial class MainTest : Window
    {
        private AViewModel _vm;

        public MainTest()
        {
            InitializeComponent();
            _vm = new AViewModel();
            this.DataContext = _vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var aModel = new AModel();
            _vm.MyList.Add(aModel);
            aModel.A = "Hello World";
        }
    }
}
