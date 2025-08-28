using CommunityToolkit.Mvvm.Input;
using TestApp.Models;

namespace TestApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}