![logo](https://raw.githubusercontent.com/tomlm/ConsoloniaContent/main/Logo.png)

# Consolonia.Modal
`Consolonia.Modal` provides a mechanism for displaying modal dialogs in [Consolonia](https://github.com/jinek/consolonia) applications.

<img width="1029" height="634" alt="image" src="https://github.com/user-attachments/assets/af8e8bae-3e36-4c16-8c88-45776c00634f" />


# Usage
To enable modal support in your application:
1. Add **Consolonia.Modal** NuGet package
2. Include the **ModalTheme** in your **App.axaml**:

```xaml
    <Application.Styles>
        <console:ModernTheme /> <!-- or TurboVisionTheme -->
        <modal:ModalTheme xmlns:modal="clr-namespace:Consolonia.Modal;assembly=Consolonia.Modal" />
    </Application.Styles>
```

For more details, see the [Consolonia.Modal documentation](src/Consolonia.Modal/readme.md).

