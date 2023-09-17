namespace ReSharperPlugin.FolderGeneratorPlugin;

using JetBrains.Application;
using JetBrains.Application.UI.ToolWindowManagement;

[ToolWindowDescriptor(
        ProductNeutralId = "MyToolWindow",
        Text = "Sample Tool Window",
        Type = ToolWindowType.MultiInstance,
        Icon = null,
        VisibilityPersistenceScope = ToolWindowVisibilityPersistenceScope.Global,
        InitialDocking = ToolWindowInitialDocking.Right
    )
]
public class SampleToolWindowDescriptor : ToolWindowDescriptor
{
    public SampleToolWindowDescriptor(IApplicationHost host) : base(host)
    {
    }
}