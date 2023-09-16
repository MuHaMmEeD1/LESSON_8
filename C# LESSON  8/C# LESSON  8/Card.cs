using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_8
{
    public class Card
    {
        public Card(string bankname, string fullname, string pAN, string pIN, string cVC, DateTime expireDate, decimal balans)
        {
            Bankname = bankname;
            Fullname = fullname;
            PAN = pAN;
            PIN = pIN;
            CVC = cVC;
            ExpireDate = expireDate;
            Balans = balans;
        }

        public Card(string v) { }

        public string Bankname { get; set; }
        public string Fullname { get; set; }

        string pan;
        public string PAN
        {

            get { return pan; }

            set
            {

                bool yoxla = true;

                for (int i = 0; i < value.Length; i++)
                {

                    if (!((int)value[i] > 47 && (int)value[i] < 58)) { yoxla = false; break; }
                }
                try
                {
                    if (yoxla && value.Length == 16) { pan = value; }
                    else { throw new PANException(); }
                }
                catch (PANException ex)
                {
                    Console.WriteLine(ex.Message);

                }

            }
        }

        string pin;
        public string PIN
        {

            get { return pin; }

            set
            {
                bool yoxla = true;

                for (int i = 0; i < value.Length; i++)
                {

                    if (!((int)value[i] > 47 && (int)value[i] < 58)) { yoxla = false; break; }
                }
                try
                {
                    if (yoxla && value.Length == 4) { pin = value; }
                    else { throw new PINException(); }
                }
                catch (PINException ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
        }

        string cvc;


        public string CVC
        {

            get { return cvc; }

            set
            {

                bool yoxla = true;

                for (int i = 0; i < value.Length; i++)
                {

                    if (!((int)value[i] > 47 && (int)value[i] < 58)) { yoxla = false; break; }
                }
                try
                {
                    if (yoxla && value.Length == 3 && value[0] != '0') { cvc = value; }
                    else { throw new CVCException(); }
                }
                catch (CVCException ex)
                {
                    Console.WriteLine(ex.Message);

                }

            }
        }



        public DateTime ExpireDate { get; set; }


        public decimal Balans { get; set; }



        public void show()
        {

            Console.WriteLine($"Bankname: {Bankname}");
            Console.WriteLine($"Fullname: {Fullname}");
            Console.WriteLine($"Balans: {Balans}");

        }

    }
}