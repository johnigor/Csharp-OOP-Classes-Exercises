using System.Globalization;

namespace System //Se definir a classe como namespace system, não há necessidade de usar outro namespace (para ter acesso ao metodo) no programa principal 
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj); //subtrai a data do objeto pela hora de agora

            if (duration.TotalHours < 24)
            {
                //se menor que 24 horas - formato em horas
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours.";
            }
            else
            {
                //se maior que 24 horas - formato em dias
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days.";
            }
        }
    }
}
