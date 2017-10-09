using System;
using System.Collections.Generic;
using Lucene.Net.Documents;
namespace LuceneImplementation
{
    
    public enum LuceneFieldType
    {
        BinaryDocValuesField,
        DoubleDocValuesField,
        DoubleField,
        Field,
        Int32Field,
        Int64Field,
        NumericDocValuesField,
        SingleDocValuesField,
        SingleField,
        SortedDocValuesField,
        SortedSetDocValuesField,
        StringField,
        TextField,
        StoredField
    }

    public static class Resources
    {
        public static Dictionary<LuceneFieldType, Type> _dict = new Dictionary<LuceneFieldType, Type>
        {
            {LuceneFieldType.BinaryDocValuesField, typeof(BinaryDocValuesField)},
            {LuceneFieldType.DoubleDocValuesField, typeof(DoubleDocValuesField)},
            {LuceneFieldType.DoubleField, typeof(DoubleField)},
            {LuceneFieldType.Field, typeof(Field)},
            {LuceneFieldType.Int32Field, typeof(Int32Field)},
            {LuceneFieldType.Int64Field, typeof(Int64Field)},
            {LuceneFieldType.NumericDocValuesField, typeof(NumericDocValuesField)},
            {LuceneFieldType.SingleDocValuesField, typeof(SingleDocValuesField)},
            {LuceneFieldType.SingleField, typeof(SingleField)},
            {LuceneFieldType.SortedDocValuesField, typeof(SortedDocValuesField)},
            {LuceneFieldType.SortedSetDocValuesField, typeof(SortedSetDocValuesField)},
            {LuceneFieldType.StringField, typeof(StringField)},
            {LuceneFieldType.TextField, typeof(TextField)},
            {LuceneFieldType.StoredField, typeof(StoredField)}
        };

        public static void K()
        {
            var z = new DoubleField("1", 1, new FieldType(NumericDocValuesField)
        }
    }

}
