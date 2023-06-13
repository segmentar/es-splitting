using Core;

namespace Core.Shared
{
    using System;

    public partial class SSSelectionlps
    {
        public SSSelectionlps(SSSelection[] selectionArray, Boolean debug)
        {
            this.SelectionArray = selectionArray;

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
