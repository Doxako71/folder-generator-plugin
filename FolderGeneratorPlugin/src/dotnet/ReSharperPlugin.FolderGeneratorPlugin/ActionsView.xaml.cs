namespace ReSharperPlugin.FolderGeneratorPlugin;

using JetBrains.Application.UI.Automation;

[View]
public partial class ActionsView : IView<ActionsViewModel>
{
    public new string Name => "Actions";

    public ActionsView()
    {
        InitializeComponent();
    }
}