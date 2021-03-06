﻿using System.Management.Automation;
using Microsoft.SharePoint.Client;

using PnP.PowerShell.Commands.Base;

namespace PnP.PowerShell.Commands
{
    [Cmdlet(VerbsCommon.Clear, "TenantAppCatalogUrl")]
    public class ClearTenantAppCatalogUrl : PnPAdminCmdlet
    {
        protected override void ExecuteCmdlet()
        {
            var settings = TenantSettings.GetCurrent(ClientContext);
            settings.ClearCorporateCatalog();
            ClientContext.ExecuteQueryRetry();
        }
    }
}