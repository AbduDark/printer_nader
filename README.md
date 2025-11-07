# Printer Nader

A Windows Forms desktop application built with Visual Basic .NET and .NET 8.0.

## About This Project

This is a Windows Forms GUI application that was designed to run on Windows operating systems. It has been successfully configured to build on Replit's Linux environment, though running the graphical interface has limitations outside of Windows.

## Current Status on Replit

✅ **Building**: The project builds successfully  
⚠️ **Running**: Windows Forms applications require a Windows environment or compatibility layer to display the GUI

## Quick Start

### Building the Project
The project is configured to build automatically. You can also manually build by running:
```bash
cd printer_nader
dotnet build
```

### Project Files
- `Form1.vb` - Main application form
- `printer_nader.vbproj` - Project configuration
- Built output: `bin/Debug/net8.0-windows/`

## Technical Details

- **Framework**: .NET 8.0
- **Language**: Visual Basic .NET
- **UI**: Windows Forms
- **Target**: Windows platform

## Limitations

This application uses Windows Forms, which is a Windows-specific GUI framework. While the code compiles on Linux, the graphical interface cannot run without:
- A Windows environment, or
- A compatibility layer like Wine (limited support for .NET applications)

## Alternative Approaches

If you need this application to run on Replit or other non-Windows environments, consider:
1. Converting to a cross-platform framework (Avalonia UI, .NET MAUI)
2. Rebuilding as a web application (ASP.NET, Blazor)
3. Developing on a Windows machine for full Windows Forms support

## Development

The project is ready for development. You can modify the Visual Basic code files and rebuild to see changes. For full GUI testing, a Windows environment is recommended.
