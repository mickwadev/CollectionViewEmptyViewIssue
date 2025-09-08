namespace Repro
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoToBorderPage(object? sender, EventArgs e)
        {
            Shell.Current.GoToAsync("BorderPage");
        }
    }
}
