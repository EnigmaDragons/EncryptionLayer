
namespace MonoDragons.Core.Navigation
{
    public interface INavigation
    {
        void NavigateTo(string sceneName);
        void NavigateTo(string sceneName, SceneTransition transition);
    }
}
