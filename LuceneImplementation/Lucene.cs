using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Common;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.Search;
using Lucene.Net.Store;

namespace LuceneImplementation
{
    public class Lucene
    {

        private FSDirectory _directory { get; set; }

        private void Init(LuceneConfiguration config)
        {
        
            FSDirectory _directoryTemp;
            System.IO.Directory.CreateDirectory(config.LuceneIndexDirectory);

            _directoryTemp = FSDirectory.Open(new DirectoryInfo(config.LuceneIndexDirectory));

            if (IndexWriter.IsLocked(_directoryTemp))
            {
                IndexWriter.Unlock(_directoryTemp);
            }

            var lockFilePath = Path.Combine(config.LuceneIndexDirectory, "write.lock");

            if (File.Exists(lockFilePath))
            {
                File.Delete(lockFilePath);
            }

            _directory = _directoryTemp;
        
        }

        private static void _addToLuceneIndex(object sampleData, IndexWriter writer)
        {
            // remove older index entry
            var searchQuery = new TermQuery(new Term("Id", sampleData.Id.ToString()));
            writer.DeleteDocuments(searchQuery);

            // add new index entry
            var doc = new Document(); 

            // add lucene fields mapped to db fields
            doc.Add(new Field("Id", sampleData.Id.ToString(), Field.Store.YES, Field.Index.));
            doc.Add(new Field("Name", sampleData.Name, Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("Description", sampleData.Description, Field.Store.YES, Field.Index.ANALYZED));

            // add entry to index
            writer.AddDocument(doc);
        }

        private IDictionary<string, object> GetDocumentFromObject(object obj, LuceneMappingConfiguration config=null)
        {
            if (obj == null) return new Dictionary<string, object>();
            return obj.GetType().GetProperties().
                        ToDictionary(p => p.Name,
                                     p => p.GetValue(obj, null) ?? DBNull.Value);
        }

        private IIndexableField FieldFromProperty(PropertyInfo propInfo)
        {

            var field = new Field("abc", "abc", new FieldType(){IndexOptions=IndexOptions.})

            switch (Type.GetTypeCode(propInfo.PropertyType))
            {
                case TypeCode.:
                    break;
            }
        }

     }
}
