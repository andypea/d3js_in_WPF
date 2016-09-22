using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace d3js_in_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Debug.AutoFlush = true;
            InitializeComponent();
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
            webBrowser.NavigateToStream(System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream("d3js_in_WPF.iris.html"));
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void iris_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            webBrowser.NavigateToStream(System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream("d3js_in_WPF.iris.html"));
        }

        private void lesMiserables_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            webBrowser.NavigateToStream(System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream("d3js_in_WPF.lesmiserables.html"));
        }

        private void worldTour__MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            webBrowser.NavigateToStream(System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream("d3js_in_WPF.worldtour.html"));
        }

        private void collision__MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            webBrowser.NavigateToStream(System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream("d3js_in_WPF.collision.html"));
        }

        private void viewHelp_Click(object sender, RoutedEventArgs e)
        {
            openAbout();
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            openAbout();
        }

        private void openAbout()
        {
            var about = new AboutWindow();
            about.ShowDialog();
        }
    }
}
