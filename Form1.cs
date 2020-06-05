using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacePractice
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			customizeDesign();

		}
		
		///AutoHide Submenu (left) panels
		private void customizeDesign()
		{
			
			panelAutomationsSubMenu.Visible = false;
			panelMediaSubMenu.Visible = false;

		}

		private void HideSubMenu()
		{
			if (panelAutomationsSubMenu.Visible		 ==true)
				panelAutomationsSubMenu.Visible = false;
			if (panelMediaSubMenu.Visible			== true)
				panelMediaSubMenu.Visible		= false;
		}

		private void ShowSubMenu(Panel subMenu)
		{
			if (subMenu.Visible == false)
			{
				HideSubMenu();
				subMenu.Visible = true;
			}
			else
				subMenu.Visible = false;
		}



		#region InventoryButton
		//Opens InventorySubMenu
		private void btnInventory_Click(object sender, EventArgs e)
		{
			ShowSubMenu(panelMediaSubMenu);
		}


		private void button2_Click(object sender, EventArgs e)
		{
			//Code
			OpenChildForms(new Form2());

		}

		private void button3_Click(object sender, EventArgs e)
		{


		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{

	
		}

		private void button6_Click(object sender, EventArgs e)
		{

		}

		#endregion

		#region AutomationButton
		//Opens AutomationSubMenu
		private void btnAutomations_Click(object sender, EventArgs e)
		{
			ShowSubMenu(panelAutomationsSubMenu);
		}

		private void button11_Click(object sender, EventArgs e)
		{

		}

		private void button10_Click(object sender, EventArgs e)
		{

		}

		private void button9_Click(object sender, EventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{

		}

		#endregion

		#region GlyphIdentifierButton 
		//No need to close any Open Submenus
		private void btnGlyphIdentifier_Click(object sender, EventArgs e)
		{
			OpenChildForms(new Form3());
		}
		#endregion

		#region ToolsButton
		//No need to close any Open Submenus
		private void btnTools_Click(object sender, EventArgs e)
		{

		}
		#endregion

		private Form activeFormMain = null;
		//private Form activeFormSub = null;
		
		//Opens Button Forms
		private void OpenChildForms(Form childFormMain)
		{
			if (activeFormMain != null)
				activeFormMain.Close();
			/*if (activeFormSub != null)
				activeFormSub.Close();
				*/
			activeFormMain = childFormMain;
			//activeFormSub = childFormSub;

			//remove Default form from top level, acting as control
			childFormMain.TopLevel = false;
			//childFormSub.TopLevel = false;

			//childFormSub.FormBorderStyle = FormBorderStyle.None;
			//childFormSub.Dock = DockStyle.Top;
			childFormMain.FormBorderStyle = FormBorderStyle.None;
			childFormMain.Dock = DockStyle.Fill;

			panelChildFormMain.Controls.Add(childFormMain);
			panelChildFormMain.Tag = childFormMain;
			childFormMain.BringToFront();
			childFormMain.Show();

			//panelChildFormSub.Controls.Add(childFormSub);
			//panelChildFormSub.Tag = childFormSub;
			//childFormSub.BringToFront();
			//childFormSub.Show();


		}



	}
}
