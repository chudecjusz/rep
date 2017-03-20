using System;
using HOST.IVENDinvoice.Invoices.Model;

namespace HOST.IVENDinvoice.Invoices.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to create design time data

            var item = new DataItem("Welcome to MVVM Light [design]");
            callback(item, null);
        }
    }
}