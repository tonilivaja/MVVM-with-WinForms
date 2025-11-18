using MvvmWithWinForms.CodeGeneration.Contracts;
using MvvmWithWinForms.Core.Helpers;
using System.ComponentModel;

namespace MvvmWithWinForms.Core.ViewModels;

public class MainViewModel : BaseViewModel
{
    public string Path
    {
        get => _path;
        set
        {
            if (SetProperty(ref _path, value, "Path"))
            {
                GenerateCommand.RaiseCanExecuteChanged();
                RaisePropertyChanged(nameof(CanGenerate));
            }
        }
    }

    public string Code
    {
        get => _code;
        set
        {
            if (SetProperty(ref _code, value, "Code"))
            {
                GenerateCommand.RaiseCanExecuteChanged();
                RaisePropertyChanged(nameof(CanGenerate));
            }
        }
    }

    public RelayCommand GenerateCommand { get; }

    public BindingList<string> GeneratedFiles { get; } = new BindingList<string>();

    private readonly ICodeGenerationService _codeGenerationService;

    private string _path = string.Empty;
    private string _code = string.Empty;

    public MainViewModel(ICodeGenerationService codeGenerationService)
    {
        _codeGenerationService = codeGenerationService;

        GenerateCommand = new RelayCommand(Generate, () => CanGenerate);
    }

    public void Generate()
    {
        var result = _codeGenerationService.Generate(Path, Code);
        GeneratedFiles.Add(result);
    }

    public bool CanGenerate => !string.IsNullOrWhiteSpace(Path) && !string.IsNullOrWhiteSpace(Code);
}
