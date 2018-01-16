using RosaryWPFWindows.Models;
using System.Collections.Generic;
using System.Windows;

namespace RosaryWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new RosaryGroupModel()
            {
                Members = new List<RosaryMemberModel>
                {
                    new RosaryMemberModel { Name = "Adam", Surname = "Gudynowski", Tel = "513276485" }
                }
            };

               /*
                * https://damienbod.com/2013/11/18/using-sqlite-with-entity-framework-6-and-the-repository-pattern/
                * sprawdzić gdzie powinien być ten sqlite podłączony czy w kazdej domenie czy jak
                */
        }
    }
}
