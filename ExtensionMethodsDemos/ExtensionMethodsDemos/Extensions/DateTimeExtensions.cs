using System.Globalization;


namespace System
{
    internal static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan ts = DateTime.Now.Subtract(thisObj);

            if (ts.TotalHours < 24.0)
            {
                return ts.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Hours";
            }
            else
            {
                return ts.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Days";
            }
        }
    }
}
