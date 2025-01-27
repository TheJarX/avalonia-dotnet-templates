﻿namespace AvaloniaAppTemplate

open System
open Avalonia
#if (ReactiveUIToolkitChosen)
open Avalonia.ReactiveUI
#endif

module Program =

    [<CompiledName "BuildAvaloniaApp">] 
    let buildAvaloniaApp () = 
        AppBuilder
            .Configure<App>()
            .UsePlatformDetect()
#if (!AvaloniaStableChosen)
            .WithInterFont()
#endif
            .LogToTrace(areas = Array.empty)
#if (ReactiveUIToolkitChosen)
            .UseReactiveUI()
#endif

    [<EntryPoint; STAThread>]
    let main argv =
        buildAvaloniaApp().StartWithClassicDesktopLifetime(argv)
