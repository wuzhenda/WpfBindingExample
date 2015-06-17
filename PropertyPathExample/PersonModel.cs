
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

namespace DatabindingExample
{
  public class PersonModel : INotifyPropertyChanged
  {
    private string _forename;

    public string Forename
    {
      get { return _forename; }
      set 
      {
        if (value == _forename)
          return;

        _forename = value;
        OnPropertyChanged("Forename");
      }
    }

    private string _surname;

    public string Surname
    {
      get { return _surname; }
      set
      {
        if (value == _surname)
          return;

        _surname = value;
        OnPropertyChanged("Surname");
      }
    }

    private AddressModel _address;

    public AddressModel WorkAddress
    {
      get { return _address; }
      set
      {
        if (value == _address)
          return;

        _address = value;
        OnPropertyChanged("Address");
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
