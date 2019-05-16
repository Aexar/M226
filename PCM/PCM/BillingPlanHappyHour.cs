using System;
using System.Collections.Generic;
using System.Text;

namespace PCM
{
    class BillingPlanHappyHour : BillingPlan
    {
        const double DISCOUNT = 50;
        public BillingPlanHappyHour(): base(DISCOUNT)
        {

        }
    }
}
