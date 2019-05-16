using System;
using System.Collections.Generic;
using System.Text;

namespace PCM
{
    class BillingPlanStandard : BillingPlan
    {
        const double DISCOUNT = 0;
        public BillingPlanStandard() : base(DISCOUNT)
        {

        }
    }
}
