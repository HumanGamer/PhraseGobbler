using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TextGobbler;

namespace PhraseGobbler
{
	public partial class MainForm : Form
	{
		private Gobbler.GobbleOptions Options { get; }

		public MainForm()
		{
			Options = new Gobbler.GobbleOptions();

			InitializeComponent();
		}

		private void Process()
		{
			string text = Gobbler.Gobble(txtInput.Text, Options);
			text = Regex.Replace(text, @"(?<!\r)\n", "\r\n");
			txtOutput.Text = text;
		}

		private void OpenOptions()
		{
			GobblerOptionsDlg options = new GobblerOptionsDlg();
			options.Options = Options;
			options.ShowDialog(this);
		}

		private void LoadOptions()
		{
			Options.LoadOptions();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadOptions();
		}

		private void btnProcess_Click(object sender, EventArgs e)
		{
			Process();
		}

		private void btnOptions_Click(object sender, EventArgs e)
		{
			OpenOptions();
		}
	}
}
