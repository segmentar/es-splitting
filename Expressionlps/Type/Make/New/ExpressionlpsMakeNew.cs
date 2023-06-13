using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SSExpressionlps
    {
        public static SSExpressionlps MakeExpressionlpsNew(SEExpression expression, SGDelimiter delimiter, Boolean debug)
        {
            SSExpressionlps expressionlpsResult = default;

            var list_EXPRESSION = new List<SEExpression>(TriggerExpressionlps(expression, delimiter.DelimiterList));

            MakeExpressionlpsOneFirstVoid(list_EXPRESSION, delimiter.Lone);

            expressionlpsResult = new SSExpressionlps(list_EXPRESSION, debug);

            return expressionlpsResult;
        }
    }
}
