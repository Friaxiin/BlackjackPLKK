using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BlackjackPLKK
{
    public partial class MainPage : ContentPage
    {
        public string[] Values = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        public string[] Colors = { "♠", "♥", "♣", "♦" };
        public int UserScoreSum = 0;
        public int EnemyScoreSum = 0;
        public Dictionary<string, int> CardValueDictionary = new Dictionary<string, int>()
        {
            {"A", 1},
            {"2", 2},
            {"3", 3},
            {"4", 4},
            {"5", 5},
            {"6", 6},
            {"7", 7},
            {"8", 8},
            {"9", 9},
            {"10", 10},
            {"J", 11},
            {"Q", 12},
            {"K", 13}
        };

        public MainPage()
        {
            InitializeComponent();

        }

        public void DrawCardUser()
        {
            //Random
            Random rand = new Random();

            int cardValueIndex = rand.Next(0, 12);
            int cardColorIndex = rand.Next(0, 3);

            Card card = new Card();
            card.CardValue = Values[cardValueIndex];
            card.CardColor = Colors[cardColorIndex];

            //Labels
            Label cardColorLbl = new Label()
            {
                Text = card.CardColor.ToString(),
                FontSize = 16,
                HorizontalTextAlignment = TextAlignment.Start, 
                VerticalTextAlignment = TextAlignment.Start,

            };
            Label cardValueLbl = new Label()
            {
                Text = card.CardValue.ToString(),
                FontSize = 24,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
            };


            //Layout
            StackLayout UserCardLayout = new StackLayout()
            {
                WidthRequest = 70,
                HeightRequest = 100,
                BackgroundColor = Color.White,
                Orientation = StackOrientation.Horizontal,
                Margin = new Thickness(0,0,10,0),
                HorizontalOptions = LayoutOptions.Start
            };

            UserCardLayout.Children.Add(cardColorLbl);
            UserCardLayout.Children.Add(cardValueLbl);


        }

    }
}
