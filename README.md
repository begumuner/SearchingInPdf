# SearchingInPdf
Searching Text from PDF in C#.NET Code

Before using the reader from a .NET Core application, I believe you need to add a dependency on the "System.Text.Encoding.CodePages" Nuget package, and then register the codepage provider in the application initialisation code (f.ex in Startup.cs):
System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

for NuGet : dotnet add package System.Text.Encoding.CodePages --version 4.7.0
