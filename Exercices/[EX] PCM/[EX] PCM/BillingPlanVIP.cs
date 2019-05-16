using System;
using System.Collections.Generic;
using System.Text;

namespace PCM
{
    class BillingPlanVIP : BillingPlan
    {
        public BillingPlanVIP(double pdiscount) : base(pdiscount)
        {

        }

        public override float GetBill(List<Beverage> pbeverages)
        {
            float bill = 0;

            pbeverages.ForEach(delegate (Beverage beverage) {
                bill += beverage.Price;
            });

            bill = bill - (bill / 100 * (float)this.Discount);
            return bill;
        }
    }
}
