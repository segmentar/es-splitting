using Core;

namespace Core.Shared
{
    using System;

    public partial class SSSymbollps
    {
        public SSSymbollps(SGSymbol[] symbolArray, Boolean debug)
        {
            this.SymbolArray = symbolArray;

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
