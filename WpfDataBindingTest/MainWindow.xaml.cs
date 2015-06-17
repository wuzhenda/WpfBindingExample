using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDataBindingTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public PersonModel Vm
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
                OnPropertyChanged("Vm");
            }

        }

        PersonModel _model = new PersonModel()
            {
                Surname = "Eberhardt",
                Forename = "Colin",
                Width=120,
                WorkAddress = new AddressModel()
                {
                    Street = "6 Charlotte Square",
                    City = "Newcastle"
                }
            };

        public MainWindow()
        {


            InitializeComponent();

            // create a model object
            
            // bind the Date to the UI
           // this.DataContext = Vm;
            Binding binding1 = new Binding();
            binding1.Path = new PropertyPath("Vm");
            binding1.RelativeSource = RelativeSource.Self;
            this.SetBinding(Window.DataContextProperty,binding1);

           // DataContext = "{Binding RelativeSource={RelativeSource Self}}";
             

           // Binding binding = new Binding("Forename");
           // binding.Source = this;
           //// binding.ElementName = this;
           //// binding.RelativeSource=RelativeSource.
           // binding.Mode = BindingMode.TwoWay;
           // this.cityContext.SetBinding(TextBox.TextProperty, binding);

            // Returns the second ItemsControl encountered on the upward path 
            // starting at the target element of the binding
            //myBinding.RelativeSource = new RelativeSource(
            //    RelativeSourceMode.FindAncestor, typeof(ItemsControl), 2);

            Binding binding = new Binding("DataContext.Forename");
            binding.Source = this;
            binding.Mode = BindingMode.TwoWay;
            this.cityContext.SetBinding(TextBox.TextProperty, binding);


            Binding binding2 = new Binding("DataContext.Width");
            binding2.Source = this;
            binding2.Mode = BindingMode.TwoWay;
            this.SetBinding(Window.WidthProperty, binding2);
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PersonModel _model2 = new PersonModel()
            {
                Surname = "Henry",
                Forename = "Wu",
                Width = 500,
                WorkAddress = new AddressModel()
                {
                    Street = "HuanSan",
                    City = "SuZhou"
                }
            };


            Vm = _model2;
        }

    }
}
