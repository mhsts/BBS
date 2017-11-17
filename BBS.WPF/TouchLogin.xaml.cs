using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Effects;
using System.Windows.Media.Animation;

namespace BBS.WPF
{
    /// <summary>
    /// Interaction logic for TouchLogin.xaml
    /// </summary>
    public partial class TouchLogin : UserControl
    {
        private IList<Label> tiles = new List<Label>();

        public TouchLogin()
        {
            InitializeComponent();

            this.MouseDown += new MouseButtonEventHandler(TouchLogin_MouseDown);
            this.MouseUp += new MouseButtonEventHandler(TouchLogin_MouseUp);

            int numTiles = 4;
            double dimension = 95;
            tiles.Clear();

            TiledGrid.Effect = new BlurEffect { Radius = 1.0 };

            for (int i = 0; i < numTiles; i++)
            {
                for (int j = 0; j < numTiles; j++)
                {
                    var tile = new Label();
                    tile.HorizontalAlignment = HorizontalAlignment.Center;
                    tile.VerticalAlignment = VerticalAlignment.Center;
                    tile.HorizontalContentAlignment = HorizontalAlignment.Center;
                    tile.VerticalContentAlignment = VerticalAlignment.Center;
                    tile.Tag = false;
                    tile.Width = dimension;
                    tile.Height = dimension;
                    tile.Background = initialColor;
                    tile.Effect = null;
                    tile.Opacity = 0.7;
                    Grid.SetRow(tile, i);
                    Grid.SetColumn(tile, j);

                    var hotArea = new Label();
                    hotArea.Width = (4.0*dimension) / 5.0;
                    hotArea.Height = (4.0*dimension) / 5.0;
                    hotArea.HorizontalAlignment = HorizontalAlignment.Center;
                    hotArea.VerticalAlignment = VerticalAlignment.Center;
                    hotArea.MouseDown += TileMouseDown;
                    hotArea.MouseMove += TileMouseMove;
                    hotArea.Background = Brushes.Transparent;// Brushes.Red; //
                    hotArea.Tag = tile;

                    tile.Content = hotArea;
                    tiles.Add(tile);
                    TiledGrid.Children.Add(tile);                    
                }
            }
        }

        private static string tileCharacters = "abcdefghijklmnopqrstuvwxyz";
        private static Brush initialColor = Brushes.DarkGreen;
        private static BlurEffect selectedBlur = new BlurEffect { Radius = 10.0 };

        private int numSelectedTiles = 0;

        void TouchLogin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Mouse.Capture(this, CaptureMode.SubTree);
        }

        void TouchLogin_MouseUp(object sender, MouseButtonEventArgs e)
        {
            EndOfDrag();
            Mouse.Capture(null);
        }

        private void EndOfDrag()
        {
            var touchKey = keycode.ToString();

            keycode = new StringBuilder();
            numSelectedTiles = 0;
            foreach (var tile in tiles)
            {
                tile.Tag = false;
                tile.Background = initialColor;
                tile.Effect = null;
            }

            OnTouchKeyEntered(touchKey);
        }

        public Action<string> OnTouchKeyEntered;

        private StringBuilder keycode = new StringBuilder();

        void TileMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                SelectTile((Label)sender);
            }
        }

        void TileMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                SelectTile((Label)sender);
            }            
        }

        private void SelectTile(Label tileHotArea)
        {
            Mouse.Capture(this, CaptureMode.SubTree);

            //check non-active margin of tile
            var tile = (Label)tileHotArea.Tag;

            var isSelected = (Boolean)tile.Tag;

            if (!isSelected)
            {
                tile.Tag = true;
                //do effect
                tile.Effect = new BlurEffect { Radius = 12.0 };
                var g = (byte)128;// (byte)(numSelectedTiles * 10);
                var b = (byte)(numSelectedTiles * 10);
                var r = (byte)(255 - (numSelectedTiles * 10));
                var color = Color.FromRgb(r,g,b);
                tile.Background = new SolidColorBrush(color);
                numSelectedTiles++;

                keycode.Append(tileCharacters[tiles.IndexOf(tile)]);
            }
        }
    }
}
