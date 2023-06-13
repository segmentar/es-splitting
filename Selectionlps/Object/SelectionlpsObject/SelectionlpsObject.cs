using Core;

namespace Core.Shared
{
    using System;

    public partial class SSSelectionlps
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SSSelectionlps) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(SelectionArray) + ':' + ' ' + ". . ." + ' ' + $"[{SelectionArray.Length}]",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(SelectionArray) + ':',
                String.Empty + String.Join('\n'.ToString(), (Object[])SelectionArray)
            });
        }
    }
}
