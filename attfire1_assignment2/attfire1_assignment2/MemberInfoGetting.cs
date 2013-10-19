using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    //Method to get name of a variable, thanks to the following URL:
    //http://stackoverflow.com/questions/9801624/get-name-of-a-variable-or-parameter
    //
    static class MemberInfoGetting
    {
        public static string GetMemberName<T>(Expression<Func<T>> memberExpression)
        {
            MemberExpression expressionBody = (MemberExpression)memberExpression.Body;
            return expressionBody.Member.Name;
        }
    }
}
