using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Movies.Controls
{
    public partial class StarRatingsControl : StackLayout
    {
        public static readonly BindableProperty ScoreProperty =
            BindableProperty.Create(nameof(Score),
                                        typeof(int),
                                        typeof(StarRatingsControl),
                                        0,
                                        propertyChanged: OnPropertyChanged);
        
        public int Score
        {
            get { return (int)GetValue(ScoreProperty); }
            set { SetValue(ScoreProperty, value); }
        }

        static void OnPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (StarRatingsControl)bindable;

            instance.DrawStars((int)newValue);
        }

        void DrawStars(int howMany)
        {
            if (howMany == 0)
                return;
            
            for (var starCount = 1; starCount <= howMany; starCount++)
            {
                Children.Add(new Image
                {
                    HeightRequest = 16,
                    WidthRequest = 16,
                    Source="full_star"
                });
            }

            var howManyLeft = 5 - howMany;

            for (var left = 1; left <= howManyLeft; left++)
            {
                Children.Add(new Image
                {
                    HeightRequest = 20,
                    WidthRequest = 20,
                    Source = "empty_star"
                });
            }
        }

        public StarRatingsControl()
        {
            InitializeComponent();
        }
    }
}
