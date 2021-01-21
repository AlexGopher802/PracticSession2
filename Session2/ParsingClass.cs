using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Session2
{
    public class ParsingClass : DataClass
    {
        public string action { get; set; }
        public DateTime date { get; set; }
        public TimeSpan time { get; set; }
        public int flightNumber { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public int aircraftId { get; set; }
        public int price { get; set; }
        public string confirmed { get; set; }
        public StatusCode status { get; }
        public enum StatusCode
        {
            Succes,
            Duplicate,
            NotCorrect,
            Correct
        }

        //string[] mainStr = str.Split(new char[] { ',' });
        public ParsingClass(string str)
        {
            if(ValidStrParse(str) == StatusCode.Correct)
            {
                string[] mainStr = str.Split(new char[] { ',' });
                this.action = mainStr[0];
                this.date = DateTime.Parse(mainStr[1]);
                this.time = TimeSpan.Parse(mainStr[2]);
                this.flightNumber = Convert.ToInt32(mainStr[3]);
                this.from = mainStr[4];
                this.to = mainStr[5];
                this.aircraftId = Convert.ToInt32(mainStr[6]);
                this.price = Convert.ToInt32(mainStr[7]);
                this.confirmed = mainStr[8];
            }
        }

        /*private ParsingClass(StatusCode status)
        {
            this.status = status;
        }*/

        private StatusCode ValidStrParse(string str)
        {
            string[] mainStr = str.Split(new char[] { ',' });
            if (mainStr.Length != 8) { return StatusCode.NotCorrect; }
            if ((mainStr[0] != "ADD") && (mainStr[0] != "EDIT")) { return StatusCode.NotCorrect; }
            DateTime dt = new DateTime();
            if (!DateTime.TryParse(mainStr[1], out dt)) { return StatusCode.NotCorrect; }
            TimeSpan ts = new TimeSpan();
            if (!TimeSpan.TryParse(mainStr[2], out ts)) { return StatusCode.NotCorrect; }
            int flight = 0;
            if (!int.TryParse(mainStr[3], out flight)) { return StatusCode.NotCorrect; }
            List<string> listAirports = GetListItems("select IATACode from Airports");
            if (!listAirports.Contains(mainStr[4])) { return StatusCode.NotCorrect; }
            if (!listAirports.Contains(mainStr[5])) { return StatusCode.NotCorrect; }
            List<string> listAircrafts = GetListItems("select id from Aircrafts");
            if (!listAircrafts.Contains(mainStr[6])) { return StatusCode.NotCorrect; }
            int price = 0;
            if (!int.TryParse(mainStr[7], out price)) { return StatusCode.NotCorrect; }
            if ((mainStr[8] != "OK") && (mainStr[8] != "CANCELED")) { return StatusCode.NotCorrect; }
            return StatusCode.Correct;
        }
    }
}
