//A bank account has a holder name (first name, middle name and last name), available amount of money 
//(balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the 
//variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string firstName = "Stoyan";
        string secondName = "Petev";
        string lastName = "Kirov";
        decimal balance = 5123; //decimal is for money
        string bankname = "BNB";
        string IBAN = "OMEVERYLONGIBAN12412412";
        string BIC = "BNB1412";
        string firstCNumber = "4125153623412412";
        string secondCNumber = "4125153623412412";
        string thirdCNumber = "4125153623412412";
    }
}