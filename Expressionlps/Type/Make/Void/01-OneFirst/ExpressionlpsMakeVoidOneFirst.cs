using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SSExpressionlps
    {
        public static void MakeExpressionlpsOneFirstVoid(List<SEExpression> list_EXPRESSION, Boolean lone)
        {
            if (lone is true)
            {
                var list = new List<SEExpression>(list_EXPRESSION);

                list_EXPRESSION.Clear();

                foreach (SEExpression expression_RESULT in list)
                {
                    var match_ONE__FIRST = (expression_RESULT.ExpressionList.Count == 1) is true;

                    if (match_ONE__FIRST is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    var first = expression_RESULT.ExpressionList[0];

                    list_EXPRESSION.Add(first);

                    continue;
                }
            }
            else
                "false".ToString();

            return;
        }
    }
}
