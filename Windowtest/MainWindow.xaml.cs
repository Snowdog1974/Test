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

namespace Windowtest
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

        private void CloseButtonMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void MaximizeButtonMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Maximized;
        }

        private void ChangeViewButtonMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Normal;
        }

        private void MinimizeButtonMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void DragableGridMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (WindowState == WindowState.Maximized)
                {
                    Point currentPosition = e.GetPosition(this);
                    this.Top = Math.Abs(currentPosition.Y - this.DragableArea.Height);

                    this.Left = Math.Abs(currentPosition.X - this.Width / 2);




                    WindowState = WindowState.Normal;
                }

                DragMove();
            }
        }
    }
}
        /// <summary>
/// override this method to replace the characters enetered with the mask
/// </summary>
/// <param name=”e”>Arguments for event</param>
//protected override void OnPreviewTextInput(TextCompositionEventArgs e)
//{
//         int position = SelectionStart;
//         MaskedTextProvider provider = MaskProvider;
//         if (position < Text.Length)
//        {
//                position = GetNextCharacterPosition(position);
//                if (Keyboard.IsKeyToggled(Key.Insert))
//                {
//                         if (provider.Replace(e.Text, position))
//                               position++;
//                }
//                else
//                {
//                         if (provider.InsertAt(e.Text, position))
//                              position++;
//                 }
//                 position = GetNextCharacterPosition(position);
//         }
//         RefreshText(provider, position);
//         e.Handled = true;
//         base.OnPreviewTextInput(e);
//}

///<summary>
/// Default constructor
///</summary>
//public MaskedTextBox()
//{
//           //cancel the paste and cut command
//           CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, null, CancelCommand));
//           CommandBindings.Add(new CommandBinding(ApplicationCommands.Cut, null, CancelCommand));
//}
////cancel the command
//private static void CancelCommand(object sender, CanExecuteRoutedEventArgs e)
//{
//           e.CanExecute = false;
//           e.Handled = true;
//} 
///// <summary>
///// Static Constructor
///// </summary>
//static MaskedTextBox()
//{
//             //override the meta data for the Text Proeprty of the textbox
//            FrameworkPropertyMetadata metaData = new FrameworkPropertyMetadata();
//            metaData.CoerceValueCallback = ForceText;
//           TextProperty.OverrideMetadata(typeof(MaskedTextBox), metaData);
//}//force the text of the control to use the mask
//private static object ForceText(DependencyObject sender, object value)
//{
//             MaskedTextBox textBox = (MaskedTextBox) sender;
//             if (textBox.Mask != null)
//            {
//                      MaskedTextProvider provider = new MaskedTextProvider(textBox.Mask);
//                      provider.Set((string) value);
//                     return provider.ToDisplayString();
//            }
//           else
//           {
//                   return value;
//           }
//} 


//    }
//}
