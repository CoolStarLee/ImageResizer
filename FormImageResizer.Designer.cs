namespace ResizePicture
{
    partial class FormImageResizer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImageResizer));
            this.DlgFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.m_TxtBoxInput = new System.Windows.Forms.TextBox();
            this.m_BtnInputBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_BtnOutputBrowse = new System.Windows.Forms.Button();
            this.m_TxtBoxOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_TxtBoxHorizontal = new System.Windows.Forms.TextBox();
            this.m_TxtBoxVertical = new System.Windows.Forms.TextBox();
            this.m_CheckBoxMaintainRatio = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_RadioBtnPixels = new System.Windows.Forms.RadioButton();
            this.m_RadioBtnPercentage = new System.Windows.Forms.RadioButton();
            this.m_BtnStart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.m_TxtBoxSuffix = new System.Windows.Forms.TextBox();
            this.m_LabelInfro = new System.Windows.Forms.Label();
            this.m_ProgressBarResize = new System.Windows.Forms.ProgressBar();
            this.m_TrackBarQuality = new System.Windows.Forms.TrackBar();
            this.m_GroupBoxQuality = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.m_RadioBtnOneFifth = new System.Windows.Forms.RadioButton();
            this.m_RadioBtnQuarter = new System.Windows.Forms.RadioButton();
            this.m_RadioBtnOneThird = new System.Windows.Forms.RadioButton();
            this.m_RadioBtnHalf = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_TrackBarQuality)).BeginInit();
            this.m_GroupBoxQuality.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_TxtBoxInput
            // 
            resources.ApplyResources(this.m_TxtBoxInput, "m_TxtBoxInput");
            this.m_TxtBoxInput.Name = "m_TxtBoxInput";
            // 
            // m_BtnInputBrowse
            // 
            resources.ApplyResources(this.m_BtnInputBrowse, "m_BtnInputBrowse");
            this.m_BtnInputBrowse.Name = "m_BtnInputBrowse";
            this.m_BtnInputBrowse.UseVisualStyleBackColor = true;
            this.m_BtnInputBrowse.Click += new System.EventHandler(this.BtnInputBrowse_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.m_BtnOutputBrowse);
            this.groupBox1.Controls.Add(this.m_TxtBoxOutput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.m_BtnInputBrowse);
            this.groupBox1.Controls.Add(this.m_TxtBoxInput);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // m_BtnOutputBrowse
            // 
            resources.ApplyResources(this.m_BtnOutputBrowse, "m_BtnOutputBrowse");
            this.m_BtnOutputBrowse.Name = "m_BtnOutputBrowse";
            this.m_BtnOutputBrowse.UseVisualStyleBackColor = true;
            this.m_BtnOutputBrowse.Click += new System.EventHandler(this.BtnOutputBrowse_Click);
            // 
            // m_TxtBoxOutput
            // 
            resources.ApplyResources(this.m_TxtBoxOutput, "m_TxtBoxOutput");
            this.m_TxtBoxOutput.Name = "m_TxtBoxOutput";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Name = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_RadioBtnOneFifth);
            this.groupBox2.Controls.Add(this.m_RadioBtnQuarter);
            this.groupBox2.Controls.Add(this.m_RadioBtnOneThird);
            this.groupBox2.Controls.Add(this.m_RadioBtnHalf);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.m_TxtBoxHorizontal);
            this.groupBox2.Controls.Add(this.m_TxtBoxVertical);
            this.groupBox2.Controls.Add(this.m_CheckBoxMaintainRatio);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.m_RadioBtnPixels);
            this.groupBox2.Controls.Add(this.m_RadioBtnPercentage);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // m_TxtBoxHorizontal
            // 
            resources.ApplyResources(this.m_TxtBoxHorizontal, "m_TxtBoxHorizontal");
            this.m_TxtBoxHorizontal.Name = "m_TxtBoxHorizontal";
            this.m_TxtBoxHorizontal.TextChanged += new System.EventHandler(this.TxtBoxHorizontal_TextChanged);
            this.m_TxtBoxHorizontal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox_KeyPress);
            // 
            // m_TxtBoxVertical
            // 
            resources.ApplyResources(this.m_TxtBoxVertical, "m_TxtBoxVertical");
            this.m_TxtBoxVertical.Name = "m_TxtBoxVertical";
            this.m_TxtBoxVertical.TextChanged += new System.EventHandler(this.TxtBoxVertical_TextChanged);
            this.m_TxtBoxVertical.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox_KeyPress);
            // 
            // m_CheckBoxMaintainRatio
            // 
            resources.ApplyResources(this.m_CheckBoxMaintainRatio, "m_CheckBoxMaintainRatio");
            this.m_CheckBoxMaintainRatio.Name = "m_CheckBoxMaintainRatio";
            this.m_CheckBoxMaintainRatio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // m_RadioBtnPixels
            // 
            resources.ApplyResources(this.m_RadioBtnPixels, "m_RadioBtnPixels");
            this.m_RadioBtnPixels.Name = "m_RadioBtnPixels";
            this.m_RadioBtnPixels.TabStop = true;
            this.m_RadioBtnPixels.UseVisualStyleBackColor = true;
            // 
            // m_RadioBtnPercentage
            // 
            resources.ApplyResources(this.m_RadioBtnPercentage, "m_RadioBtnPercentage");
            this.m_RadioBtnPercentage.Name = "m_RadioBtnPercentage";
            this.m_RadioBtnPercentage.TabStop = true;
            this.m_RadioBtnPercentage.UseVisualStyleBackColor = true;
            // 
            // m_BtnStart
            // 
            resources.ApplyResources(this.m_BtnStart, "m_BtnStart");
            this.m_BtnStart.Name = "m_BtnStart";
            this.m_BtnStart.UseVisualStyleBackColor = true;
            this.m_BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.m_TxtBoxSuffix);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // m_TxtBoxSuffix
            // 
            resources.ApplyResources(this.m_TxtBoxSuffix, "m_TxtBoxSuffix");
            this.m_TxtBoxSuffix.Name = "m_TxtBoxSuffix";
            // 
            // m_LabelInfro
            // 
            resources.ApplyResources(this.m_LabelInfro, "m_LabelInfro");
            this.m_LabelInfro.ForeColor = System.Drawing.Color.Red;
            this.m_LabelInfro.Name = "m_LabelInfro";
            // 
            // m_ProgressBarResize
            // 
            resources.ApplyResources(this.m_ProgressBarResize, "m_ProgressBarResize");
            this.m_ProgressBarResize.Name = "m_ProgressBarResize";
            // 
            // m_TrackBarQuality
            // 
            resources.ApplyResources(this.m_TrackBarQuality, "m_TrackBarQuality");
            this.m_TrackBarQuality.Maximum = 100;
            this.m_TrackBarQuality.Minimum = 10;
            this.m_TrackBarQuality.Name = "m_TrackBarQuality";
            this.m_TrackBarQuality.TickStyle = System.Windows.Forms.TickStyle.None;
            this.m_TrackBarQuality.Value = 100;
            this.m_TrackBarQuality.Scroll += new System.EventHandler(this.TrackBarQuality_Scroll);
            // 
            // m_GroupBoxQuality
            // 
            this.m_GroupBoxQuality.Controls.Add(this.m_TrackBarQuality);
            resources.ApplyResources(this.m_GroupBoxQuality, "m_GroupBoxQuality");
            this.m_GroupBoxQuality.Name = "m_GroupBoxQuality";
            this.m_GroupBoxQuality.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // m_RadioBtnOneFifth
            // 
            resources.ApplyResources(this.m_RadioBtnOneFifth, "m_RadioBtnOneFifth");
            this.m_RadioBtnOneFifth.Name = "m_RadioBtnOneFifth";
            this.m_RadioBtnOneFifth.TabStop = true;
            this.m_RadioBtnOneFifth.UseVisualStyleBackColor = true;
            // 
            // m_RadioBtnQuarter
            // 
            resources.ApplyResources(this.m_RadioBtnQuarter, "m_RadioBtnQuarter");
            this.m_RadioBtnQuarter.Name = "m_RadioBtnQuarter";
            this.m_RadioBtnQuarter.TabStop = true;
            this.m_RadioBtnQuarter.UseVisualStyleBackColor = true;
            // 
            // m_RadioBtnOneThird
            // 
            resources.ApplyResources(this.m_RadioBtnOneThird, "m_RadioBtnOneThird");
            this.m_RadioBtnOneThird.Name = "m_RadioBtnOneThird";
            this.m_RadioBtnOneThird.TabStop = true;
            this.m_RadioBtnOneThird.UseVisualStyleBackColor = true;
            // 
            // m_RadioBtnHalf
            // 
            resources.ApplyResources(this.m_RadioBtnHalf, "m_RadioBtnHalf");
            this.m_RadioBtnHalf.Name = "m_RadioBtnHalf";
            this.m_RadioBtnHalf.TabStop = true;
            this.m_RadioBtnHalf.UseVisualStyleBackColor = true;
            // 
            // FormImageResizer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_GroupBoxQuality);
            this.Controls.Add(this.m_ProgressBarResize);
            this.Controls.Add(this.m_LabelInfro);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.m_BtnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormImageResizer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_TrackBarQuality)).EndInit();
            this.m_GroupBoxQuality.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog DlgFolderBrowser;
        private System.Windows.Forms.TextBox m_TxtBoxInput;
        private System.Windows.Forms.Button m_BtnInputBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button m_BtnOutputBrowse;
        private System.Windows.Forms.TextBox m_TxtBoxOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_TxtBoxHorizontal;
        private System.Windows.Forms.TextBox m_TxtBoxVertical;
        private System.Windows.Forms.CheckBox m_CheckBoxMaintainRatio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton m_RadioBtnPixels;
        private System.Windows.Forms.RadioButton m_RadioBtnPercentage;
        private System.Windows.Forms.Button m_BtnStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox m_TxtBoxSuffix;
        private System.Windows.Forms.Label m_LabelInfro;
        private System.Windows.Forms.ProgressBar m_ProgressBarResize;
        private System.Windows.Forms.TrackBar m_TrackBarQuality;
        private System.Windows.Forms.GroupBox m_GroupBoxQuality;
        private System.Windows.Forms.RadioButton m_RadioBtnOneFifth;
        private System.Windows.Forms.RadioButton m_RadioBtnQuarter;
        private System.Windows.Forms.RadioButton m_RadioBtnOneThird;
        private System.Windows.Forms.RadioButton m_RadioBtnHalf;
        private System.Windows.Forms.Label label7;
    }
}

