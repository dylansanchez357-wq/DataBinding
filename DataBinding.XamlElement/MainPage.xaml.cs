namespace DataBinding.XamlElement
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            EnteredTextLabel.Text = string.Empty;
        }

       private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnteredTextLabelText.Text= string.Empty;
        }


    }
}
