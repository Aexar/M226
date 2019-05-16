using System;
using System.Collections.Generic;
using System.Text;

namespace PCM
{
    class Client
    {
        private string _name;
        private List <Beverage> _beverages;
        public BillingPlan _billingplan;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List <Beverage> Beverages
        {
            get { return _beverages; }
            set { _beverages = value; }
        }
        public BillingPlan BillingPlan
        {
            get { return _billingplan; }
            set { _billingplan = value; }
        }


        public Client(string pname, BillingPlan pbillingplan)
        {
            this.Name = pname;
            this.BillingPlan = pbillingplan;
            this.Beverages = new List<Beverage>();
        }

        public void Add(Beverage beverage)
        {
            this.Beverages.Add(beverage);
        }

        public float GetBill()
        {
            return this.BillingPlan.GetBill(this.Beverages);
        }
    }
}
