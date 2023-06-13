using Core;

namespace Core.Shared
{
    using System;


    public partial class SSExpressionlps
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
                String.Empty + nameof(SSExpressionlps) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + ' ' + "01" + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + ' ' + "02" + nameof(ExpressionList) + ':' + ' ' + ". . ." + ' ' + $"[{ExpressionList.Count}]",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ExpressionList) + ':',
                String.Empty + String.Join('\n'.ToString(), ExpressionList)
            });
        }
    }
}
