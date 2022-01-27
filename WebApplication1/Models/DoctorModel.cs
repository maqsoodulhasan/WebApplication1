namespace WebApplication1.Models
{
    public class DoctorModel
    {
        //Temperature limits for Celcius
        public static int HypothermiaLimitC = 35;
        public static int FeverLimitC = 37;
        public static int MaxTempLimitC = 43;
        //Temperature limits for Fahrenheit
        public static int HypothermiaLimitFH = 95;
        public static int FeverLimitFH = 98;
        public static int MaxTempLimitFH = 109;
        public static string CheckFeber(int temp, string TempUnit)
        {
            string result = "";
            if (TempUnit == null)
            {
                return "Please select temperature unit and enter value: ";
            }
            if (TempUnit.Equals("Celcius"))
            {
                if (temp < HypothermiaLimitC)
                    result = "Temperature is " + temp + " " + TempUnit + " You have Hypothermia condition.";
                else if (temp >= HypothermiaLimitC && temp <= FeverLimitC)
                    result = "Temperature is " + temp + " " + TempUnit + " You dont have any Fever.";
                else if (temp > FeverLimitC && temp <= MaxTempLimitC)
                    result = "Temperature is " + temp + " " + TempUnit + " You have Fever.";
                else
                    result = "Invalid temperature value";
                return result;
            }
            else if (TempUnit.Equals("Fahrenheit"))
            {
                if (temp < HypothermiaLimitFH)
                    result = "Temperature is " + temp + " " + TempUnit + " You have Hypothermia condition.";
                else if (temp >= HypothermiaLimitFH && temp <= FeverLimitFH)
                    result = "Temperature is " + temp + " " + TempUnit + " You dont have any Fever.";
                else if (temp > FeverLimitFH && temp <= MaxTempLimitFH)
                    result = "Temperature is " + temp + " " + TempUnit + " You have Fever.";
                else
                    result = "Invalid temperature value";
                return result;
            }
            else
                return "Invalid value";

        }
    }
}
