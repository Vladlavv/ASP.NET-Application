﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(W2022A6VO.Startup))]

namespace W2022A6VO
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			ConfigureAuth(app);
		}
	}
}
