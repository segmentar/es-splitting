using Core;

namespace Core.Shared
{
    using System;

    public partial class SSSelectionlps
    {
        public static SSSelectionlps Runtime_MakeSelectionSplitNew(SSSelection selection, Boolean empty, SGDelimiter delimiter)
        {
            SSSelectionlps selectionlpsResult = default;

            selectionlpsResult = MakeSelectionlpsNew(selection, empty, delimiter, SAPolicy.SelectionlpsDebugPolicy);

            return selectionlpsResult;
        }
    }
}
