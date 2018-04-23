using System;
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

        private void ShowPreview(object sender, RoutedEventArgs e) {
            PrintableControlLink link = new PrintableControlLink((TableView)gridControl.View);
            LinkPreviewModel model = new LinkPreviewModel(link);
            preview.Model = model;
            link.CreateDocument(true);
        }
    }
}
