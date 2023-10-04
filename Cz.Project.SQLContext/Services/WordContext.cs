using Cz.Project.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Cz.Project.SQLContext.Services
{
    public class WordContext
    {
        public IList<Word> GetAll()
        {
            string query = $"SELECT * FROM [Words]";

            using (var DA = new SQLDataAccess())
            {
                var table = DA.Read(query);
                return ReadWords(table);
            }
        }

        public void Add(Word word)
        {
            string query = $"INSERT INTO [dbo].[Words] ([LanguajeId], [Text], [Code]) VALUES (@LanguajeId, @Text, @Code)";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("LanguajeId", word.LanguajeId));
                sqlParameters.Add(SqlHelper.CreateParameter("Text", word.Text));
                sqlParameters.Add(SqlHelper.CreateParameter("Code", word.Code));

                DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public void Update(Word word)
        {
            string query = $"UPDATE [dbo].[Words] SET [Text] = @Text WHERE [Id] = @Id";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Text", word.Text));
                sqlParameters.Add(SqlHelper.CreateParameter("Id", word.Id));

                DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public IList<Word> GetWordsByLanguaje(int languajeCode)
        {
            string query = $"SELECT W.* FROM [Words] AS W JOIN [Languajes] AS L ON W.LanguajeId = L.Id WHERE L.Code = @Code";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Code", languajeCode));

                var table = DA.Read(query, sqlParameters);
                return ReadWords(table);
            }
        }

        public Word GetByCode(int code, int languajeId)
        {
            string query = $"SELECT * FROM [Words] WHERE Code = @Code AND [LanguajeId] = @LanguajeId";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("LanguajeId", languajeId));
                sqlParameters.Add(SqlHelper.CreateParameter("Code", code));

                var table = DA.Read(query, sqlParameters);

                var word = ReadWords(table);

                if (word != null)
                    return word.FirstOrDefault();
                else
                    return null;
            }
        }

        public IList<Word> ReadWords(DataTable table)
        {
            IList<Word> words = new List<Word>();

            foreach (DataRow item in table.Rows)
            {
                words.Add(MapWord(item));
            }

            return words;
        }

        public Word MapWord(DataRow dataRow)
        {
            var result = new Word()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                Text = dataRow["Text"].ToString(),
                Code = Convert.ToInt32(dataRow["Code"]),
                LanguajeId = Convert.ToInt32(dataRow["LanguajeId"])
            };

            result.Languaje = new LanguajesContext().GetById(result.LanguajeId);

            return result;
        }
    }
}
