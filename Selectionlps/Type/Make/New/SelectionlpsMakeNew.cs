using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SSSelectionlps
    {
        public static SSSelectionlps MakeSelectionlpsNew(SSSelection selection, Boolean empty, SGDelimiter delimiter, Boolean debug)
        {
            SSSelectionlps selectionlpsResult = default;

            var list_DELIMITER = SGSymbol.Runtime_SymbolStringSet(delimiter.DelimiterList);

            var list = new List<SSSelection>();

            var safe_ONE__FIRST = (selection == default) is true;

            if (safe_ONE__FIRST is true)
            {
                return selectionlpsResult;
            }
            else
                "false".ToString();

            var current = selection;

            do
            {
                var start = 0;

                var length = current.Data.Runtime.Cached.Length;

                var predicate = SSPredicate.Runtime_MakePredicate(current, start, length, list_DELIMITER, delimiter.Text);

                var safe_TWO__SECOND = (predicate == default) is true;

                if (safe_TWO__SECOND is true)
                {
                    list.Add(current);

                    break;
                }
                else
                    "false".ToString();

                list.Add(predicate.Input);

                current = predicate.Output;

                continue;

            } while (true);

            if (empty is false)
            {
                foreach (SSSelection selection_EMPTY in new List<SSSelection>(list))
                {
                    var value = selection_EMPTY.Data.Runtime.Cached;

                    var format = value.Trim();

                    var safe_TWO__SECOND = (format.Length == String.Empty.Length) is true;

                    if (safe_TWO__SECOND is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    list.Remove(selection_EMPTY);

                    continue;
                }
            }
            else
                "false".ToString();

            var array = list.ToArray();

            selectionlpsResult = new SSSelectionlps(array, debug);

            return selectionlpsResult;
        }
    }
}
