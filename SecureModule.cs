﻿namespace Nancy.Demo.Authentication.Basic
{
    using Nancy.Security;

	public class SecureModule : NancyModule
	{
		public SecureModule()
			: base("/secure")
		{
            this.RequiresAuthentication();

			Get["/"] = x =>
			{
				return "Hello " + Context.CurrentUser.UserName;
			};
		}
	}
}