using System;
using System.Collections.Generic;
using System.Text;

namespace ClockArrowsAngle
{
    public class ClockArrows
    {
        public int CalculateAngle(double hours, double minutes)
        {
            if(hours < 0 || hours > 12 ||
               minutes < 0 || minutes > 60)
            {
                throw new ArgumentException("Input is invalid");
            }

            if (hours == 12) hours = 0;
            if (minutes == 60) minutes = 0;

            // 0.5 degree per a minute
            int angleForHour = (int)(360 / 12 * hours);

            // 6 degree per a minute 
            int angleForMinute = (int)(360 / 60 * minutes);

            int angle;

            if(angleForHour > angleForMinute)
            {
                angle = 360 - (angleForHour - angleForMinute);
            }
            else
            {
                angle = angleForMinute - angleForHour;
            }

            return angle;
        }
    }
}
