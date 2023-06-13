using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SSPredicate
    {
        public static SSPredicate MakePredicate(SSSelection selection, Int32 index, Int32 count, IEnumerable<String> enumerable, SGText text, Boolean debug)
        {
            SSPredicate predicateResult = default;

            //Debug_PredicateNew(selection, enumerable, debug);

            var safe_ONE__FIRST = (selection == default) is true;

            if (safe_ONE__FIRST is true)
            {
                return predicateResult;
            }
            else
                "false".ToString();

            var start_index_INCLUSIVE_NULLABLE_INDEXR__NUMBER_INTEGER_BIT_32_thirty_two = index;

            var count_counter_EXCLUSIVE_NORMALIZED_ORDINAL__NUMBER_INTEGER_BIT_32_thirty_two = count;

            var total_NUMERAL_NUMERIC__MODIFIABLE_CONVERT__NUMBER_INTEGER_BIT_32_thirty_two =
                start_index_INCLUSIVE_NULLABLE_INDEXR__NUMBER_INTEGER_BIT_32_thirty_two
                +
                count_counter_EXCLUSIVE_NORMALIZED_ORDINAL__NUMBER_INTEGER_BIT_32_thirty_two
                ;

            var start = start_index_INCLUSIVE_NULLABLE_INDEXR__NUMBER_INTEGER_BIT_32_thirty_two;

            var length = count_counter_EXCLUSIVE_NORMALIZED_ORDINAL__NUMBER_INTEGER_BIT_32_thirty_two;

            var total = total_NUMERAL_NUMERIC__MODIFIABLE_CONVERT__NUMBER_INTEGER_BIT_32_thirty_two;

            char[] data = selection.Data.Runtime.Cached.ToCharArray();;

            int i, j, n, m, x, o;

            i = start;

            n = length;

            x = total;

            char ci, ic, cj, jc;

            char[] array_CHARACTER_DELIMITER = new char[0];

            var found = false;

            for (; ;)
            {
                var safe_TWO__SECOND = false;

                safe_TWO__SECOND = safe_TWO__SECOND || (i == x) is true;

                safe_TWO__SECOND = safe_TWO__SECOND || (i < 0) is true;

                safe_TWO__SECOND = safe_TWO__SECOND || (n < 0) is true;

                if (safe_TWO__SECOND is true)
                {
                    break;
                }
                else
                    "false".ToString();

                foreach (String symbol_DELIMITER in enumerable)
                {
                    ci = data[i];

                    ic = symbol_DELIMITER[0];

                    var safe_THREE__THIRD = (ci == ic) is true;

                    if (safe_THREE__THIRD is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    found = true;

                    var copy = symbol_DELIMITER.ToCharArray();

                    array_CHARACTER_DELIMITER = new Char[copy.Length];

                    Array.Copy(copy, array_CHARACTER_DELIMITER, copy.Length);

                    break;
                }

                if (found is true)
                {
                    for (j = i, m = array_CHARACTER_DELIMITER.Length, o = 0; ;)
                    {
                        var safe_THREE__THIRD = false;

                        safe_THREE__THIRD = safe_THREE__THIRD || (j == x) is true;

                        safe_THREE__THIRD = safe_THREE__THIRD || (o == m) is true;

                        if (safe_THREE__THIRD is true)
                        {
                            break;
                        }
                        else
                            "false".ToString();

                        cj = data[j];

                        jc = array_CHARACTER_DELIMITER[o];

                        var safe_FOUR__FOURTH = (cj == jc) is true;

                        if (safe_FOUR__FOURTH is false)
                        {
                            found = false;

                            break;
                        }
                        else
                            "false".ToString();

                        j = j + 1;

                        o = o + 1;

                        continue;
                    }

                    if (found is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();
                }
                else
                    "false".ToString();

                i = i + 1;

                continue;
            }

            if (found is true)
            {
                SSSelection input, output;

                MakePredicateOneFirstVoid(selection, i, array_CHARACTER_DELIMITER, out input, out output, text);

                var safe_TWO__SECOND = false;

                safe_TWO__SECOND = safe_TWO__SECOND || (input == default) is true;

                safe_TWO__SECOND = safe_TWO__SECOND || (output == default) is true;

                if (safe_TWO__SECOND is true)
                {
                    return predicateResult;
                }
                else
                    "false".ToString();

                predicateResult = new SSPredicate(input, output, debug);
            }
            else
                "false".ToString();

            return predicateResult;
        }
    }
}
