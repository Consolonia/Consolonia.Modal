using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Consolonia.Modal;

namespace Consolonia.Sandbox
{
    public partial class SampleModal : ModalWindow
    {
        public SampleModal()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void OnCloseClick(object sender, RoutedEventArgs e)
        {
            CloseModal();
        }
    }
}