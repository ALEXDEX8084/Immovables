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

namespace Immovables.Pages
{
    /// <summary>
    /// Interaction logic for UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        public UsersPage()
        {
            InitializeComponent();
        }
        private void ToBuildings_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BuildingsPage());
        }

        private void ChangeUser_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new LoginPage());
        }
        private void ToClients_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ClientsPage());
        }

        private void ToOwners_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new OwnersPage());
        }
        private void ToEmployes_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new EmployeesPage());
        }
        private void ToContracts_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ContractsPage());
        }
    }
}
