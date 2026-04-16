using Avalonia;
using Avalonia.Controls.Primitives;

namespace Consolonia.Modal
{
    public class ModalWindowHeader : TemplatedControl
    {
        public static readonly StyledProperty<string> TitleProperty =
            ModalWindow.TitleProperty.AddOwner<ModalWindowHeader>();

        public static readonly StyledProperty<object> IconProperty =
            ModalWindow.IconProperty.AddOwner<ModalWindowHeader>();

        public static readonly StyledProperty<bool> IsCloseButtonVisibleProperty =
            ModalWindow.IsCloseButtonVisibleProperty.AddOwner<ModalWindowHeader>();

        public string Title
        {
            get => GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public object Icon
        {
            get => GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public bool IsCloseButtonVisible
        {
            get => GetValue(IsCloseButtonVisibleProperty);
            set => SetValue(IsCloseButtonVisibleProperty, value);
        }
    }
}