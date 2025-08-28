# TestApp

Issue duplication example for https://developercommunity.visualstudio.com/t/MissingFieldException:-Field-not-fo/10954903?viewtype=all

Uncomment this line in the `TestApp.csproj` to see the issue `<ProjectReference Include="..\SharedModels\SharedModels.csproj" />`


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