using System;
using System.Windows;
using Elements.Utils;
using Elements.ViewModel;

namespace Elements
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainVM();
        }

        private void MainWindow_OnClosed(object sender, EventArgs e)
        {
            Settings.Save();
        }
    }
}
