using MvvmWithWinForms.Core.ViewModels;

namespace MvvmWithWinForms.UI;

public partial class MainForm : Form
{
    private readonly MainViewModel? _vm;
    private readonly BindingSource _bindingSource = new BindingSource();

    // Designer ctor
    public MainForm()
    {
        InitializeComponent();
    }

    // DI-friendly ctor
    public MainForm(MainViewModel vm) : this()
    {
        _vm = vm ?? throw new ArgumentNullException(nameof(vm));

        // Bind the ViewModel to the BindingSource
        _bindingSource.DataSource = _vm;

        // Bind text boxes to ViewModel properties (Path and Code)
        textBoxPath.DataBindings.Add("Text", _bindingSource, nameof(MainViewModel.Path), true, DataSourceUpdateMode.OnPropertyChanged);
        textBoxCode.DataBindings.Add("Text", _bindingSource, nameof(MainViewModel.Code), true, DataSourceUpdateMode.OnPropertyChanged);

        // Bind button click to ViewModel action
        buttonGenerate.Click += (s, e) =>
        {
            if (_vm.GenerateCommand != null)
            {
                if (_vm.GenerateCommand.CanExecute())
                    _vm.GenerateCommand.Execute();
            }
            else
            {
                // Fallback to method if command is not present
                _vm.Generate();
            }
        };

        // Optionally bind the Enabled state of the button to a CanGenerate property
        try
        {
            buttonGenerate.DataBindings.Add("Enabled", _bindingSource, nameof(MainViewModel.CanGenerate));
        }
        catch
        {
            // If MainViewModel doesn't expose CanGenerate, ignore — binding is optional
        }
    }
}
