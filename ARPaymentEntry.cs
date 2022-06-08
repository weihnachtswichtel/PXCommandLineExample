using PX.Data;
using PX.Objects.CM.Extensions;
using PX.Objects.CS;
using PX.Objects.SO;
using System;
using OrdersToApplyTab = PX.Objects.SO.GraphExtensions.ARPaymentEntryExt.OrdersToApplyTab;
using System.Collections.Generic;
using PX.Objects;
using PX.Objects.AR;

namespace PX.Objects.AR
{
  public class ARPaymentEntry_Extension : PXGraphExtension<PX.Objects.AR.ARPaymentEntry>
  {
    #region Event Handlers

    public PXAction<PX.Objects.AR.ARPayment> DemoAction;
  
    [PXButton(CommitChanges = true)]
    [PXUIField(DisplayName = "Demo Action")]
    protected void demoAction()
    {

    }



    #endregion
  }
}