﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace asp_net
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            Application["Aplicaciones"] = 0;
            Application["SesionesUsuario"] = 0;
            //Incrementemos
            Application["Aplicaciones"] = (int)Application["Aplicaciones"] + 1;
        }
        void Session_Start(object sender,EventArgs e)
        {
            Application["SesionesUsuario"] = (int)Application["SesionesUsuario"] + 1;
        }
        void Session_End(object sender,EventArgs e)
        {
            Application["SesionesUsuario"] = (int)Application["SesionesUsuario"] - 1;
        }
        
    }
}