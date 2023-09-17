namespace ReSharperPlugin.FolderGeneratorPlugin;

using System.Windows.Input;
using JetBrains.Application.UI.UIAutomation;
using JetBrains.Lifetimes;

public class ActionsViewModel : AAutomation
{
    private readonly Lifetime _lifetime;

    public ActionsViewModel(Lifetime lifetime)
    {
        _lifetime = lifetime;
    }

    public ICommand RunAction => new RunActionCommand(_lifetime, typeof(ShowMessageBoxAction));
}