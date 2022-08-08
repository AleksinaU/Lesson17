using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{
    public class Count<T>
    {
        private T Account { get; set; }
        private double BalanceSheet { get; set; }
        private string FullName { get; set; }
        
        public Count(T account, double balancesheet, string fullname)
        {
            Account = account;
            BalanceSheet = balancesheet;
            FullName = fullname;
        }
        public string GetInfo()
        {
            return $"{Account} {BalanceSheet} {FullName}";
        }
    }
}
