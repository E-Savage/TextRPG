using Engine.ViewModels;
using System;
using System.Collections.Generic;
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

namespace textrpg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // use a property if another class was going to use it 
        // a property can be used to expose data to other classes
        
        //properties are accessible from outside the class

        // variables(fields) are only accessible from their own class 
        private GameSession _gameSession;
        public MainWindow()
        {
            InitializeComponent();

            _gameSession = new GameSession();   

            // datacontext is for the XAML
            // DataContext is a property used by XAML
            // to display content
            DataContext = _gameSession;
        }

        private void ButtonBase_OnClicked(object sender, RoutedEventArgs e)
        {
            _gameSession.CurrentPlayer.ExperiencePoints = _gameSession.CurrentPlayer.ExperiencePoints + 10;
        }
    }
}
