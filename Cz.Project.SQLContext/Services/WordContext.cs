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

        public IList<Word> GetWordsByLanguaje(int languajeCode)
        {
            string query = $"SELECT W.* FROM [Words] AS W JOIN [Languajes] AS L ON W.LanguajeId = L.Id WHERE L.Code = @Code";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Code", languajeCode));

                var table = DA.Read(query);
                return ReadWords(table);
            }
        }

        public Word GetByCode(int code)
        {
            string query = $"SELECT * FROM [Words] WHERE Code = @Code";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Code", code));

                var table = DA.Read(query, sqlParameters);
                return ReadWords(table).First();
            }
        }

        public IList<Word> ReadWords(DataTable table)
        {
            if (table.Rows.Count > 0)
            {
                IList<Word> words = new List<Word>();

                foreach (DataRow item in table.Rows)
                {
                    words.Add(MapWord(item));
                }

                return words;
            }
            else
            {
                return null;
            }
        }

        public Word MapWord(DataRow dataRow)
        {
            var result = new Word()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                Translate = dataRow["Translate"].ToString(),
                Code = Convert.ToInt32(dataRow["Code"]),
                Key = dataRow["Key"].ToString(),
                LanguajeId = Convert.ToInt32(dataRow["LanguajeId"])
            };

            result.Languaje = new LanguajesContext().GetById(result.LanguajeId);

            return result;
        }
    }
}
