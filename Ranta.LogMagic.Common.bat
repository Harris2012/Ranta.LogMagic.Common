msbuild Ranta.LogMagic.Common.Net40\Ranta.LogMagic.Common.Net40.csproj /t:rebuild /p:configuration=release;DocumentationFile=bin\Release\Ranta.LogMagic.Common.xml;DebugType=none

msbuild Ranta.LogMagic.Common.Net45\Ranta.LogMagic.Common.Net45.csproj /t:rebuild /p:configuration=release;DocumentationFile=bin\Release\Ranta.LogMagic.Common.xml;DebugType=none

nuget pack Ranta.LogMagic.Common.nuspec

move /y Ranta.LogMagic.Common.*.nupkg ..\Nuget\Packages

pause