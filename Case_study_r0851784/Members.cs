using Dapper;
using Microsoft.Data.Sqlite;
using System.Data;

namespace Case_study_r0851784
{
	public partial class Members : Form
	{
		public Members()
		{
			InitializeComponent();
		}
		public Context _context { get; } = new Context();

		//GET ALL
		private void LoadData()
		{
			using (IDbConnection db = _context.GetConnection())
			{
				var list = db.Query<Person>("select * from Persons").ToList();
				if (list.Count() > 0)
				{
					dataGridView1.DataSource = list;
				}
			}
		}

		//CREATE
		private void button1_Click(object sender, EventArgs e)
		{
			_context.createDatabase();
		}

		//ADD
		private void button2_Click(object sender, EventArgs e)
		{
			using (IDbConnection db = _context.GetConnection())
			{
				//int id = Convert.ToInt32(numericUpDown2.Text);
				string name = textBox2.Text;
				string email = textBox3.Text;
				int drinks = Convert.ToInt32(numericUpDown1.Text);
				string playGroup = textBox4.Text;
				int n = db.Execute("INSERT INTO Persons(name, email, drinks, playGroup)values(@Name, @Email, @Drinks, @PlayGroup)", new { Name = name, Email = email, Drinks = drinks, PlayGroup = playGroup });


				if (n > 0)
				{
					MessageBox.Show("Inserted");
					LoadData();
				}
			}
		}

		//UPDATE
		private void button3_Click(object sender, EventArgs e)
		{
			int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
			string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			string email = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			string drinks = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			string playGroup = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			using (IDbConnection db = _context.GetConnection())
			{
				int n = db.Execute("update persons set name=@Name, email=@Email, drinks=@Drinks, playGroup=@PlayGroup where id=@ID", new { ID = id, Name = name, Email = email, Drinks = drinks, PlayGroup = playGroup });

				if (n > 0)
				{
					MessageBox.Show("Updated");
					LoadData();
				}
			}
		}

		// DELETE
		private void button4_Click(object sender, EventArgs e)
		{
			int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
			using (IDbConnection db = _context.GetConnection())
			{
				int n = db.Execute("delete from persons where id=@ID", new { ID = id });

				if (n > 0)
				{
					MessageBox.Show("Deleted");
					LoadData();
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			_context.createDatabase();

			if (!System.IO.File.Exists(@"\Data source=C:\\Devops\\BerkvenDB.db"))
			{
				LoadData();
			}
		}

		private void leaderNav_Click(object sender, EventArgs e)
		{
			new Leaders().Show();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}



		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{

		}

		private void numericUpDown3_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged_1(object sender, EventArgs e)
		{

		}
	}

}