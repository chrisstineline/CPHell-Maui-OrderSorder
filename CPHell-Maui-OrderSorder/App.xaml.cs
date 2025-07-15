namespace CPHell_Maui_OrderSorder
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
           
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}