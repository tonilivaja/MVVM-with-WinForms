using System.ComponentModel;

namespace MvvmWithWinForms.Core.ViewModels;

/// <summary>
/// Base ViewModel that will be inherted by all ViewModels in the application.
/// It implements INotifyPropertyChanged to support data binding and a SetProperty helper.
/// </summary>
public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected bool SetProperty<T>(ref T field, T value, string propertyName)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
        {
            return false;
        }

        field = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        return true;
    }

    /// <summary>
    /// Helper for derived classes to raise PropertyChanged for a specific property.
    /// </summary>
    protected void RaisePropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
