using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SSExpressionlps
    {
        public SSExpressionlps(List<SEExpression> expressionList, Boolean debug)
        {
            this.ExpressionList = expressionList;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
