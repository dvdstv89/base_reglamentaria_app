using System;

namespace BRapp.Utiles
{
    internal static class FechaUtil
    {
        public static string getLargeText(DateTime fecha)
        {
            int dia = fecha.Day;
            int year = fecha.Year;
            int month = fecha.Month;
            return dia + " de " + getMesCompleto(month) + " de " + year;
        }
        public static string getShortText(DateTime fecha)
        {
            int dia = fecha.Day;
            int year = fecha.Year;
            int month = fecha.Month;
            return dia + " - " + getMesCorto(month) + " - " + year;
        }

        private static string getMesCompleto(int mes)
        {
            switch (mes)
            {
                case 1: return "enero";
                case 2: return "febrero";
                case 3: return "marzo";
                case 4: return "abril";
                case 5: return "mayo";
                case 6: return "junio";
                case 7: return "julio";
                case 8: return "agosto";
                case 9: return "septiembre";
                case 10: return "octubre";
                case 11: return "noviembre";
                case 12: return "diciembre";
                default: return "";
            }           
        }
        private static string getMesCorto(int mes)
        {
            switch (mes)
            {
                case 1: return "ene";
                case 2: return "feb";
                case 3: return "mar";
                case 4: return "abr";
                case 5: return "may";
                case 6: return "jun";
                case 7: return "jul";
                case 8: return "ago";
                case 9: return "sep";
                case 10: return "octe";
                case 11: return "nov";
                case 12: return "dic";
                default: return "";
            }
        }
    }
}
