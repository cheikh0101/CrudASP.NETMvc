﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AtelierGlMvc.Startup))]
namespace AtelierGlMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
