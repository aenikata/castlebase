
using System;
using Castle.MonoRail.Framework;

namespace CastleBase
{

	[Layout("default"), Rescue("generalerror")]
	public class HomeController : SmartDispatcherController
	{

		public HomeController ()
		{
		}
		
		public void Index()
		{
			
		}
		
		public void DataToTheView()
		{
			PropertyBag["name"] = "Steve Jobs";
			PropertyBag["today"] = DateTime.Now;
			
			RenderView("data");
		}
		
		public void ThrowException()
		{
			throw new Exception("I'm a bad action");	
		}
		
		public void AddSetting()
		{
			setting newsetting = new setting(){ Name="Test", Value="Test Value"};
			newsetting.SaveAndFlush();
			PropertyBag["PropertyID"] = newsetting.Id;
			RenderView("addedsetting");
		}
	}
}
