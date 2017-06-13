using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCardValidator_conference_
{
    public partial class CreditCardValidator : Form
    {
        public CreditCardValidator()
        {
            InitializeComponent();
        }

        // On-change of text
        private void userValue_TextChanged(object sender, EventArgs e)
        {
            ValidateCreditCard.Enabled = true;
        }

        // On-click of botton
        private void ValidateCreditCard_Click(object sender, EventArgs e)
        {
            string _creditCardNumber, GetCreditCardNumber, verve, master1, master2, visa, american, american1,master3, china;
            // Variable intializing
            verve = "506";
            master1 = "51";
            master2 = "55";
            master3 = "53";
            visa = "4";
            american = "34";
            american1 = "37";
            china = "62";

            // Receive User value from Form 
             _creditCardNumber = Convert.ToString(userValue.Text);

            // Check if creditCardNumber is empty
                if (string.IsNullOrWhiteSpace(_creditCardNumber))
                {
                    MessageBox.Show("Credit card number is Empty, Put a Credit card number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userValue.Focus();
                }
                // check if creditCardNumber contains char like (-)
                if (_creditCardNumber.IndexOf('-') >= 0)
                {
                    // cleans creditCardNumber off (-)
                    string[] temp = _creditCardNumber.Split(new[] { '-' });
                    // delete creditCardNumber and store extracted 
                    // char to temp
                    string creditCard = string.Empty;
                    // using temp as a valid user input
                    foreach (string no in temp)
                    {
                        creditCard += no;
                    }
                    GetCreditCardNumber = creditCard;
                }
                else
                {
                    GetCreditCardNumber = _creditCardNumber;
                }

            // object creation for class GetAndValidate
            var LuhnCheck = new GetAndValidateCreditCard(GetCreditCardNumber);
            // Enable the remaining textboxes
            result.Enabled = true;
            MII.Enabled = true;
            IssuerIdentifier.Enabled = true;

            // Determine card issuer and MII(major industry identifier)
            // Card issuers solving
            // copy three first three char
                string _verve = GetCreditCardNumber.Substring(0, 3);
                if( _verve.Equals(verve))
                {
                    IssuerIdentifier.Text = "Verve Card";
                }

                string _visa = GetCreditCardNumber.Substring(0, 1);
                if(_visa.Equals(visa))
                {
                    IssuerIdentifier.Text = "Visa Card";
                }

                string _master = GetCreditCardNumber.Substring(0, 2);
                if(_master.Equals(master1) || _master.Equals(master2) || _master.Equals(master3))
                {
                    IssuerIdentifier.Text = "Master Card";
                }

                string _american = GetCreditCardNumber.Substring(0, 2);
                if(_american.Equals(american) || _american.Equals(american1))
                {
                    IssuerIdentifier.Text = "American Express Card";
                }

                string _china = GetCreditCardNumber.Substring(0, 2);
                if(_china.Equals(china))
                {
                    IssuerIdentifier.Text = "China UnionPay Card";
                }
           
            // MII solving
                // copy the first char
                int temp2 = int.Parse(GetCreditCardNumber.Substring(0, 1));
                // Get MII
                switch (temp2)
                {
                    case 0:
                        MII.Text = "ISO/TC 68 Industry";
                        break;
                    case 1:
                        MII.Text = "Airlines Industry";
                        break;
                    case 2:
                        MII.Text = "Airlines Industry";
                        break;
                    case 3:
                        MII.Text = "Travel and Entertainment Industry";
                        break;
                    case 4:
                        MII.Text = "Banking and Financial Industry";
                        break;
                    case 5:
                        MII.Text = "Banking and Financial Industry";
                        break;
                    case 6:
                        MII.Text = "Merchandizing Industry";
                        break;
                    case 7:
                        MII.Text = "Petroleum Industry";
                        break;
                    case 8:
                        MII.Text = "Telecommunications Industry";
                        break;
                    case 9:
                        MII.Text = "National assignment";
                        break;
                    default:
                        MII.Text = "No MII yet";
                        break;
                }
           // Display the result to the textbox
            result.Text = LuhnCheck.ValidateCreditCard();
        }
    }
}
