using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SSPredicate
    {
        public static SSPredicate Runtime_MakePredicate(SSSelection selection, Int32 index, Int32 count, IEnumerable<String> enumerable, SGText text)
        {
            SSPredicate predicateResult = default;

            predicateResult = MakePredicate(selection, index, count, enumerable, text, SAPolicy.PredicateDebugPolicy);
            
            return predicateResult;
        }
    }
}
