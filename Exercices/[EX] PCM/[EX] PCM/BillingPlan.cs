using System;
using System.Collections.Generic;
using System.Text;

namespace PCM
{
    public class BillingPlan
    {
        private double _discount;

        public double Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        public BillingPlan(double pdiscount)
        {
            this.Discount = pdiscount;
        }

        virtual public float GetBill(List<Beverage> pbeverages)
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
