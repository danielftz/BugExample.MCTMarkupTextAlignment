using CommunityToolkit.Maui.Markup;

namespace BugExample_MCTMarkupTextAlignment
{
    public class MainPage : ContentPage
	{
        public MainPage()
        {
            Content = new VerticalStackLayout
            {
                Children =
                {
                    new MyLabel
                    {

                    }.TextCenter(),

                    new MyEntry
                    {

                    }.TextCenter()
                }
            };
                
		}
	}

    public class MyLabel : Label, IMyLabel
    {
        //Bindable property, etc.
        public bool MyProperty { get; set; }
    }

    public interface IMyLabel : ILabel
    {
        public bool MyProperty { get; }
    }


    public class MyEntry : Entry, IMyEntry
    {
        //Bindable property, etc.
        public bool MyProperty { get; set; }
    }

    public interface IMyEntry : IEntry
    {
        public bool MyProperty { get; }
    }
}

