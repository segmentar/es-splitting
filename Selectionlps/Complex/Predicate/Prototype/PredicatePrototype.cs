using Core;

namespace Core.Shared
{
    using System;

    public partial class SSPredicate
    {
        public SSPredicate(SSSelection input, SSSelection output, Boolean debug)
        {
            this.Input = input;

            this.Output = output;

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
