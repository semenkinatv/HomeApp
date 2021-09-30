using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MergeGridPage : ContentPage
    {
        public MergeGridPage()
        {
            InitializeComponent();
            //ScanOutside();
            Grid grid = new Grid
            {
                // Набор строк 
                RowDefinitions =
              {
                  new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                  new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                  new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
               }
            };
            AddBlock(grid, Color.LightBlue, "InSide", "+ 25 °C", 0, 0);
            AddBlock(grid, Color.LightBlue, "OutSide", "- 15 °C", 0, 1);
            AddBlock(grid, Color.LightBlue, "Time", "12:12", 0, 2);

            Content = grid;
        }
        public void AddBlock(Grid grid, Color color,string textName, string textTemp, int x, int y)
        {

            grid.Children.Add(
                // Создаем прямоугольник заданного цвета
                new BoxView { Color = color },
                // Задаем его местоположение и размеры
                x, y);
            grid.Children.Add(
               new Label
               {
                   Text = textName,
                   VerticalTextAlignment = TextAlignment.Start,
                   HorizontalTextAlignment = TextAlignment.Center,
                   FontSize = 36,
                   TextColor = Color.Yellow
               },
               x, y);
            grid.Children.Add(
               new Label
               {
                   Text = textTemp,
                   VerticalTextAlignment = TextAlignment.Center,
                   HorizontalTextAlignment = TextAlignment.Center,
                   FontSize = 60,
                   TextColor = Color.Yellow
               }, x, y);

           
        }

    
    }
}