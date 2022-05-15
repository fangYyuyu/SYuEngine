using System.Windows;

namespace SYuEditor.GameProject
{
    /// <summary>
    /// Interaction logic for ProjectBrowser.xaml
    /// </summary>
    public partial class ProjectBrowser : Window
    {
        public ProjectBrowser()
        {
            InitializeComponent();
        }

        private void OnButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender == OpenProjectButton)
            {
                if (CreateProjectButton.IsChecked == true)
                {
                    CreateProjectButton.IsChecked = false;
                    BrowserContent.Margin = new Thickness(0);
                }
                OpenProjectButton.IsChecked = true;

            }
            else
            {

                if (OpenProjectButton.IsChecked == true)
                {
                    OpenProjectButton.IsChecked = false;
                    BrowserContent.Margin = new Thickness(-800, 0, 0, 0);
                }
                CreateProjectButton.IsChecked = true;
            }
        }


    }
}
