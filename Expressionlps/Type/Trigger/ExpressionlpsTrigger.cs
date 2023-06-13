using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SSExpressionlps
    {
        public static IList<SEExpression> TriggerExpressionlps(SEExpression expression, IEnumerable<SGSymbol> enumerable)
        {
            ICollection<SEExpression> collectionResult = default;

            var list_EXPRESSION = new List<SEExpression>();

            collectionResult = new Collection<SEExpression>(TraverseExpressionlps(list_EXPRESSION, expression, enumerable));

            return new List<SEExpression>(collectionResult);
        }
    }
}
