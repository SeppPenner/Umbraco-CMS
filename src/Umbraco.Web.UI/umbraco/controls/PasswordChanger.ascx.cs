﻿using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Umbraco.Web.UI.Umbraco.Controls
{
    public partial class PasswordChanger : global::umbraco.controls.passwordChanger
    {
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            this.DataBind();
        } 

       
    }
}