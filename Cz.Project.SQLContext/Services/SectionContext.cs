﻿using Cz.Project.Domain.Business;
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
            string query = $"SELECT * FROM [Sections]";

            using (var DA = new SQLDataAccess())
            {
                var section = DA.Read(query);
                return ReadSection(section);
            }
        }

        public void Add(Section section, int menuId)
        {
            string query = $"INSERT INTO [dbo].[Sections] ([Name], [Description], [Position], [MenuId]) VALUES (@Name, @Description, @Position, @MenuId)";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Name", section.Name));
                sqlParameters.Add(SqlHelper.CreateParameter("Description", section.Description));
                sqlParameters.Add(SqlHelper.CreateParameter("Position", section.Position));
                sqlParameters.Add(SqlHelper.CreateParameter("MenuId", menuId));

                DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public IList<Section> GetByMenuId(int menuId)
        {
            string query = $"SELECT * FROM [Sections] WHERE MenuId = @MenuId";

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
            string query = $"SELECT * FROM [Sections] WHERE Id = @Id";

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
    }
}
