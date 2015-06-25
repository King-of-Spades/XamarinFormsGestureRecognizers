using System;

using Xamarin.Forms;

namespace XamarinFormsGestureRecognizers
{
	public class ContentPage2 : ContentPage
	{
		public ContentPage2 ()
		{
			
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage2" }
				}
			};
			Title = "Content Page 2";
		}
	}
}


