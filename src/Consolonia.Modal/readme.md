# Consolonia.Modal

`Consolonia.Modal` provides a mechanism for displaying modal dialogs in Consolonia applications.

## Features

- **Modal Overlay**: Shades the background to prevent interaction with the main window.
- **Integration**: Use `ModalTheme` to enable modal support for all windows.
- **Customization**: Control the title, icon, close button visibility, and keyboard behavior (Escape key).
- **Layout**: Modal size and position are determined by the `ModalWindow` properties and its first child.

## Installation

Add the `Consolonia.Modal` package to your project and include the `ModalTheme` in your `App.axaml`:

```xml
<Application ...
             xmlns:console="https://github.com/consolonia"
             xmlns:modal="clr-namespace:Consolonia.Modal;assembly=Consolonia.Modal">
    <Application.Styles>
        <console:ModernTheme /> <!-- or TurboVisionTheme -->
        <modal:ModalTheme />
    </Application.Styles>
</Application>
```

The `ModalTheme` attaches a `ModalHost` to every `Window`, which is required for displaying modal dialogs.

## Usage

### 1. Create a Modal Window

Create a new XAML file for your modal, inheriting from `modal:ModalWindow`. Set alignment on the `ModalWindow` itself to control its position.

```xml
<modal:ModalWindow xmlns="https://github.com/avaloniaui"
                    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                    xmlns:modal="clr-namespace:Consolonia.Modal;assembly=Consolonia.Modal"
                    x:Class="MyApp.MyModal"
                    Title="Confirmation"
                    Icon="❓"
                    HorizontalAlignment="Center"
                    VerticalAlignment="Center">
    <!-- The first child determines the size of the modal box -->
    <StackPanel Margin="2" 
                Spacing="1">
        <TextBlock Text="Are you sure you want to proceed?" />
        <StackPanel Orientation="Horizontal" Spacing="2" HorizontalAlignment="Center">
            <Button Content="OK" Click="OnOkClick" />
            <Button Content="Cancel" Click="OnCancelClick" />
        </StackPanel>
    </StackPanel>
</modal:ModalWindow>
```

### 2. Show the Modal

Call `ShowModalAsync` from your code-behind:

```csharp
var modal = new MyModal();
await modal.ShowModalAsync(this); // 'this' is the parent window or control
```

## Layout and Alignment

A `ModalWindow` spans the entire parent window by default to provide the modal overlay. The actual "modal box" (the frame with the title and borders) follows the size of the first child and is centered within the `ModalWindow`.

### The Role of the First Child

The size of the modal frame **depends on the first child** of the `ModalWindow`.

- **Sizing**: The modal frame automatically calculates its size based on the dimensions of the first child.
- **Alignment**: The first child **must have its `HorizontalAlignment` and `VerticalAlignment` set to `Stretch`** (the default). Setting them to `Center` or other values will cause layout issues.
- **Margins**: Avoid setting a `Margin` on the first child, as it will behave like padding inside the modal frame.

### Positioning the Modal

To control the position, size, or margins of the modal box relative to the screen, set these properties on the `ModalWindow` itself:

- **Centering**: Set `HorizontalAlignment="Center"` and `VerticalAlignment="Center"` on the `ModalWindow`.
- **Margins**: Set `Margin` on the `ModalWindow` to add space between the overlay edges and the modal.
- **Docking**: Use `Left`, `Right`, `Top`, or `Bottom` alignments on the `ModalWindow`.

### Properties

| Property | Type | Description |
| :--- | :--- | :--- |
| `Title` | `string` | The text displayed in the modal header. |
| `Icon` | `object` | An icon displayed next to the title. |
| `IsCloseButtonVisible`| `bool` | Whether to show the [x] close button (Default: `true`). |
| `CancelOnEscape` | `bool` | Whether the modal can be closed by pressing the `Escape` key (Default: `true`). |
| `Margin` | `Thickness`| Should be used on the `ModalWindow` itself to limit the modal area. |

## Customizing Themes

`Consolonia.Modal` supports both `Modern` and `TurboVision` themes. The `ModalTheme` automatically picks the appropriate styles based on the active Consolonia theme.

If you need to customize the look of all modals, you can override the `ControlTheme` for `modal:ModalWindow` or `modal:ModalWindowHeader`.
