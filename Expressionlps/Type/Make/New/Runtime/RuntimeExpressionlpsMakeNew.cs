using Core;

namespace Core.Shared
{
    using System;

    public partial class SSExpressionlps
    {
        public static SSExpressionlps Runtime_MakeExpressionlpsNew(SEExpression expression, SGDelimiter delimiter)
        {
            SSExpressionlps expressionlpsResult = default;

            expressionlpsResult = MakeExpressionlpsNew(expression, delimiter, SAPolicy.ExpressionlpsDebugPolicy);

            return expressionlpsResult;
        }
    }
}
