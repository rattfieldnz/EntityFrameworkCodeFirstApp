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
                if (field.Text.ToString().Length == 0)
                {
                    errors.Append("You must enter your age\n");
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
    }

    //Method to get name of a variable, thanks to the following URL:
    //http://stackoverflow.com/questions/9801624/get-name-of-a-variable-or-parameter
    //
    private static class MemberInfoGetting
    {
        public static string GetMemberName<T>(Expression<Func<T>> memberExpression)
        {
            MemberExpression expressionBody = (MemberExpression)memberExpression.Body;
            return expressionBody.Member.Name;
        }
    }
}
