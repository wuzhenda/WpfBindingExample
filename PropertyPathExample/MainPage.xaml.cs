using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;

namespace DatabindingExample
{
  public partial class MainPage : UserControl
  {
    private PersonModel _model;

    public MainPage()
    {
      InitializeComponent();

      // create a model object
      _model = new PersonModel()
      {
        Surname = "Eberhardt",
        Forename = "Colin",
        WorkAddress = new AddressModel()
        {
          Street = "6 Charlotte Square",
          City = "Newcastle"
        }
      };
 

      // bind the Date to the UI
      this.DataContext = _model;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      _model.WorkAddress = new AddressModel()
        {
          Street = "62 Arcacia Ave.",
          City = "Bananaville"
        };
    }

  }
}
