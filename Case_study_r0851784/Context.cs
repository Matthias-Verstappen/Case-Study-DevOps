using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study_r0851784
{
	public class Context
	{

		public IDbConnection GetConnection()
		{
			return new SqliteConnection(@"Data Source=.\BerkvenDB.db;New=true");
		}

		public void createDatabase()
		{
			using (IDbConnection db = GetConnection())
			{
				db.Execute("CREATE TABLE IF NOT EXISTS Persons(ID INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Email TEXT, Drinks INTEGER, PlayGroup TEXT)");
				db.Execute("CREATE TABLE IF NOT EXISTS Leaders(ID INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Email TEXT, Drinks INTEGER, PlayGroup TEXT, Tasks TEXT)");

				MessageBox.Show("Database and tables created");
			}
		}
	}
}
