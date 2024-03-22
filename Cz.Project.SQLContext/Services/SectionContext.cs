using Cz.Project.Domain.Business;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Cz.Project.SQLContext.Services
{
    public class SectionContext
    {
        public IList<Section> GetAll()
        {
            string query = $"SELECT * FROM [Sections] AND [IsDeleted] = 0";

            using (var DA = new SQLDataAccess())
            {
                var section = DA.Read(query);
                return ReadSection(section);
            }
        }

        public int Add(Section section, int menuId)
        {
            string query = $"INSERT INTO [dbo].[Sections] ([Name], [Description], [Position], [MenuId]) VALUES (@Name, @Description, @Position, @MenuId)";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Name", section.Name));
                sqlParameters.Add(SqlHelper.CreateParameter("Description", section.Description != null ? section.Description : string.Empty));
                sqlParameters.Add(SqlHelper.CreateParameter("Position", section.Position));
                sqlParameters.Add(SqlHelper.CreateParameter("MenuId", menuId));

                return DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public IList<Section> GetByMenuId(int menuId)
        {
            string query = $"SELECT * FROM [Sections] WHERE MenuId = @MenuId AND [IsDeleted] = 0";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("MenuId", menuId));

                var section = DA.Read(query, sqlParameters);
                return ReadSection(section);
            }
        }

        public Section GetById(int id)
        {
            string query = $"SELECT * FROM [Sections] WHERE Id = @Id AND [IsDeleted] = 0";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Id", id));

                var section = DA.Read(query, sqlParameters);
                return ReadSection(section).First();
            }
        }

        public IList<Section> ReadSection(DataTable table)
        {
            IList<Section> sections = new List<Section>();

            foreach (DataRow item in table.Rows)
            {
                sections.Add(MapSection(item));
            }

            return sections;
        }

        public Section MapSection(DataRow dataRow)
        {
            return new Section()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                MenuId = Convert.ToInt32(dataRow["MenuId"]),
                Description = dataRow["Description"].ToString(),
                Name = dataRow["Name"].ToString(),
                Position = Convert.ToInt32(dataRow["Position"]),
            };
        }

        public void DeleteSection(int sectionId)
        {
            string query = $"UPDATE [Sections] SET IsDeleted = 1 WHERE Id = @Id; UPDATE [Dishes] SET IsDeleted = 1 WHERE SectionId = @Id";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Id", sectionId));

                var dish = DA.ExecuteQuery(query, sqlParameters);
            }
        }
    }
}
