# TestApp

Error duplication example for https://developercommunity.visualstudio.com/t/MissingFieldException:-Field-not-fo/10954903?viewtype=all


The error XAGJS7000 occurs when a shared MAUI class library is referenced directly by a MAUI app. Does not seem to occur when it’s through a nuget package.

It does also occur when it’s through a nuget package-- instead of a project reference you build to nuget package and [setup a local nuget feed](https://learn.microsoft.com/en-us/nuget/hosting-packages/local-feeds).

NOTE: the shared maui class library builds successfully standalone.

Uncomment `<ProjectReference Include="..\SharedModels\SharedModels.csproj" />` in the [TestApp.csproj](TestApp/TestApp.csproj) to see the error
### Stack trace: when uncommenting the ProjectReference line above

```
2>C:\Program Files\dotnet\packs\Microsoft.Android.Sdk.Windows\35.0.92\tools\Xamarin.Android.Common.targets(1503,3): error XAGJS7000:
System.AggregateException: One or more errors occurred. ---> System.NullReferenceException: Object reference not set to an instance of an object.
    at Java.Interop.Tools.Cecil.CustomAttributeProviderRocks.<GetCustomAttributes>d__3.MoveNext() in /Users/runner/work/1/s/xamarin-android/external/Java.Interop/src/Java.Interop.Tools.Cecil/Java.Interop.Tools.Cecil/CustomAttributeProviderRocks.cs:line 30
    at System.Linq.Enumerable.WhereSelectEnumerableIterator`2.MoveNext()
    at System.Linq.Enumerable.WhereSelectEnumerableIterator`2.MoveNext()
    at Java.Interop.Tools.JavaCallableWrappers.Utilities.CecilExtensions.<GetTypeRegistrationAttributes>d__12.MoveNext() in /Users/runner/work/1/s/xamarin-android/external/Java.Interop/src/Java.Interop.Tools.JavaCallableWrappers/Java.Interop.Tools.JavaCallableWrappers/CecilExtensions.cs:line 159
    at System.Linq.Enumerable.Any[TSource](IEnumerable`1 source)
    at Java.Interop.Tools.JavaCallableWrappers.Adapters.CecilImporter.CreateType(TypeDefinition type, IMetadataResolver resolver, CallableWrapperReaderOptions options, String outerType) in /Users/runner/work/1/s/xamarin-android/external/Java.Interop/src/Java.Interop.Tools.JavaCallableWrappers/Java.Interop.Tools.JavaCallableWrappers.Adapters/CecilImporter.cs:line 67
    at Xamarin.Android.Tasks.JCWGenerator.CreateGenerator(TypeDefinition type, MarshalMethodsClassifier classifier, String monoInit, Boolean hasExportReference, String applicationJavaClass) in /Users/runner/work/1/s/xamarin-android/src/Xamarin.Android.Build.Tasks/Utilities/JCWGenerator.cs:line 183
    at Xamarin.Android.Tasks.JCWGenerator.ProcessTypes(Boolean generateCode, String androidSdkPlatform, MarshalMethodsClassifier classifier, String outputPath, String applicationJavaClass) in /Users/runner/work/1/s/xamarin-android/src/Xamarin.Android.Build.Tasks/Utilities/JCWGenerator.cs:line 105
    at Xamarin.Android.Tasks.JCWGenerator.GenerateAndClassify(String androidSdkPlatform, String outputPath, String applicationJavaClass) in /Users/runner/work/1/s/xamarin-android/src/Xamarin.Android.Build.Tasks/Utilities/JCWGenerator.cs:line 79
    at Xamarin.Android.Tasks.GenerateJavaStubs.GenerateJavaSourcesAndMaybeClassifyMarshalMethods(AndroidTargetArch arch, Dictionary`2 assemblies, Dictionary`2 userAssemblies, Boolean useMarshalMethods, Boolean generateJavaCode) in /Users/runner/work/1/s/xamarin-android/src/Xamarin.Android.Build.Tasks/Tasks/GenerateJavaStubs.cs:line 382
    at Xamarin.Android.Tasks.GenerateJavaStubs.<>c__DisplayClass146_0.<Run>b__0(KeyValuePair`2 kvp) in /Users/runner/work/1/s/xamarin-android/src/Xamarin.Android.Build.Tasks/Tasks/GenerateJavaStubs.cs:line 202
    at System.Threading.Tasks.Parallel.<>c__DisplayClass42_0`2.<PartitionerForEachWorker>b__1()
    at System.Threading.Tasks.Task.InnerInvokeWithArg(Task childTask)
    at System.Threading.Tasks.Task.<>c__DisplayClass176_0.<ExecuteSelfReplicating>b__0(Object <p0>)
    --- End of inner exception stack trace ---
    at System.Threading.Tasks.Task.ThrowIfExceptional(Boolean includeTaskCanceledExceptions)
    at System.Threading.Tasks.Task.Wait(Int32 millisecondsTimeout, CancellationToken cancellationToken)
    at System.Threading.Tasks.Parallel.PartitionerForEachWorker[TSource,TLocal](Partitioner`1 source, ParallelOptions parallelOptions, Action`1 simpleBody, Action`2 bodyWithState, Action`3 bodyWithStateAndIndex, Func`4 bodyWithStateAndLocal, Func`5 bodyWithEverything, Func`1 localInit, Action`1 localFinally)
    at System.Threading.Tasks.Parallel.ForEachWorker[TSource,TLocal](IEnumerable`1 source, ParallelOptions parallelOptions, Action`1 body, Action`2 bodyWithState, Action`3 bodyWithStateAndIndex, Func`4 bodyWithStateAndLocal, Func`5 bodyWithEverything, Func`1 localInit, Action`1 localFinally)
    at System.Threading.Tasks.Parallel.ForEach[TSource](IEnumerable`1 source, Action`1 body)
    at Xamarin.Android.Tasks.GenerateJavaStubs.Run(Boolean useMarshalMethods) in /Users/runner/work/1/s/xamarin-android/src/Xamarin.Android.Build.Tasks/Tasks/GenerateJavaStubs.cs:line 217
    at Xamarin.Android.Tasks.GenerateJavaStubs.RunTask() in /Users/runner/work/1/s/xamarin-android/src/Xamarin.Android.Build.Tasks/Tasks/GenerateJavaStubs.cs:line 102
    at Microsoft.Android.Build.Tasks.AndroidTask.Execute() in /Users/runner/work/1/s/xamarin-android/external/xamarin-android-tools/src/Microsoft.Android.Build.BaseTasks/AndroidTask.cs:line 25
 ---> (Inner Exception #0) System.NullReferenceException: Object reference not set to an instance of an object.
    at Java.Interop.Tools.Cecil.CustomAttributeProviderRocks.<GetCustomAttributes>d__3.MoveNext() in /Users/runner/work/1/s/xamarin-android/external/Java.Interop/src/Java.Interop.Tools.Cecil/Java.Interop.Tools.Cecil/CustomAttributeProviderRocks.cs:line 30
    at System.Linq.Enumerable.WhereSelectEnumerableIterator`2.MoveNext()
    at System.Linq.Enumerable.WhereSelectEnumerableIterator`2.MoveNext()
    at Java.Interop.Tools.JavaCallableWrappers.Utilities.CecilExtensions.<GetTypeRegistrationAttributes>d__12.MoveNext() in /Users/runner/work/1/s/xamarin-android/external/Java.Interop/src/Java.Interop.Tools.JavaCallableWrappers/Java.Interop.Tools.JavaCallableWrappers/CecilExtensions.cs:line 159
    at System.Linq.Enumerable.Any[TSource](IEnumerable`1 source)
    at Java.Interop.Tools.JavaCallableWrappers.Adapters.CecilImporter.CreateType(TypeDefinition type, IMetadataResolver resolver, CallableWrapperReaderOptions options, String outerType) in /Users/runner/work/1/s/xamarin-android/external/Java.Interop/src/Java.Interop.Tools.JavaCallableWrappers/Java.Interop.Tools.JavaCallableWrappers.Adapters/CecilImporter.cs:line 67
    at Xamarin.Android.Tasks.JCWGenerator.CreateGenerator(TypeDefinition type, MarshalMethodsClassifier classifier, String monoInit, Boolean hasExportReference, String applicationJavaClass) in /Users/runner/work/1/s/xamarin-android/src/Xamarin.Android.Build.Tasks/Utilities/JCWGenerator.cs:line 183
    at Xamarin.Android.Tasks.JCWGenerator.ProcessTypes(Boolean generateCode, String androidSdkPlatform, MarshalMethodsClassifier classifier, String outputPath, String applicationJavaClass) in /Users/runner/work/1/s/xamarin-android/src/Xamarin.Android.Build.Tasks/Utilities/JCWGenerator.cs:line 105
    at Xamarin.Android.Tasks.JCWGenerator.GenerateAndClassify(String androidSdkPlatform, String outputPath, String applicationJavaClass) in /Users/runner/work/1/s/xamarin-android/src/Xamarin.Android.Build.Tasks/Utilities/JCWGenerator.cs:line 79
    at Xamarin.Android.Tasks.GenerateJavaStubs.GenerateJavaSourcesAndMaybeClassifyMarshalMethods(AndroidTargetArch arch, Dictionary`2 assemblies, Dictionary`2 userAssemblies, Boolean useMarshalMethods, Boolean generateJavaCode) in /Users/runner/work/1/s/xamarin-android/src/Xamarin.Android.Build.Tasks/Tasks/GenerateJavaStubs.cs:line 382
    at Xamarin.Android.Tasks.GenerateJavaStubs.<>c__DisplayClass146_0.<Run>b__0(KeyValuePair`2 kvp) in /Users/runner/work/1/s/xamarin-android/src/Xamarin.Android.Build.Tasks/Tasks/GenerateJavaStubs.cs:line 202
    at System.Threading.Tasks.Parallel.<>c__DisplayClass42_0`2.<PartitionerForEachWorker>b__1()
    at System.Threading.Tasks.Task.InnerInvokeWithArg(Task childTask)
    at System.Threading.Tasks.Task.<>c__DisplayClass176_0.<ExecuteSelfReplicating>b__0(Object <p0>)<---
```


### Environment

Microsoft Visual Studio Community 2022
Version 17.14.13 (August 2025)
VisualStudio.17.Release/17.14.13+36414.22.-august.2025-
Microsoft .NET Framework
Version 4.8.09032

Installed Version: Community

Visual C++ 2022   00476-80000-00000-AA346
Microsoft Visual C++ 2022

ADL Tools Service Provider   1.0
This package contains services used by Data Lake tools

ASA Service Provider   1.0

ASP.NET and Web Tools   17.14.122.59099
ASP.NET and Web Tools

ASP.NET Web Frameworks and Tools 2012   17.14.122.59099
For additional information, visit https://www.asp.net/

Azure App Service Tools v3.0.0   17.14.122.59099
Azure App Service Tools v3.0.0

Azure Data Lake Tools for Visual Studio   2.6.5000.0
Microsoft Azure Data Lake Tools for Visual Studio

Azure Functions and Web Jobs Tools   17.14.122.59099
Azure Functions and Web Jobs Tools

Azure Stream Analytics Tools for Visual Studio   2.6.5000.0
Microsoft Azure Stream Analytics Tools for Visual Studio

C# Tools   4.14.0-3.25412.6+c167adef821b9ba2f1c44c227a5e79ca11876461
C# components used in the IDE. Depending on your project type and settings, a different version of the compiler may be used.

Common Azure Tools   1.10
Provides common services for use by Azure Mobile Services and Microsoft Azure Tools.

Cookiecutter   17.0.25079.8
Provides tools for finding, instantiating and customizing templates in cookiecutter format.

Debugging Tools for Windows   10.0.26100.2454
Integrates the Windows Debugger functionality (http://go.microsoft.com/fwlink/?linkid=223405) in Visual Studio.

Dotfuscator Community Edition   6.5.3+7f0b0a9d18
PreEmptive Protection - Dotfuscator CE

Extension Manager 2022   1.3.6
Import/export extensions as well as associate extensions with individual solutions

File Icons   2.7
Adds icons for files that are not recognized by Solution Explorer

GitHub Copilot   17.14.1091.29919
GitHub Copilot is an AI pair programmer that helps you write code faster and with less work.

Linux Core Dump Debugging   1.0.9.36414
Enables debugging of Linux core dumps.

Microsoft Azure Hive Query Language Service   2.6.5000.0
Language service for Hive query

Microsoft Azure Stream Analytics Language Service   2.6.5000.0
Language service for Azure Stream Analytics

Microsoft Azure Tools for Visual Studio   2.9
Support for Azure Cloud Services projects

Microsoft JVM Debugger   1.0
Provides support for connecting the Visual Studio debugger to JDWP compatible Java Virtual Machines

Mono Debugging for Visual Studio   17.14.11 (f3bc644800)
Support for debugging Mono processes with Visual Studio

Node.js Tools   1.5.61125.7 Commit Hash:d387982a7546304d617ed77b6d390e04b6558274
Adds support for developing and debugging Node.js apps in Visual Studio

NpgsqlVSPackage Extension   1.0
NpgsqlVSPackage Visual Studio Extension Detailed Info

NuGet Package Manager   6.14.1
NuGet Package Manager in Visual Studio. For more information about NuGet, visit https://docs.nuget.org/

Office Developer Tools for Visual Studio   17.10.35724.01
Microsoft Office Developer Tools for Visual Studio

Project System Tools   1.0
Tools for working with C#, VisualBasic, and F# projects.

Python - Django support   17.0.25079.8
Provides templates and integration for the Django web framework.

Python - Profiling support   17.0.25079.8
Profiling support for Python projects.

Python with Pylance   17.0.25079.8
Provides IntelliSense, projects, templates, debugging, interactive windows, and other support for Python developers.

Razor (ASP.NET Core)   17.14.3.2530601+3372435431977e91904a23ceb1eab689badc1bd9
Provides languages services for ASP.NET Core Razor.

ResX Resource Manager   ResXManager
Manage localization of all ResX-based resources in one place. Shows all resources of a solution and lets you edit the strings and their localizations in a well-arranged data grid.

SQL Server Data Tools   17.14.26.0
Microsoft SQL Server Data Tools

Test Adapter for Boost.Test   1.0
Enables Visual Studio's testing tools with unit tests written for Boost.Test.  The use terms and Third Party Notices are available in the extension installation directory.

Test Adapter for Google Test   1.0
Enables Visual Studio's testing tools with unit tests written for Google Test.  The use terms and Third Party Notices are available in the extension installation directory.

ToolWindowHostedEditor   1.0
Hosting json editor into a tool window

TypeScript Tools   17.0.40502.2001
TypeScript Tools for Microsoft Visual Studio

Visual Basic Tools   4.14.0-3.25412.6+c167adef821b9ba2f1c44c227a5e79ca11876461
Visual Basic components used in the IDE. Depending on your project type and settings, a different version of the compiler may be used.

Visual C++ for Cross Platform Mobile Development (Android)   15.0.36015.10
Visual C++ for Cross Platform Mobile Development (Android)

Visual C++ for Cross Platform Mobile Development (iOS)   15.0.36015.10
Visual C++ for Cross Platform Mobile Development (iOS)

Visual C++ for Linux and Mac Development   1.0.9.36414
Visual C++ for Linux and Mac Development

Visual F# Tools   17.14.0-beta.25230.7+c1a9d78ad4a474a716ccffb4367ed5151e3f7c9f
Microsoft Visual F# Tools

Visual Studio IntelliCode   2.2
AI-assisted development for Visual Studio.

Visual Studio Tools for Unity   17.14.1.0
Visual Studio Tools for Unity

VisualStudio.DeviceLog   1.0
Information about my package

VisualStudio.Mac   1.0
Mac Extension for Visual Studio

Windows Driver Kit   10.0.26100.2454
Headers, libraries, and tools needed to develop, debug, and test Windows drivers (msdn.microsoft.com/en-us/windows/hardware/gg487428.aspx)

Workflow Manager Tools 1.0   1.0
This package contains the necessary Visual Studio integration components for Workflow Manager.

Xamarin   17.14.271 (bf42fb0072)
Visual Studio extension to enable development for Xamarin.iOS and Xamarin.Android.

Xamarin Designer   17.14.3.0 (tags/main-61034a2(11307611)^0@61034a2622)
Visual Studio extension to enable Xamarin Designer tools in Visual Studio.

Xamarin.Android SDK   13.2.2.0 (d17-5/45b0e14)
Xamarin.Android Reference Assemblies and MSBuild support.
    Mono: d9a6e87
    Java.Interop: xamarin/java.interop/d17-5@149d70fe
    SQLite: xamarin/sqlite/3.40.1@68c69d8
    Xamarin.Android Tools: xamarin/xamarin-android-tools/d17-5@ca1552d
