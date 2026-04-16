using System;
using Consolonia.Themes.Infrastructure;

namespace Consolonia.Modal
{
    public class ModalTheme : AutoThemeStylesBase
    {
        protected override void ComposeForFamily(string family)
        {
            IncludeStyle(new Uri("avares://Consolonia.Modal/Themes/ModalHost.axaml"));

            switch (family)
            { 
                case TurboVisionThemeKey:
                    IncludeStyle(new Uri("avares://Consolonia.Modal/Themes/TurboVision/ModalWindow.axaml"));
                    break;
                case ModernThemeKey:
                    IncludeStyle(new Uri("avares://Consolonia.Modal/Themes/Modern/ModalWindow.axaml"));
                    break;
            }
        }
    }
}