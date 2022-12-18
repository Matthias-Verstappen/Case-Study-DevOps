using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Case_study_r0851784
{
	public partial class Leaders : Form
	{
		public Leaders()
		{
			InitializeComponent();
			LoadData();
		}

		public Context _context { get; } = new Context();

		//GET ALL
		private void LoadData()
		{
			using (IDbConnection db = _context.GetConnection())
			{
				var list = db.Query<Leader>("select * from Leaders").ToList();
				if (list.Count() > 0)
				{
					dataGridView2.DataSource = list;
				}
			}
		}

		//ADD
		private void insertButton_Click_1(object sender, EventArgs e)
		{
			using (IDbConnection db = _context.GetConnection())
			{
				//int id = Convert.ToInt32(numericUpDown2.Text);
				string name = nameBox.Text;
				string email = emailBox.Text;
				int drinks = Convert.ToInt32(drinksBox.Text);
				string playGroup = groupBox.Text;
				string tasks = taskBox.Text;
				int n = db.Execute("INSERT INTO LEADERS(name, email, drinks, playGroup, tasks)values(@Name, @Email, @Drinks, @PlayGroup, @Tasks)", new { Name = name, Email = email, Drinks = drinks, PlayGroup = playGroup, Tasks = tasks });


				if (n > 0)
				{
					MessageBox.Show("Inserted");
					LoadData();
				}
			}
		}

		//UPDATE
		private void updateButton_Click_1(object sender, EventArgs e)
		{
			string tasks = dataGridView2.CurrentRow.Cells[0].Value.ToString();
			int id = (int)dataGridView2.CurrentRow.Cells[1].Value;
			string name = dataGridView2.CurrentRow.Cells[2].Value.ToString();
			string email = dataGridView2.CurrentRow.Cells[3].Value.ToString();
			string drinks = dataGridView2.CurrentRow.Cells[4].Value.ToString();
			string playGroup = dataGridView2.CurrentRow.Cells[5].Value.ToString();
			using (IDbConnection db = _context.GetConnection())
			{
				int n = db.Execute("UPDATE LEADERS set name=@Name, email=@Email, drinks=@Drinks, playGroup=@PlayGroup, tasks=@Tasks where id=@ID", new { ID = id, Name = name, Email = email, Drinks = drinks, PlayGroup = playGroup, Tasks = tasks });

				if (n > 0)
				{
					MessageBox.Show("Updated");
					LoadData();
				}
			}
		}

		// DELETE
		private void deleteButton_Click_1(object sender, EventArgs e)
		{
			int id = (int)dataGridView2.CurrentRow.Cells[1].Value;
			using (IDbConnection db = _context.GetConnection())
			{
				int n = db.Execute("DELETE from LEADERS where id=@ID", new { ID = id });

				if (n > 0)
				{
					MessageBox.Show("Deleted");
					LoadData();
				}
			}
		}

		private void memberNav_Click(object sender, EventArgs e)
		{
			new Members().Show();
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		//private void deleteButton_Click_1(object sender, EventArgs e)
		//{

		//}

		//private void updateButton_Click_1(object sender, EventArgs e)
		//{

		//}
	}
}
