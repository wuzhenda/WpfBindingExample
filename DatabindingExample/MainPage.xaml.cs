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
    private EventModel _event;
    private EventModel _event2;

    public MainPage()
    {
      InitializeComponent();

      // create a model object
      _event = new EventModel()
      {
        Date = new DateTime(2011, 7, 1),
        Title = "Silverlight User Group"
      };

      // bind the Date to the UI
      this.DataContext = _event;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      //_event.Title = _event.Title.ToLower();
      //_event.Date = _event.Date.AddDays(1);
      _event2 = new EventModel()
      {
          Date = new DateTime(2111, 12, 12),
          Title = "Wpf User Group"
      };
      this.DataContext = _event2;
    }
  }
}
