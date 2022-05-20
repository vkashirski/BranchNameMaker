using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace BranchMaker {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		public void MakeGitBranch() {

			// Validate Type
			if (comboBoxType.SelectedItem == null) {
				MessageBoxResult result = System.Windows.MessageBox.Show("Error - Type not selected.", "Error");
				textBoxFinal.Clear();
			}

			// Validate ID
			else if (string.IsNullOrEmpty(textBoxID.Text.ToString()) || IsNotOnlyDigits(textBoxID.Text.ToString())) {
				MessageBoxResult result = System.Windows.MessageBox.Show("Error - Invalid ID.", "Error");
				textBoxFinal.Clear();
			}

			// Validate Description
			else if (string.IsNullOrEmpty(textBoxDescription.Text.ToString())) {
				MessageBoxResult result = System.Windows.MessageBox.Show("Error - No description.", "Error");
				textBoxFinal.Clear();
			}

			//Exclude invalid characters
			else {
				string type = comboBoxType.SelectedItem.ToString();
				string id = textBoxID.Text.ToString();
				string description = ExcludeInvalidCharacters(textBoxDescription.Text.ToString()).ToLower();

				string branchName = type + "/" + id + "-" + description;
				textBoxFinal.Text = branchName;
				if (branchName.Count() > 140) {
					MessageBoxResult result = System.Windows.MessageBox.Show("Warning - Branch name might be too long, consider making it shorter.", "Warning");
				}
			}
		}

		private string ExcludeInvalidCharacters(string desc) {
			string validCharsString = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-";
			char[] validChars = validCharsString.ToCharArray();
			char[] description = desc.ToCharArray();

			StringBuilder sb = new StringBuilder();
			foreach (char d in description) {
				if (d == ' ')
					sb.Append('-');
				foreach (char c in validChars) {
					if (c == d) {
						sb.Append(d);
						break;
					}
				}
			}

			return DeleteExtraHyphens(sb.ToString().ToLower());
		}

		public string DeleteExtraHyphens(string description) {

			char[] chars = description.ToCharArray();
			int hyphenCounter = 0;
			bool flagToStart = false; 

			// For beginning and middle
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < chars.Length; i++) {
				if (chars[i] == '-' && flagToStart == true) {
					hyphenCounter++;
					if (hyphenCounter == 1) {
						sb.Append(chars[i]);
					}
				}
				else if (chars[i] != '-') {
					sb.Append(chars[i]);
					hyphenCounter = 0;
					flagToStart = true;
				}
			}

			// For end
			string s = sb.ToString();
			if (s.ElementAt(s.Length - 1) == '-') {
				s = s.Remove(s.Length - 1, 1);
			}

			return s;
		}

		private bool IsNotOnlyDigits(string id) {
			string validCharsString = "0123456789";
			char[] validChars = validCharsString.ToCharArray();
			char[] ID = id.ToCharArray();

			bool isValid = false;
			foreach (char i in ID) {
				isValid = false;
				foreach (char c in validChars) {
					if (c == i) {
						isValid = true;
						break;
					}
				}
			}

			return !isValid;
		}

		private void buttonMakeGitBranch_Click(object sender, EventArgs e) {
			MakeGitBranch();
		}

		private void CopyToClipboard() {
			Clipboard.SetText(textBoxFinal.Text.ToString());
		}

		private void buttonCopyToClipboard_Click(object sender, EventArgs e) {
			if (!string.IsNullOrEmpty(textBoxFinal.Text)) {
				CopyToClipboard();
			}
		}
	}
}
