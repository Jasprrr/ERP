using System;
using MvvmLight3.Model;

namespace MvvmLight3.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to create design time data
        }
    }
}