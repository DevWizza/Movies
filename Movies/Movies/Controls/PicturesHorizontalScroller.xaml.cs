using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using FFImageLoading.Forms;
using Xamarin.Forms;

namespace Movies.Controls
{
    public partial class PicturesHorizontalScroller : ScrollView
    {
        public DataTemplate DataTemplate { get; set; }

        public static readonly BindableProperty PicturesProperty =
            BindableProperty.Create(nameof(Pictures),
                                        typeof(IList),
                                        typeof(StarRatingsControl),
                                        null,
                                        propertyChanged: OnPropertyChanged);

        public IList Pictures
        {
            get { return (IList)GetValue(PicturesProperty); }
            set { SetValue(PicturesProperty, value); }
        }

        static void OnPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = (PicturesHorizontalScroller)bindable;

            instance.PutPictures((IList)newValue);
        }

        void PutPictures(IList newValue)
        {
            foreach(var picture in newValue)
            {
                var child = (View) DataTemplate.CreateContent();
                child.BindingContext = picture;

                PicturesContainer
                    .Children
                    .Add(child);
            }
        }

        public PicturesHorizontalScroller()
        {
            InitializeComponent();
        }
    }
}
