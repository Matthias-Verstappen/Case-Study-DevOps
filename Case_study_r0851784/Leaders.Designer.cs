namespace Case_study_r0851784
{
	partial class Leaders
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private DataGridView dataGridViewLeaders;
		private TextBox nameBox;
		private TextBox emailBox;
		//private TextBox taskBox;
		//private NumericUpDown drinksBox;
		//private Button insertButton;
		//private Button updateButton;
		//private Button deleteButton;



		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.memberNav = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.taskBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.drinksBox = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.deleteButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.insertButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.emailBox = new System.Windows.Forms.TextBox();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.groupBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.drinksBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// memberNav
			// 
			this.memberNav.Location = new System.Drawing.Point(160, 40);
			this.memberNav.Name = "memberNav";
			this.memberNav.Size = new System.Drawing.Size(132, 36);
			this.memberNav.TabIndex = 33;
			this.memberNav.Text = "Members";
			this.memberNav.UseVisualStyleBackColor = true;
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox5.Location = new System.Drawing.Point(32, 28);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(113, 47);
			this.textBox5.TabIndex = 32;
			this.textBox5.Text = "Leaders";
			// 
			// taskBox
			// 
			this.taskBox.Location = new System.Drawing.Point(39, 427);
			this.taskBox.Name = "taskBox";
			this.taskBox.Size = new System.Drawing.Size(354, 27);
			this.taskBox.TabIndex = 31;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(39, 404);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 20);
			this.label5.TabIndex = 30;
			this.label5.Text = "Tasks";
			// 
			// drinksBox
			// 
			this.drinksBox.Location = new System.Drawing.Point(39, 300);
			this.drinksBox.Name = "drinksBox";
			this.drinksBox.Size = new System.Drawing.Size(150, 27);
			this.drinksBox.TabIndex = 29;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 277);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 20);
			this.label4.TabIndex = 28;
			this.label4.Text = "Drinks";
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(568, 359);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(132, 36);
			this.deleteButton.TabIndex = 27;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(427, 360);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(132, 36);
			this.updateButton.TabIndex = 26;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(427, 149);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 29;
			this.dataGridView2.Size = new System.Drawing.Size(860, 157);
			this.dataGridView2.TabIndex = 25;
			// 
			// insertButton
			// 
			this.insertButton.Location = new System.Drawing.Point(39, 491);
			this.insertButton.Name = "insertButton";
			this.insertButton.Size = new System.Drawing.Size(132, 36);
			this.insertButton.TabIndex = 24;
			this.insertButton.Text = "Insert";
			this.insertButton.UseVisualStyleBackColor = true;
			this.insertButton.Click += new System.EventHandler(this.insertButton_Click_1);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 202);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 20);
			this.label3.TabIndex = 23;
			this.label3.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 20);
			this.label2.TabIndex = 22;
			this.label2.Text = "Name";
			// 
			// emailBox
			// 
			this.emailBox.Location = new System.Drawing.Point(39, 225);
			this.emailBox.Name = "emailBox";
			this.emailBox.Size = new System.Drawing.Size(354, 27);
			this.emailBox.TabIndex = 21;
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(39, 149);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(354, 27);
			this.nameBox.TabIndex = 20;
			// 
			// groupBox
			// 
			this.groupBox.Location = new System.Drawing.Point(39, 369);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(354, 27);
			this.groupBox.TabIndex = 34;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 346);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 20);
			this.label1.TabIndex = 35;
			this.label1.Text = "Group";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// Leaders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1333, 688);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox);
			this.Controls.Add(this.memberNav);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.taskBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.drinksBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.insertButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.emailBox);
			this.Controls.Add(this.nameBox);
			this.Name = "Leaders";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.drinksBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button memberNav;
		private TextBox textBox5;
		private TextBox taskBox;
		private Label label5;
		private NumericUpDown drinksBox;
		private Label label4;
		private Button deleteButton;
		private Button updateButton;
		private DataGridView dataGridView2;
		private Button insertButton;
		private Label label3;
		private Label label2;
		private TextBox groupBox;
		private Label label1;
		//private TextBox emailBox;
		//private TextBox nameBox;
	}
}