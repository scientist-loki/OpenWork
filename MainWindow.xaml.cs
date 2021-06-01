using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using ControlzEx.Theming;
using System.Drawing;
using System.Windows.Media;
using System.Security.AccessControl;

namespace OpenWork_Notepad
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            //ThemeManager.Current.ChangeTheme(this, "Light.Red");
        }


        /// <summary>
        /// Click Event for Options Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSettings_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // Open the option form.
            win_options opt = new win_options();
            opt.Show();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //this.ShowMessageAsync("Test:", clr.Color.ToString());
            //this.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(clr.Color.R, clr.Color.G, clr.Color.B));
        }

        private void btnApply_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            rtbNotepad.FontSize = double.Parse(txtFontSize.Text);
            this.Opacity = double.Parse(txtOpacity.Text);
            this.Topmost = txtTopmost.Text.ToLower().Contains("true") ? true : false;
            this.ShowMessageAsync("有新的更改", "OK");
        }
    }
}
