using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

[assembly: AssemblyTitle("GitHub.VisualStudio")]
[assembly: AssemblyDescription("GitHub for Visual Studio VSPackage")]
[assembly: Guid("fad77eaa-3fe1-4c4b-88dc-3753b6263cd7")]

[assembly: ProvideBindingRedirection(AssemblyName = "GitHub.UI", CodeBase = @"$PackageFolder$\GitHub.UI.dll",
    OldVersionLowerBound = "0.0.0.0", OldVersionUpperBound = AssemblyVersionInformation.Version)]
[assembly: ProvideBindingRedirection(AssemblyName = "GitHub.VisualStudio.UI", CodeBase = @"$PackageFolder$\GitHub.VisualStudio.UI.dll",
    OldVersionLowerBound = "0.0.0.0", OldVersionUpperBound = AssemblyVersionInformation.Version)]
[assembly: ProvideBindingRedirection(AssemblyName = "GitHub.Exports", CodeBase = @"$PackageFolder$\GitHub.Exports.dll",
    OldVersionLowerBound = "0.0.0.0", OldVersionUpperBound = AssemblyVersionInformation.Version)]
[assembly: ProvideBindingRedirection(AssemblyName = "GitHub.Extensions", CodeBase = @"$PackageFolder$\GitHub.Extensions.dll",
    OldVersionLowerBound = "0.0.0.0", OldVersionUpperBound = AssemblyVersionInformation.Version)]
[assembly: ProvideBindingRedirection(AssemblyName = "Octokit", CodeBase = @"$PackageFolder$\Octokit.dll",
    OldVersionLowerBound = "LowestMajor", OldVersionUpperBound = "Current")]
[assembly: ProvideBindingRedirection(AssemblyName = "LibGit2Sharp", CodeBase = @"$PackageFolder$\LibGit2Sharp.dll",
    OldVersionLowerBound = "LowestMajor", OldVersionUpperBound = "Current")]
[assembly: ProvideBindingRedirection(AssemblyName = "Splat", CodeBase = @"$PackageFolder$\Splat.dll",
    OldVersionLowerBound = "LowestMajor", OldVersionUpperBound = "Current")]
[assembly: ProvideBindingRedirection(AssemblyName = "Rothko", CodeBase = @"$PackageFolder$\Rothko.dll",
    OldVersionLowerBound = "LowestMajor", OldVersionUpperBound = "Current")]
[assembly: ProvideBindingRedirection(AssemblyName = "GitHub.VisualStudio.TestAutomation.AutomationIDs", CodeBase = @"$PackageFolder$\GitHub.VisualStudio.TestAutomation.AutomationIDs.dll",
    OldVersionLowerBound = "LowestMajor", OldVersionUpperBound = "Current")]
