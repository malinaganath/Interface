using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
   
    interface IOfferNew
    {
        string GetMyOffer();
    }
    interface IAccount : IOfferNew
    {
        int MyProperty { get; set; }

        double GetBalance();
        bool Save();
    }
    class Program : IAccount
    {
        public int MyProperty
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public double GetBalance()
        {
            return 100;
        }
        public bool Save()
        {
            return true;
        }
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        public string GetMyOffer()
        {
            return "You Not Have any Offer";
        }



    }

    class Test
    {
        string a = "I am Naga";
        bool values;

        void Test1()
        {
            GetTempResult();
        }

        private void GetTempResult()
        {
            if (a.Contains("Naga"))
                values = true;
        }
    }
}

