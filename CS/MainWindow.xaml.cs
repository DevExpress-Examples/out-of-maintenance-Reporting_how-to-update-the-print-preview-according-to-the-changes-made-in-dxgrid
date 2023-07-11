using System.Windows;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Printing;
// ...

namespace PrintDXGridSample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        void UpdatePreview(object sender, RoutedEventArgs e) {
            var link = new PrintableControlLink((TableView)gridControl.View);
            link.CreateDocument(true);
            preview.DocumentSource = link;
        }
    }
}
