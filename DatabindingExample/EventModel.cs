﻿using System;
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
  /// <summary>
  /// A simple model object that represents an event
  /// </summary>
  public class EventModel : INotifyPropertyChanged
  {
    private string _title;

    /// <summary>
    /// Gets / sets the event title
    /// </summary>
    public string Title
    {
      get { return _title; }
      set
      {
        if (value == _title)
          return;

        _title = value;
        OnPropertyChanged("Title");
      }
    }

    private DateTime _date;

    /// <summary>
    /// Gets / sets the date of this event
    /// </summary>
    public DateTime Date
    {
      get { return _date; }
      set
      {
        if (value == _date)
          return;

        _date = value;
        OnPropertyChanged("Date");
      }
    }
  
    public event PropertyChangedEventHandler  PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
      if (PropertyChanged != null)
      {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }
  }
}
