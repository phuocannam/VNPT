﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuanLySach.Startup))]
namespace QuanLySach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
