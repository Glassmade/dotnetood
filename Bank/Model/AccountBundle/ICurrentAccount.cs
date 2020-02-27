using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model.AccountBundle
{
    public interface ICurrentAccount
    {
       void updateOverdraft(decimal byAnAmountOf);
    }
}
