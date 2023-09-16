using System.Threading;
using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Feature.Services;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.TestFramework;
using JetBrains.TestFramework;
using JetBrains.TestFramework.Application.Zones;
using NUnit.Framework;

[assembly: Apartment(ApartmentState.STA)]

namespace ReSharperPlugin.folder_generator_plugin.Tests
{
    [ZoneDefinition]
    public class folder_generator_pluginTestEnvironmentZone : ITestsEnvZone, IRequire<PsiFeatureTestZone>, IRequire<Ifolder_generator_pluginZone> { }

    [ZoneMarker]
    public class ZoneMarker : IRequire<ICodeEditingZone>, IRequire<ILanguageCSharpZone>, IRequire<folder_generator_pluginTestEnvironmentZone> { }

    [SetUpFixture]
    public class folder_generator_pluginTestsAssembly : ExtensionTestEnvironmentAssembly<folder_generator_pluginTestEnvironmentZone> { }
}
