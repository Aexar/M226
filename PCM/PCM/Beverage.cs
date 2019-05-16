using System;
using System.Collections.Generic;
using System.Text;

namespace PCM
{
    public class Beverage
    {
        private string _name;
        private float _price;
        private float _percentage;
        private float _volume;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public float Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }
        public float Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }

        public Beverage(string pname, float pprice, float pvolume)
        {
            this.Name = pname;
            this.Price = pprice;
            this.Volume = pvolume;
        }

        public Beverage(string pname, float pprice, float pvolume, float ppercentage):this(pname,pprice,pvolume)
        {
            this.Percentage = ppercentage;
        }
    }
}
