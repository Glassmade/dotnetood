using System;


namespace Bank.Model.AccountBundle
{
    public interface IHolidaysAccount
    {
        Decimal expodentialCredit(Decimal inputFunds, DateTime inputDateTime);
    }
}
