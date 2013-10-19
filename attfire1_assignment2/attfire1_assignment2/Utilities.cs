using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attfire1_assignment2
{
    class Utilities
    {
        public void checkFieldNullLengths(System.Windows.Forms.TextBox field, StringBuilder errors, string fieldName)
        {
            if (field.Text.Length == 0)
            {
                errors.Append("The form field '" + fieldName + "' can't be empty\n");
            }
        }

        //public void checkFieldNullLengths(System.Windows.Forms.TextBox field, StringBuilder errors)
        //{
        //    if (field.Text.Length == 0)
        //    {
        //        errors.Append("The form field '" + fieldName + "' can't be empty\n");
        //    }
        //}

        //A method to check if a phone number is correct format
        public void landlineNumberValidation(System.Windows.Forms.TextBox field, StringBuilder errors)
        {
            if (field.Text.ToString().Length == 0)
            {
                checkFieldNullLengths(field, errors, "Landline Phone");
            }
            else
            {
                if (field.Text.ToString().Length != 9)
                {
                    errors.Append("Your landline number must be 9 digits long (with area code), e.g. 034567890.\n");
                }
            }
        }

        public void mobileNumberValidation(System.Windows.Forms.TextBox field, StringBuilder errors)
        {
            if (field.Text.ToString().Length == 0)
            {
                checkFieldNullLengths(field, errors, "Mobile Phone");
            }
            else //0276898765
            {
                if (field.Text.Length > 11|| field.Text.Length < 10)
                {
                    errors.Append("Your mobile number must be 10 or 11 digits long, e.g. 0271234567 or 02298765432.\n");
                }
            }
        }

        //A method to check the postcode field for valid input
        public void postCodeFieldCheck(System.Windows.Forms.TextBox field, StringBuilder errors)
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
        //A method to check the age field for valid input
        public void ageFieldCheck(System.Windows.Forms.TextBox field, StringBuilder errors)
        {
            int integer;

            if (field.Text.ToString().Length == 0)
            {
                checkFieldNullLengths(field, errors, "Age");
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

        //A method to check the postcode field for valid input
        public void lessonFeesFieldCheck(System.Windows.Forms.TextBox field, StringBuilder errors)
        {
            if (field.Text.ToString().Length == 0)
            {
                errors.Append("An amount for lesson fees owed must be entered.\n");
            }
            else
            {
                decimal fee;
                int fee1;
                if (decimal.TryParse(field.Text.ToString(), out fee) == false || int.TryParse(field.Text.ToString(), out fee1) == false)
                {
                    errors.Append("The lesson fees owed must be entered as a decimal or integer, e.g. 40.00 or 50.\n");
                }
            }
        }

        //A method to check the Instrument Fees Owed field for valid input
        public void instrumentFeesFieldCheck(System.Windows.Forms.TextBox field, StringBuilder errors)
        {
            if (field.Text.ToString().Length == 0)
            {
                errors.Append("An amount for instrument fees owed must be entered.\n");
            }
            else
            {
                decimal fee;
                int fee1;
                if (decimal.TryParse(field.Text.ToString(), out fee) == false || int.TryParse(field.Text.ToString(), out fee1) == false)
                {
                    errors.Append("The instrument fees owed must be entered as a decimal or integer, e.g. 40.00 or 50.\n");
                }
            }
        }

        //A method to check the Total Fees Owed field for valid input
        public void totalFeesFieldCheck(System.Windows.Forms.TextBox field, StringBuilder errors)
        {
            if (field.Text.ToString().Length == 0)
            {
                errors.Append("An amount for total fees owed must be entered.\n");
            }
            else
            {
                decimal fee;
                int fee1;
                if (decimal.TryParse(field.Text.ToString(), out fee) == false || int.TryParse(field.Text.ToString(), out fee1) == false)
                {
                    errors.Append("The total fees owed must be entered as a decimal or integer, e.g. 40.00 or 50.\n");
                }
            }
        }

        //This method uses an inbuilt system component to check
        //if an email address is of a valid format. The method was 
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
                checkFieldNullLengths(field, errors, "Email Address");
            }
            else
            {
                if (IsValidEmail(field.Text.ToString()) == false)
                {
                    errors.Append("The email address entered isn't valid. Example is someone@somewhere.com.\n");
                }
            }
        }

        //This method is used to check if a value has been selected
        //from a dropdown (combobox) box.
        public void checkDropdownBox(System.Windows.Forms.ComboBox dropdown, StringBuilder errors, string dropDown)
        {
            if (dropdown.Text.ToString().Length == 0)
            {
                errors.Append("You must select a value from the '" + dropDown + "' dropdown box.\n");
            }
        }

        //This method checks to see if a selection has been made from a listBox, and 
        //informs the user if not.
        public void checkListBox(System.Windows.Forms.ListBox listbox, StringBuilder errors, string listBox)
        {
            if (listbox.SelectedIndex == -1)
            {
                errors.Append("You must select at least one record from the '" + listBox + "' list box.\n");
            }
        }

        static string GetName<T>(T item) where T : class
        {
            var properties = typeof(T).GetProperties();
            return properties[0].Name;
        }
    }
}
