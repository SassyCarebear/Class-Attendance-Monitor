using System;
using static System.Console;
/*
    Program:    Attendee
    Developer:  Cara Jones  
    Date:       03/02/2022
    Purpose:    
*/

namespace Chapter05_Attendee
{

    public class Attendee
    {
#region -------------Private Data Elements----------------
        //static variable only exists only once- no matter how many instances
        static private int nextCoNumber = 1;    // the next available unique company number
        private int coNumber;                   //unique number for this company
        private string coName;                  //name of company
        private int coNoAttend;                 //how many attendees (up to 10)
        private decimal coCostPer;              //cost per company

#endregion
#region ----------------Getters/Setters-------------------
        public int CoNumber
        {
            get{return coNumber;}
            //set{coNumber = value;}   read only - no setter
        }//end CoNumber
        public string CoName
        {
            get{return coName;}
            set{coName = value;}
        }//end CoName
        public int CoNoAttendee
        {
            get{return coNoAttend;}
            set{coNoAttend = value;}
        }//end CoNoAttendee
        public decimal CoCostPer
        {
            get{return coCostPer;}
            set{coCostPer= value;}
        }//end CoCostPer
#endregion

#region ------------------Constructors--------------------
    //constructor creates an instance of our class
    public Attendee()
    {
        coNumber = nextCoNumber++;
        coName = "default";
        coNoAttend = -1;
        coCostPer = -1;
    }//end of default constructor
/// <summary>
/// Construct an attendee with all parameters
/// </summary>
/// <param name="coName"></param>
/// <param name="coNoAttend"></param>
/// <param name="coCostPer"></param>
    public Attendee(string coName, int coNoAttend, decimal coCostPer)
    {
        this.coNumber = nextCoNumber++;
        this.coName = coName;
        this.coNoAttend = coNoAttend;
        this.coCostPer = coCostPer;
    }
    
#endregion

#region --------------------Methods-----------------------
/// <summary>
/// calculate the total cost o attendance for the company
/// </summary>
/// <returns>totalCost</returns>
    public decimal CalcTotal()
    {
        return CalcTotal(coNoAttend, CoCostPer);
    }// end of method CalcTotal
    /// <summary>
    /// static total method to calculate the total cost of attendance for this company
    /// </summary>
    /// <param name="numAttend"></param>
    /// <param name="costPer"></param>
    /// <returns></returns>
    public static decimal CalcTotal(int numAttend, decimal costPer)
    {
        return numAttend * costPer;
    }
/// <summary>
/// override system object ToString to output a string value
/// </summary>
/// <returns>string</returns>
    public override string ToString()
    {
        return string.Format($"Company Number:           {coNumber} \n" +
                            $"Company:                  {coName}  \n" + 
                            $"Number of attendees:      {coNoAttend} \n" +
                            $"Cost per attendee:        {coCostPer} \n\n"
            );
    }
#endregion

    }//end class Attendee

}//end namespace
