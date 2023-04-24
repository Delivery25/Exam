using Exam.Pages;
using System;
using System.Windows;

namespace Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
            MainFrame.Navigate(new LoginPage());
        }

        /// <summary>
        /// Событие при смене содержимого в MainFrame
        /// </summary>
        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            BackButton.Visibility = MainFrame.CanGoBack ? Visibility.Visible : Visibility.Collapsed;
        }

        /// <summary>
        /// Событие по нажатию на кнопку возврата на предыдущую страницу
        /// </summary>
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.GoBack();
        }
    }
}
