using System;

using Xamarin.Forms;

namespace XamarinFormsGestureRecognizers
{
	public class MyTabbedPage : TabbedPage
	{
		public MyTabbedPage ()
		{
			this.Children.Add (new ContentPage1 ());
			this.Children.Add (new ContentPage2 ());
		}
		                
	}
}


