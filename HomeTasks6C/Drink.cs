using System;
using System.Collections.Generic;
using System.Text;


namespace HomeTasks6C
{
    public class Drink:Product
    {
        double _alcoholPercent;

        public double AlcoholPercent
        {
            set
            {
                if (value > 0 && value < 100) 
                    _alcoholPercent=value;
            }
            get
            {
                return _alcoholPercent;
            }
        }


    }
}
