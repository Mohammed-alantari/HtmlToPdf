using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HtmlToPdf.Models
{
    public class DevSettings
    {

        private static DevName name = DevName.Mohammed;
        private static DevDb db = DevDb.local;

        public static string DevConnectionStrings()
        {
            switch (db)
            {
                case DevDb.Hobbyst:
                    return "Data Source=tcp:hobbystsqlserver.database.windows.net,1433;Initial Catalog=HobbystDB;User ID=HobbystAdmin;Password=1223!@@#qwweQWWE";
                case DevDb.local:
                    return "Server=(localdb)\\mssqllocaldb;Database=HobbystDB;Trusted_Connection=True;MultipleActiveResultSets=true";
                default:
                    return "";
            }
        }
    }
    public enum DevName
    {
        Mohammed
    }
    public enum DevDb
    {
        Hobbyst,
        local
    }


}

