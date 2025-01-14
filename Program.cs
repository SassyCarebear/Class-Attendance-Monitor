using System;
using static System.Console;


namespace Chapter05_Attendee
{
    class Program
    {
        /// <summary>
        ///  Tester class for the Attendee class
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //call our staic method
            WriteLine(Attendee.CalcTotal(10,100));
            //create an instance of our class
            var yotoCompany = new Attendee(); //create an instance of an attendee
            yotoCompany.CoName= "Yoto Company";
            yotoCompany.CoNoAttendee = 7;
            yotoCompany.CoCostPer = 50;
            WriteLine($"The company name is {yotoCompany.CoName}\n");
            WriteLine(yotoCompany);

            //test our fully parametereized constructor
            Attendee goodCo = new Attendee("Good Co", 4, 100m);
            WriteLine($"The company name is {goodCo.CoName}\n");
            WriteLine($"Their total cost will be  {goodCo.CalcTotal():C}");
            WriteLine(goodCo);
        }
    }
}
