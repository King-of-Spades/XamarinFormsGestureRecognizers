using System;

using Xamarin.Forms;

namespace XamarinFormsGestureRecognizers
{
	public class ContentPage1 : ContentPage
	{
		public ContentPage1 ()
		{
			
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage1" }
				}
			};
		}
	}
}


