using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextGobbler;

namespace PhraseGobbler
{
	public partial class GobblerOptionsDlg : Form
	{
		private Gobbler.GobbleOptions _options;

		public Gobbler.GobbleOptions Options
		{
			get => _options;
			set
			{
				_options = value;
				UpdateDisplay();
			}
		}

		private bool _dirty;
		private bool Dirty
		{
			get => _dirty;
			set
			{
				_dirty = value;
				btnApply.Enabled = _dirty;
			}
		}

		public GobblerOptionsDlg()
		{
			InitializeComponent();
		}

		private void UpdateDisplay()
		{
			cboExclusiveParagraphs.Checked = Options.ExclusiveParagraphs;
			cboPrioritizeLongWords.Checked = Options.PrioritizeLongWords;
			cboAddJunk.Checked = Options.AddJunk;
			txtSeed.Text = Options.Seed;

			Dirty = false;
		}

		private void Apply()
		{
			if (!Dirty)
				return;
			Options.ExclusiveParagraphs = cboExclusiveParagraphs.Checked;
			Options.PrioritizeLongWords = cboPrioritizeLongWords.Checked;
			Options.AddJunk = cboAddJunk.Checked;
			Options.Seed = txtSeed.Text;

			Dirty = false;

			Options.SaveOptions();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Apply();
			Close();
		}

		private void btnApply_Click(object sender, EventArgs e)
		{
			Apply();
		}

		private void cboExclusiveParagraphs_CheckedChanged(object sender, EventArgs e)
		{
			Dirty = true;
		}

		private void cboPrioritizeLongWords_CheckedChanged(object sender, EventArgs e)
		{
			Dirty = true;
		}

		private void cboAddJunk_CheckedChanged(object sender, EventArgs e)
		{
			Dirty = true;
		}

		private void txtSeed_TextChanged(object sender, EventArgs e)
		{
			Dirty = true;
		}
	}
}
