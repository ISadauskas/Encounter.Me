
namespace BusinessLogic
{
   public class Mets
    {
        public double MetWalkedValue(double Speed)
        {
            switch (Speed)
            {
                case <= 3:
                        return 3;
                case <= 4:
                        return 3.5;
                case  <= 5:
                        return 4;
                case <= 6:
                        return 4.5;
                case <= 7:
                        return 5;
                case <= 8:
                        return 5.5;
                case <= 9:
                        return 6;
                case <= 10:
                        return 6.5;
            }
            return 0;
         }
        public double MetRanValue(double Speed)
        {
            switch (Speed)
            {
                case <= 6:
                    return 7;
                case <= 7:
                    return 7.5;
                case <= 8:
                    return 8.5;
                case <= 9:
                    return 9.5;
                case <= 10:
                    return 10.5;
                case <= 11:
                    return 11.5;
                case <= 12:
                    return 12.5;
                case <= 13:
                    return 13.5;
                case <= 14:
                    return 14.5;
            }
            return 0;
        }
    }
}
