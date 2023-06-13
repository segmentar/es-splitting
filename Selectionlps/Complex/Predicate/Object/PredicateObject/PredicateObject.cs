using Core;

namespace Core.Shared
{
    using System;

    public partial class SSPredicate
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
                String.Empty + nameof(SSPredicate) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Input) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Output) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Input) + ':',
                String.Empty + Input,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Output) + ':',
                String.Empty + Output
            });
        }
    }
}
