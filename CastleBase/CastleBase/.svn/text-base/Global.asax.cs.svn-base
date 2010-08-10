
using System;

namespace CastleBase
{	
	
	public class Global : System.Web.HttpApplication
	{
		
		protected virtual void Application_Start(Object sender, EventArgs e)
		{
			Castle.ActiveRecord.ActiveRecordStarter.Initialize(typeof(CastleBase.setting).Assembly, Castle.ActiveRecord.Framework.Config.ActiveRecordSectionHandler.Instance);
			//To create the schema automatically
			Castle.ActiveRecord.ActiveRecordStarter.CreateSchema();
		}
		
		protected virtual void Session_Start(Object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_BeginRequest(Object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_EndRequest(Object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_AuthenticateRequest(Object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_Error(Object sender, EventArgs e)
		{
		}
		
		protected virtual void Session_End(Object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_End(Object sender, EventArgs e)
		{
		}
	}
}
