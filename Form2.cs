using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace InterfacePractice
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		//Retrieve string from text file
		public void retrieveTextFile()
		{

			String line = "";

				// Open the text file using a stream reader.
				string Startup = Application.StartupPath;

				StreamReader sr = new StreamReader(Startup + "Warframes" + ".txt");

			// Read the stream to a string, and write the string to the console.

			
				while ((line = sr.ReadLine()) != null)
				{
				listBoxInventory.Items.Add(line);
				}


			//Console.WriteLine(line);


			sr.Close();

		}


		private void btnCloseForm_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{

		}


		//Append to Main Inventory, Used to if item isn't in list
		private void btnAppendListInventory_Click(object sender, EventArgs e)
		{
			StreamWriter sw = new StreamWriter(Application.StartupPath + "Warframes" + ".txt", append: true); // Path to write .txt file

			if (this.textBoxInventory.Text != "")
			{

				sw.WriteLine(this.textBoxInventory.Text + " - " + "Owned:False");
				sw.Close();

				listBoxInventory.Items.Clear();
				retrieveTextFile();
				
				//listBoxInventory.Items.Add(this.textBoxInventory.Text);

				//add to txt file
				//.listBoxInventory.Items.Add();

				this.textBoxInventory.Focus();
				this.textBoxInventory.Clear();
			}
			else
			{
				MessageBox.Show("Please enter an Item", "Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
				this.textBoxInventory.Focus();
			}



			sw.Close();

		}

		private void btnDeleteListInventory_Click(object sender, EventArgs e)
		{
			if (this.listBoxInventory.SelectedIndex >= 0)
			{
				this.listBoxInventory.Items.RemoveAt(this.listBoxInventory.SelectedIndex);
			}
		}
	}
}
