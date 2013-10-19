using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attfire1_assignment2
{
    class Utilities
    {
        public void checkFieldNullLengths(System.Windows.Forms.TextBox field, StringBuilder errors)
        {
            if (field.Text.Length == 0)
            {
                errors.Append("The form field '" + field + "' can't be empty\n");
            }
        }

        //A method to check if a phone number is correct format
        public void phoneNumberValidation(System.Windows.Forms.TextBox field, StringBuilder errors)
        {
            if (MemberInfoGetting.GetMemberName(() => field) != "landlinePhoneField")
            {
                if (field.Text.ToString().Length == 0)
                {
                    checkFieldNullLengths(field, errors);
                }
                else
                {
                    if (field.Text.ToString().Length != 9)
                    {
                        errors.Append("Your landline number must be 9 digits long (with area code), e.g. 034567890.\n");
                    }
                }
            }
            else if (MemberInfoGetting.GetMemberName(() => field) != "mobilePhoneField")
            {
                if (field.Text.ToString().Length == 0)
                {
                    checkFieldNullLengths(field, errors);
                }
                else
                {
                    if (field.Text.ToString().Length != 10 || field.Text.ToString().Length != 11)
                    {
                        errors.Append("Your mobile number must be 10 or 11 digits long, e.g. 0271234567 or 02298765432.\n");
                    }
                }
            }
        }

        //A method to check numeric fields
        public void numericFieldsCheck(System.Windows.Forms.TextBox field, StringBuilder errors)
        {
            if (MemberInfoGetting.GetMemberName(() => field) == "postCodeField")
            {
                if (field.Text.Length > 4 || field.Text.Length < 4)
                {
                    errors.Append("The Postcode field must be a number with 4 integers, e.g. 9012, 9510, 9077, 9092\n");
                }
                else
                {
                    int integer;
                    if (!int.TryParse(field.Text.ToString(), out integer))
                    {
                        errors.Append("The Postcode field must be an integer, e.g. 9012, 9510, 9077, 9092\n");
                    }
                }
            }
            else if (MemberInfoGetting.GetMemberName(() => field) == "ageField")
            {
                int integer;

                if (field.Text.ToString().Length == 0)
                {
                    checkFieldNullLengths(field, errors);
                }
                else if (!int.TryParse(field.Text.ToString(), out integer))
                {
                    errors.Append("The age field must be an integer, e.g. 15, 32, 6, 19.\n");
                }
                else if (int.Parse(field.Text.ToString()) < 5 || int.Parse(field.Text.ToString()) > 130)
                {
                    errors.Append("You must be over 5 years old to enrol, and be a realistic age (below 130).\n");
                }
            }
            else if (MemberInfoGetting.GetMemberName(() => field) == "lessonFeesOwedField" ||
                     MemberInfoGetting.GetMemberName(() => field) == "instrumentFeesOwedField" ||
                     MemberInfoGetting.GetMemberName(() => field) == "totalFeesOwedField")
            {
                if (field.Text.ToString().Length == 0)
                {
                    errors.Append("A amount for lesson fees, instrument fees, and total fees owed.\n");
                }
                else
                {
                    decimal fee;
                    int fee1;
                    if (decimal.TryParse(field.Text.ToString(), out fee) == false || int.TryParse(field.Text.ToString(), out fee1) == false)
                    {
                        errors.Append("The lesson, instrument, and total fees owed must be entered as a decimal or integer, e.g. 40.00 or 50.");
                    }
                }
            }
        }

        //This method uses an inbuilt system component to check
        //if an email address is of a valid format. The methos was 
        //sourced from http://stackoverflow.com/questions/16167983/best-regular-expression-for-email-validation-in-c-sharp
        public bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //This method checks if the email address is in a valid format.
        public void validateEmailField(System.Windows.Forms.TextBox field, StringBuilder errors)
        {
            if (field.Text.ToString().Length == 0)
            {
                checkFieldNullLengths(field, errors);
            }
            else
            {
                if (IsValidEmail(field.Text.ToString()) == false)
                {
                    errors.Append("The email address entered in the '" + field + "' isn't valid. Example is someone@somewhere.com.\n");
                }
            }
        }
    }
}
