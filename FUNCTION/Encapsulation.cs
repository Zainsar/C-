using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNCTION
{
    //public class bank
    //{
    //    int acc = 200000;
    //    int accountno = 1452158555;
    //    String Name = "Syed Muhammad Zain Sarfraz";
    //    public void setacc(int account , int accno , string fname)
    //    {
    //        acc = account;
    //        accountno = accno;
    //        Name = fname;
    //    }
    //    public void getacc()
    //    {
    //        Console.WriteLine($"Account Title :- {Name} \n\n Account no :- {accountno} \n\n Your Account balance is {acc}");
    //    }

        public class bank
        {
           public int acc = 2000;

            public int number
            {
                set
                {
                    acc = value;
                }
                get
                {
                    return acc;
                }
            }

    }
    internal class Encapsulation
    {
    }
}
