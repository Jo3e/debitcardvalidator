using System;
using System.Text;
using System.Windows.Forms;

namespace CreditCardValidator_conference_
{
    class GetAndValidateCreditCard
    {
        /// <summary>
        /// Description of GetAndValidate.
        /// </summary>
            string CreditCardNumber;
            string temp;
            string textOutPut;

                // constructor
            public GetAndValidateCreditCard(string creditCardNumber)
            {
                CreditCardNumber = creditCardNumber;
            }

            //validate credit card
            public string ValidateCreditCard()
            {
                int[] digit = new int[CreditCardNumber.Length];

                for (int len = 0; len < CreditCardNumber.Length; len++ )
                {
                    digit[len] = int.Parse(CreditCardNumber.Substring(len, 1));
                }

                int sum = 0;
                bool alt = false;
                // Removing the last digit(checksum digit)
                for (int i = digit.Length - 1; i >= 0; i--)
                {
                    // Temp store the digit
                    int currentDigit = digit[i];
                    // When the bool is false
                    // which is the default cos i declared it
                    if (alt)
                    {
                        // multiply the currentDigit by 2
                        currentDigit *= 2;
                        if (currentDigit > 9)
                        {
                            currentDigit -= 9;
                        }
                    }
                    sum += currentDigit;
                    alt = !alt;
                }

                // If sum equals 0, the number is good and this will return true
                if(sum % 10 == 0)
                {
                    temp = Convert.ToString(sum);
                    textOutPut = "The credit card is valid";
                    temp = textOutPut;
                }
                else
                {
                    temp = Convert.ToString(sum);
                    textOutPut = "The credit card is not valid";
                    temp = textOutPut;
                }
                return temp;
            }

            //get and set CreditCardNumber public
            public string _CreditCard
            {
                get
                {
                    return CreditCardNumber;
                }
                set
                {
                    // check whether creditcard is empty
                    if (CreditCardNumber == null)
                        MessageBox.Show("Please fill the credit card Number");
                    else
                        CreditCardNumber = value;
                }
            }
        }
}