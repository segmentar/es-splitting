using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SSExpressionlps
    {
        public static IList<SEExpression> TraverseExpressionlps(List<SEExpression> list_EXPRESSION, SEExpression expression, IEnumerable<SGSymbol> enumerable)
        {
            ICollection<SEExpression> collectionResult = default;

            collectionResult = new Collection<SEExpression>(list_EXPRESSION);

            foreach (SGSymbol symbol in enumerable)
            {
                var safe_ONE__FIRST = (symbol.Value.ToString() == expression.ExpressionObject.ToString()) is true;

                if (safe_ONE__FIRST is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                list_EXPRESSION.Add(expression);

                continue;
            }

            foreach (SEExpression expression_CHILD in expression.ExpressionList)
            {
                collectionResult = TraverseExpressionlps(list_EXPRESSION, expression_CHILD, enumerable);

                continue;
            }

            return new List<SEExpression>(collectionResult);
        }
    }
}
