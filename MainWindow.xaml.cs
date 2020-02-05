using BespokeFusion;
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
using ToastNotifications.Messages;
using WpfApp1.Container;
using WpfApp1.Controller;
using WpfApp1.Model;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
           
            InitializeComponent();

            MainWindowSettings();
        }


        private void MainWindowSettings()
        {

            root.Children.Clear();
            root.Children.Add(new HomeContainier());


            SidePanelHome.Visibility = Visibility.Visible;
            SidePanelProgress.Visibility = Visibility.Hidden;
            homeBtn.Background.Opacity = 0.5;
            progressBtn.Background.Opacity = 0;
        }
        private void Button_Click(object sender, RoutedEventArgs e) //home button
        {
            MainWindowSettings();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //View data button
        {
            root.Children.Clear();
            root.Children.Add(new ViewDataContainer());

            SidePanelHome.Visibility = Visibility.Hidden;
            SidePanelProgress.Visibility = Visibility.Visible;
            homeBtn.Background.Opacity = 0;
            progressBtn.Background.Opacity = 0.5;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Program.func();


        }




        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

          
            System.Windows.Application.Current.Shutdown();
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
           

        }

      
      
    }

}