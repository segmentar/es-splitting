using Core;

namespace Core.Shared
{
    using System;

    public partial class SSSymbollps
    {
        public static SSSymbollps Runtime_MakeSymbollpsNew(SGSymbol symbol, SGDelimiter delimiter, StringSplitOptions option)
        {
            SSSymbollps symbollpsResult = default;

            symbollpsResult = MakeSymbollpsNew(symbol, delimiter, option, SAPolicy.SymbollpsDebugPolicy);

            return symbollpsResult;
        }
    }
}
