[![downloads](https://img.shields.io/nuget/dt/avalonia.templates)](https://www.nuget.org/packages/Avalonia.Templates/)
[![Current stable version](https://img.shields.io/nuget/v/Avalonia.Templates.svg)](https://www.nuget.org/packages/Avalonia.Templates/)
# Avalonia Templates for `dotnet new`

For more information about `dotnet new` templates see [here](https://blogs.msdn.microsoft.com/dotnet/2017/04/02/how-to-create-your-own-templates-for-dotnet-new/).

## Installing the templates

Run from a command line:

```powershell
dotnet new install Avalonia.Templates
```

The templates should now be available in `dotnet new list`:

```
Template Name                        Short Name                 Language  Tags
-----------------------------------  -------------------------  --------  -----------------------------------------
Avalonia .NET Core App               avalonia.app               [C#],F#   Desktop/Xaml/Avalonia/Windows/Linux/macOS
Avalonia .NET Core MVVM App          avalonia.mvvm              [C#],F#   Desktop/Xaml/Avalonia/Windows/Linux/macOS
Avalonia Cross Platform Application  avalonia.xplat             [C#],F#   Desktop/Xaml/Avalonia/Web/Mobile
Avalonia Resource Dictionary         avalonia.resource                    Desktop/Xaml/Avalonia/Windows/Linux/macOS
Avalonia Styles                      avalonia.styles                      Desktop/Xaml/Avalonia/Windows/Linux/macOS
Avalonia TemplatedControl            avalonia.templatedcontrol  [C#]      Desktop/Xaml/Avalonia/Windows/Linux/macOS
Avalonia UserControl                 avalonia.usercontrol       [C#],F#   Desktop/Xaml/Avalonia/Windows/Linux/macOS
Avalonia Window                      avalonia.window            [C#],F#   Desktop/Xaml/Avalonia/Windows/Linux/macOS
```

**Note:**

By default dotnet CLI would create a **C#** template,if you want to create **F#** template you will need to add ```-lang F#``` to the end of the command.

# Creating a new Application

To create a new barebones application called `MyApp` in its own subdirectory, run:

```
dotnet new avalonia.app -o MyApp
```

Available parameters:

``-A, --AvaloniaVersion``

*Description*: The target version of Avalonia NuGet packages.

*Options*: **0.10.18**, **11.0.0-preview4**

*By default*: 0.10.18
                                   
# Creating a new MVVM Application

MVVM is the recommended pattern for creating Avalonia applications. The MVVM application template
uses [ReactiveUI](https://reactiveui.net/) to ease building applications with complex interactions.

To create a new MVVM application called `MyApp` in its own subdirectory, run:

```
dotnet new avalonia.mvvm -o MyApp
```

Available parameters:

``-A, --AvaloniaVersion``

*Description*: The target version of Avalonia NuGet packages.

*Options*: **0.10.18**, **11.0.0-preview4**

*By default*: 0.10.18

``-M, --MVVMToolkit``

*Description*: MVVM toolkit to use in the template.

*Options*: **ReactiveUI**, **CommunityToolkit**

*By default*: ReactiveUI

# Creating a new Cross-Platform application

To create a new Cross-Platform application in its own subdirectory, run:

```
dotnet new avalonia.xplat 
```
**Note:**
This type of template allows you to create an application that will work on Desktop, Browser (preview) and Mobile (iOS & Android) (preview).

# Creating a new Window

To create a new `Window` called `MyNewWindow`, in the namespace `MyApp` run:

```
dotnet new avalonia.window -na MyApp -n MyNewWindow
```

# Creating a new UserControl

To create a new `UserControl` called `MyNewView`, in the namespace `MyApp` run:

```
dotnet new avalonia.usercontrol -na MyApp -n MyNewView
```

# Creating a new Styles list

To create a new `Styles` list called `MyStyles`, run:

```
dotnet new avalonia.styles -n MyStyles
```

# Creating a new ResourceDictionary

To create a new `ResourceDictionary` called `MyResources`, run:

```
dotnet new avalonia.resource -n MyResources
```
