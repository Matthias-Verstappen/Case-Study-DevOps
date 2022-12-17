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
			return new SqliteConnection(@"Data Source=C:\Devops\BerkvenDB.db;");
		}

		public void createDatabase()
		{
			using (IDbConnection db = GetConnection())
			{
				//db.Execute("DROP TABLE PERSONS");
				//db.Execute("DROP TABLE LEADERS");
				//db.Execute("CREATE TABLE IF NOT EXISTS Roles(ID int PRIMARY KEY, Name varchar(50))");
				//db.Execute("CREATE TABLE IF NOT EXISTS Persons(ID int AUTO_INCREMENT PRIMARY KEY, Name varchar(50), Email varchar(50), Drinks int, Role varchar(50))");
				//db.Execute("CREATE TABLE IF NOT EXISTS Leaders (ID int AUTO_INCREMENT PRIMARY KEY, Tasks varchar(50)) INHERITS (Persons);");
				db.Execute("CREATE TABLE IF NOT EXISTS Persons(ID INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Email TEXT, Drinks INTEGER, PlayGroup TEXT)");
				db.Execute("CREATE TABLE IF NOT EXISTS Leaders(ID INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Email TEXT, Drinks INTEGER, PlayGroup TEXT, Tasks TEXT)");

				MessageBox.Show("Database and tables created");
			}
		}
	}
}
