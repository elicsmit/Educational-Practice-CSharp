using System.Windows;

namespace DocumentVersionControl
{
    public partial class VersionDialog : Window
    {
        public string Author { get; private set; }
        public string Description { get; private set; }

        public VersionDialog()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AuthorTextBox.Text))
            {
                MessageBox.Show("Введите автора!", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Author = AuthorTextBox.Text;
            Description = DescriptionTextBox.Text;
            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}