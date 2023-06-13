using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SSPredicate
    {
        public static void MakePredicateOneFirstVoid(SSSelection selection, Int32 position, Char[] array_CHARACTER_DELIMITER, out SSSelection input, out SSSelection output, SGText text)
        {
            var selection_input_LEFT = selection.Data.CursorLeft.Data.PhysicalOffset;

            var selection_input_RIGHT = (selection.Data.CursorLeft.Data.PhysicalOffset + position);

            goto align_INI;

            align_INI:
            {
                var selection_input_RIGHT__ALIGN_INI = selection_input_RIGHT;

                selection_input_RIGHT__ALIGN_INI = selection_input_RIGHT__ALIGN_INI - 1;

                selection_input_RIGHT = selection_input_RIGHT__ALIGN_INI;
            }

            var selection_input_RESULT = SSSelection.Runtime_MakeSelectionIndexerIndexer(SAConstant.SelectionRebaseDefault, selection_input_LEFT, selection_input_RIGHT, text);

            input = selection_input_RESULT;

            var selection_output_LEFT = (selection.Data.CursorLeft.Data.PhysicalOffset + position);

            goto align_SIZE;

            align_SIZE:
            {
                var selection_output_LEFT__ALIGN_SIZE = selection_output_LEFT;

                selection_output_LEFT__ALIGN_SIZE = selection_output_LEFT__ALIGN_SIZE + array_CHARACTER_DELIMITER.Length;

                selection_output_LEFT = selection_output_LEFT__ALIGN_SIZE;
            }

            var selection_output_RIGHT = selection.Data.CursorRight.Data.PhysicalOffset;

            var selection_output_RESULT = SSSelection.Runtime_MakeSelectionIndexerIndexer(SAConstant.SelectionRebaseDefault, selection_output_LEFT, selection_output_RIGHT, text);

            output = selection_output_RESULT;

            return;
        }
    }
}
