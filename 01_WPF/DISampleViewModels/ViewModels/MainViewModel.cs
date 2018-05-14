using DISampleViewModels.Services;
using Prism.Commands;

namespace DISampleViewModels.ViewModels
{
    public class MainViewModel
    {
        private readonly IShowMessageService _showMessageService;
        public MainViewModel(IShowMessageService showMessageService)
        {
            _showMessageService = showMessageService;

            MessageCommand = new DelegateCommand(OnMessage);
        }

        public DelegateCommand MessageCommand { get; }

        private async void OnMessage() => await _showMessageService.ShowMessageAsync("Hello from the view-model!");
    }
}
