using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace WpfDataBindingTest
{
  public class AddressModel : INotifyPropertyChanged
  {
    private string _street;

    public string Street
    {
      get { return _street; }
      set
      {
        if (value == _street)
          return;

        _street = value;
        OnPropertyChanged("Street");
      }
    }

    private string _city;

    public string City
    {
      get { return _city; }
      set
      {
        if (value == _city)
          return;

        _city = value;
        OnPropertyChanged("City");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string property)
    {
      if (PropertyChanged != null)
      {
        PropertyChanged(this, new PropertyChangedEventArgs(property));
      }
    }
  }
}
