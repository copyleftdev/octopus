using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Octopus.CDIndex {
	public class DlgDiscProperties : BaseDialogs.FormDialogBase {
		private Label llCdLabel;
		private Label label2;
		private TextBox tbUserLabel;
		private Label label1;
		private Label label3;
		private Label llDriveFormat;
		private Label llDriveType;
		private Label label5;
		private Label llFreeSpace;
		private Label label6;
		private Label llSize;
		private Label label8;
		private TextBox tbKeywords;
		private Label label4;
        private ToolTip toolTip1;
		private System.ComponentModel.IContainer components = null;

		public DlgDiscProperties() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgDiscProperties));
            this.llCdLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.llDriveFormat = new System.Windows.Forms.Label();
            this.llDriveType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.llFreeSpace = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.llSize = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbKeywords = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            // 
            // llCdLabel
            // 
            resources.ApplyResources(this.llCdLabel, "llCdLabel");
            this.llCdLabel.Name = "llCdLabel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbUserLabel
            // 
            resources.ApplyResources(this.tbUserLabel, "tbUserLabel");
            this.tbUserLabel.Name = "tbUserLabel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // llDriveFormat
            // 
            resources.ApplyResources(this.llDriveFormat, "llDriveFormat");
            this.llDriveFormat.Name = "llDriveFormat";
            // 
            // llDriveType
            // 
            resources.ApplyResources(this.llDriveType, "llDriveType");
            this.llDriveType.Name = "llDriveType";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // llFreeSpace
            // 
            resources.ApplyResources(this.llFreeSpace, "llFreeSpace");
            this.llFreeSpace.Name = "llFreeSpace";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // llSize
            // 
            resources.ApplyResources(this.llSize, "llSize");
            this.llSize.Name = "llSize";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // tbKeywords
            // 
            resources.ApplyResources(this.tbKeywords, "tbKeywords");
            this.tbKeywords.Name = "tbKeywords";
            this.toolTip1.SetToolTip(this.tbKeywords, resources.GetString("tbKeywords.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 600;
            this.toolTip1.AutoPopDelay = 6000;
            this.toolTip1.InitialDelay = 60;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 120;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Blue Mirror Info";
            // 
            // DlgDiscProperties
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tbKeywords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.llSize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.llFreeSpace);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.llDriveType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.llDriveFormat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llCdLabel);
            this.Controls.Add(this.tbUserLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "DlgDiscProperties";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbUserLabel, 0);
            this.Controls.SetChildIndex(this.llCdLabel, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.llDriveFormat, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.llDriveType, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.llFreeSpace, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.llSize, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbKeywords, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		internal static bool GetDiscName(out string discName, out string keywords, string drive) {
			DlgDiscProperties dlg = new DlgDiscProperties();
			DriveInfo di = new DriveInfo(drive);
			dlg.tbUserLabel.Text = dlg.llCdLabel.Text = di.VolumeLabel;
			dlg.llDriveFormat.Text = di.DriveFormat;
			dlg.llDriveType.Text = di.DriveType.ToString();
			dlg.llFreeSpace.Text = CustomConvert.ToKB(di.TotalFreeSpace);
			dlg.llSize.Text = CustomConvert.ToKB(di.TotalSize);
			dlg.tbKeywords.Text = "";

			if (dlg.ShowDialog() == DialogResult.OK) {
				discName = dlg.tbUserLabel.Text;
				keywords = dlg.tbKeywords.Text;
				return true;
			}
			else {
				discName = keywords = "";
				return false;
			}
		}

		internal static bool ChangeUserLabel(DiscInDatabase discInDatabase) {
			DlgDiscProperties dlg = new DlgDiscProperties();
			dlg.tbUserLabel.Text = discInDatabase.Name;
			dlg.llCdLabel.Text = discInDatabase.VolumeLabel;
			dlg.llDriveFormat.Text = discInDatabase.DriveFormat;
			dlg.llDriveType.Text = discInDatabase.DriveType.ToString();
			dlg.llFreeSpace.Text = CustomConvert.ToKB(discInDatabase.TotalFreeSpace);
			dlg.llSize.Text = CustomConvert.ToKB(discInDatabase.TotalSize);
			dlg.tbKeywords.Text = discInDatabase.Keywords;

			if (dlg.ShowDialog() == DialogResult.OK) {
				discInDatabase.Name = dlg.tbUserLabel.Text;
				discInDatabase.Keywords = dlg.tbKeywords.Text;
				return true;
			}
			else
				return false;
				
		}
	}
}

