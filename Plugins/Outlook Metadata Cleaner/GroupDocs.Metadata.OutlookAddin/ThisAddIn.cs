﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using stdole;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Office.Interop.Outlook;

namespace GroupDocs.Metadata.OutlookAddin
{
    public partial  class ThisAddIn
    {
                
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
                         
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {

        }
                       
        protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return new Ribbon1();
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion


    }
}
