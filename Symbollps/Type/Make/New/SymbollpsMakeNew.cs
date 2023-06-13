using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SSSymbollps
    {
        public static SSSymbollps MakeSymbollpsNew(SGSymbol symbol, SGDelimiter delimiter, StringSplitOptions option, Boolean debug)
        {
            SSSymbollps symbollpsResult = default;

            var split = symbol.Value.Split(SGSymbol.Runtime_SymbolStringSet(delimiter.DelimiterList), option);

            var array = SGSymbol.Runtime_SymbolDefaultSet(split);

            symbollpsResult = new SSSymbollps(array, debug);

            return symbollpsResult;
        }
    }
}