namespace Random_Recipe_Finder_MAUI_APP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "Random_Recipe_Finder_MAUI_APP" };
        }
    }
}
