using Microsoft.Owin;
using Owin;
using System;

[assembly: OwinStartupAttribute(typeof(BangHangOnline.Startup))]
namespace BangHangOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
