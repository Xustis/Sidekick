using System.Windows;
using System.Windows.Controls;
using Bindables;

namespace Sidekick.Views.Leagues.Incursion
{
    /// <summary>
    /// Interaction logic for RoomTier.xaml
    /// </summary>
    [DependencyProperty]
    public partial class RoomTier : UserControl
    {
        public RoomTier()
        {
            InitializeComponent();
            Container.DataContext = this;
        }

        public IncursionRoomTier Model { get; set; }
    }
}
