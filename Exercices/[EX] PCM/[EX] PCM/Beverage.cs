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
        private DateTime _timestamp;

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
        private DateTime TimeStamp
        {
            get { return _timestamp; }
            set { _timestamp = value; }
        }

        public Beverage(string pname, float pprice, float pvolume)
        {
            this.Name = pname;
            this.Price = pprice;
            this.Volume = pvolume;
            this.Percentage = 0;
            this.TimeStamp = DateTime.Now;
        }

        public Beverage(string pname, float pprice, float pvolume, float ppercentage):this(pname,pprice,pvolume)
        {
            this.Percentage = ppercentage;
            this.TimeStamp = DateTime.Now;
        }
    }
}
