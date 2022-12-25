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

namespace GraphicsEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RadioButton btnPen = new RadioButton();
        RadioButton btnBrush = new RadioButton();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {

        }
        private void cmb_RED_SelectionChanged(object sender, RoutedEventArgs e)//
        {
            MyCanvas.DefaultDrawingAttributes.Color = Colors.Red;
        }
        private void cmb_Green_SelectionChanged(object sender, RoutedEventArgs e)//
        {
            MyCanvas.DefaultDrawingAttributes.Color = Colors.Green;
        }
        private void cmb_Blue_SelectionChanged(object sender, RoutedEventArgs e)//
        {
            MyCanvas.DefaultDrawingAttributes.Color = Colors.Blue;
        }
        private void cmb_Violet_SelectionChanged(object sender, RoutedEventArgs e)//
        {
            MyCanvas.DefaultDrawingAttributes.Color = Colors.Violet;
        }
        private void cmb_Brown_SelectionChanged(object sender, RoutedEventArgs e)//
        {
            MyCanvas.DefaultDrawingAttributes.Color = Colors.Brown;
        }
        private void cmb_Khaki_SelectionChanged(object sender, RoutedEventArgs e)//
        {
            MyCanvas.DefaultDrawingAttributes.Color = Colors.Khaki;
        }
        private void SliderPen(object sender, RoutedEventArgs e)
        {
            if (MyCanvas == null)
            {
                return;
            }
            MyCanvas.DefaultDrawingAttributes.Width = WidthPen.Value;
            MyCanvas.DefaultDrawingAttributes.Height = WidthPen.Value;
        }
        private void RadioButton_Erase(object sender, RoutedEventArgs e)
        {
            MyCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }
        private void RadioButton_Pen(object sender, RoutedEventArgs e)
        {
            MyCanvas.EditingMode = InkCanvasEditingMode.Ink;

        }
        private void RadioButton_Highl(object sender, RoutedEventArgs e)
        {
            MyCanvas.EditingMode = InkCanvasEditingMode.Select;

        }
        private void RadioButton_Delet(object sender, RoutedEventArgs e)
        {
            MyCanvas.Strokes.Clear();
        }
    }
}
