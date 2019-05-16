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
            return 0;
        }
    }
}
