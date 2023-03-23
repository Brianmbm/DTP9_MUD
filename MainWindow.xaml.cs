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
using static System.Net.Mime.MediaTypeNames;

namespace DTP9_MUD_WPF_stub
{
    public partial class MainWindow : Window
    {
        string imgDir = "..\\..\\..\\images\\";
        public MainWindow()
        {
            string title, text, warn, directions;
            InitializeComponent();
            // Gör all initiering nedanför den här texten!
            Title.Text = "Välkommen till grottan!";
            StoryField.Text = Labyrinth.WarningText()+ "\n--------------\n" + Labyrinth.CurrentTitle()+
                "\n--------------\n" + Labyrinth.CurrentText()+ "\n--------------\n" + Labyrinth.Directions() + "--------------\n"
                + "Tryck 'h' för hjälp,\n'esc' för att sluta!";
            Uri img = new Uri(imgDir+"illusion.png", UriKind.RelativeOrAbsolute);
            MainImage.Source = BitmapFrame.Create(img);
        }
        private void ApplicationKeyPress(object sender, KeyEventArgs e)
        {
            string output = "Key pressed: ";
            output += e.Key.ToString();
            KeyPressDisplay.Text = output;
            //TO QUIT
            if (e.Key == Key.Escape)
            {
                System.Windows.Application.Current.Shutdown();
            }
            /*TODO: Okänd kommando
            "Följande kommandon finns:\n" +
            "  w - gå genom dörren norrut\n" +
            "  s - gå genom dörren söderut\n" +
            "  d - gå genom dörren österut\n" +
            "  a - gå genom dörren västerut\n" +
            "  l - leta\n" +
            "  h - hjälp\n" +
            */
            //NORTH
           else if (e.Key == Key.W)
            {
                Labyrinth.DoCommand("w");
                Title.Text = Labyrinth.CurrentTitle() + "\n--------------\n";
                StoryField.Text =
                    Labyrinth.WarningText() + "\n--------------\n" +
                    Labyrinth.CurrentText() + "\n--------------\n" +
                    Labyrinth.Directions() + "--------------\n";
                Uri img = new Uri(imgDir + "illusion2.png", UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
            //SOUTH
            else if (e.Key == Key.S)
            {
                Labyrinth.DoCommand("s");
                Title.Text = Labyrinth.CurrentTitle() + "\n--------------\n";
                StoryField.Text =
                    Labyrinth.WarningText() + "\n--------------\n" +
                    Labyrinth.CurrentText() + "\n--------------\n" +
                    Labyrinth.Directions() + "--------------\n";
                Uri img = new Uri(imgDir + "illusion2.png", UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
            //EAST
            else if (e.Key == Key.D)
            {
                Labyrinth.DoCommand("d");
                Title.Text = Labyrinth.CurrentTitle() + "\n--------------\n";
                StoryField.Text =
                    Labyrinth.WarningText() + "\n--------------\n" +
                    Labyrinth.CurrentText() + "\n--------------\n" +
                    Labyrinth.Directions() + "--------------\n";
                Uri img = new Uri(imgDir + "illusion2.png", UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
            //WEST
            else if (e.Key == Key.A)
            {
                Labyrinth.DoCommand("a");
                Title.Text = Labyrinth.CurrentTitle() + "\n--------------\n";
                StoryField.Text =
                    Labyrinth.WarningText() + "\n--------------\n" +
                    Labyrinth.CurrentText() + "\n--------------\n" +
                    Labyrinth.Directions() + "--------------\n";
                Uri img = new Uri(imgDir + "illusion2.png", UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
            //SEACH
            else if (e.Key == Key.L)
            {
                Labyrinth.DoCommand("l");
                Title.Text = Labyrinth.CurrentTitle() + "\n--------------\n";
                StoryField.Text =
                    Labyrinth.WarningText() + "\n--------------\n" +
                    Labyrinth.CurrentText() + "\n--------------\n" +
                    Labyrinth.Directions() + "--------------\n";
                Uri img = new Uri(imgDir + "winterbath.png", UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
            //HELP
            else if (e.Key == Key.H)
            {
                Title.Text = Labyrinth.HelpTitle();
                StoryField.Text = Labyrinth.HelpText();
                Uri img = new Uri(imgDir + "winterbath.png", UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
        }
    }
}
