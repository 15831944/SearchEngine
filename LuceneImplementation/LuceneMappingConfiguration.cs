using System;
using System.Collections.Generic;
using Lucene.Net.Documents;

namespace LuceneImplementation
{
    public class FieldNameToFieldTypeMappingConfig:Dictionary<string, string>
    {

    }

    public class TypeToFieldTypeMappingConfig:Dictionary<TypeCode, Type>
    {
        public void k()
        {
            var k = new date
        }
    }

    public class DefaultTypeToFieldTypeMappingConfig
    {
        public DefaultTypeToFieldTypeMappingConfig()
        {
            this.Add(TypeCode.Boolean, typeof(field));
        }
    }

}
