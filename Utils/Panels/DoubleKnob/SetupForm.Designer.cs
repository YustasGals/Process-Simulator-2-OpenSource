﻿// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
namespace Utils.Panels.DoubleKnob
{
    partial class SetupForm
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
            this.textBox_ToolTip = new System.Windows.Forms.TextBox();
            this.label_ToolTip = new System.Windows.Forms.Label();
            this.colorEdit_Knob = new DevExpress.XtraEditors.ColorEdit();
            this.label_Knob = new System.Windows.Forms.Label();
            this.checkBox_ReadOnly = new System.Windows.Forms.CheckBox();
            this.groupBox_Color = new System.Windows.Forms.GroupBox();
            this.colorEdit_Scale = new DevExpress.XtraEditors.ColorEdit();
            this.label_Scale = new System.Windows.Forms.Label();
            this.colorEdit_Indicator = new DevExpress.XtraEditors.ColorEdit();
            this.label_Indicator = new System.Windows.Forms.Label();
            this.groupBox_Value = new System.Windows.Forms.GroupBox();
            this.Set = new System.Windows.Forms.Button();
            this.textBox_Max = new System.Windows.Forms.TextBox();
            this.Min = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.Label();
            this.textBox_Min = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit_Knob.Properties)).BeginInit();
            this.groupBox_Color.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit_Scale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit_Indicator.Properties)).BeginInit();
            this.groupBox_Value.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_ToolTip
            // 
            this.textBox_ToolTip.Location = new System.Drawing.Point(69, 6);
            this.textBox_ToolTip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ToolTip.Name = "textBox_ToolTip";
            this.textBox_ToolTip.Size = new System.Drawing.Size(217, 22);
            this.textBox_ToolTip.TabIndex = 0;
            this.textBox_ToolTip.TextChanged += new System.EventHandler(this.textBox_ToolTip_TextChanged);
            // 
            // label_ToolTip
            // 
            this.label_ToolTip.AutoSize = true;
            this.label_ToolTip.Location = new System.Drawing.Point(4, 9);
            this.label_ToolTip.Name = "label_ToolTip";
            this.label_ToolTip.Size = new System.Drawing.Size(60, 17);
            this.label_ToolTip.TabIndex = 29;
            this.label_ToolTip.Text = "ToolTip:";
            // 
            // colorEdit_Knob
            // 
            this.colorEdit_Knob.EditValue = System.Drawing.Color.Empty;
            this.colorEdit_Knob.Location = new System.Drawing.Point(77, 20);
            this.colorEdit_Knob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorEdit_Knob.Name = "colorEdit_Knob";
            this.colorEdit_Knob.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorEdit_Knob.Properties.LookAndFeel.SkinName = "Office 2010 Black";
            this.colorEdit_Knob.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.colorEdit_Knob.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.colorEdit_Knob.Size = new System.Drawing.Size(195, 24);
            this.colorEdit_Knob.TabIndex = 0;
            this.colorEdit_Knob.ColorChanged += new System.EventHandler(this.colorEdit_Knob_ColorChanged);
            // 
            // label_Knob
            // 
            this.label_Knob.AutoSize = true;
            this.label_Knob.Location = new System.Drawing.Point(28, 24);
            this.label_Knob.Name = "label_Knob";
            this.label_Knob.Size = new System.Drawing.Size(45, 17);
            this.label_Knob.TabIndex = 32;
            this.label_Knob.Text = "Knob:";
            // 
            // checkBox_ReadOnly
            // 
            this.checkBox_ReadOnly.AutoSize = true;
            this.checkBox_ReadOnly.Location = new System.Drawing.Point(69, 34);
            this.checkBox_ReadOnly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_ReadOnly.Name = "checkBox_ReadOnly";
            this.checkBox_ReadOnly.Size = new System.Drawing.Size(94, 21);
            this.checkBox_ReadOnly.TabIndex = 1;
            this.checkBox_ReadOnly.Text = "Read only";
            this.checkBox_ReadOnly.UseVisualStyleBackColor = true;
            this.checkBox_ReadOnly.CheckedChanged += new System.EventHandler(this.checkBox_ReadOnly_CheckedChanged);
            // 
            // groupBox_Color
            // 
            this.groupBox_Color.Controls.Add(this.colorEdit_Scale);
            this.groupBox_Color.Controls.Add(this.label_Scale);
            this.groupBox_Color.Controls.Add(this.colorEdit_Indicator);
            this.groupBox_Color.Controls.Add(this.label_Indicator);
            this.groupBox_Color.Controls.Add(this.colorEdit_Knob);
            this.groupBox_Color.Controls.Add(this.label_Knob);
            this.groupBox_Color.Location = new System.Drawing.Point(7, 58);
            this.groupBox_Color.Name = "groupBox_Color";
            this.groupBox_Color.Size = new System.Drawing.Size(279, 112);
            this.groupBox_Color.TabIndex = 2;
            this.groupBox_Color.TabStop = false;
            this.groupBox_Color.Text = "Color";
            // 
            // colorEdit_Scale
            // 
            this.colorEdit_Scale.EditValue = System.Drawing.Color.Empty;
            this.colorEdit_Scale.Location = new System.Drawing.Point(77, 78);
            this.colorEdit_Scale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorEdit_Scale.Name = "colorEdit_Scale";
            this.colorEdit_Scale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorEdit_Scale.Properties.LookAndFeel.SkinName = "Office 2010 Black";
            this.colorEdit_Scale.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.colorEdit_Scale.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.colorEdit_Scale.Size = new System.Drawing.Size(195, 24);
            this.colorEdit_Scale.TabIndex = 2;
            this.colorEdit_Scale.ColorChanged += new System.EventHandler(this.colorEdit_Scale_ColorChanged);
            // 
            // label_Scale
            // 
            this.label_Scale.AutoSize = true;
            this.label_Scale.Location = new System.Drawing.Point(26, 82);
            this.label_Scale.Name = "label_Scale";
            this.label_Scale.Size = new System.Drawing.Size(47, 17);
            this.label_Scale.TabIndex = 36;
            this.label_Scale.Text = "Scale:";
            // 
            // colorEdit_Indicator
            // 
            this.colorEdit_Indicator.EditValue = System.Drawing.Color.Empty;
            this.colorEdit_Indicator.Location = new System.Drawing.Point(77, 49);
            this.colorEdit_Indicator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorEdit_Indicator.Name = "colorEdit_Indicator";
            this.colorEdit_Indicator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorEdit_Indicator.Properties.LookAndFeel.SkinName = "Office 2010 Black";
            this.colorEdit_Indicator.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.colorEdit_Indicator.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.colorEdit_Indicator.Size = new System.Drawing.Size(195, 24);
            this.colorEdit_Indicator.TabIndex = 1;
            this.colorEdit_Indicator.ColorChanged += new System.EventHandler(this.colorEdit_Indicator_ColorChanged);
            // 
            // label_Indicator
            // 
            this.label_Indicator.AutoSize = true;
            this.label_Indicator.Location = new System.Drawing.Point(7, 53);
            this.label_Indicator.Name = "label_Indicator";
            this.label_Indicator.Size = new System.Drawing.Size(66, 17);
            this.label_Indicator.TabIndex = 34;
            this.label_Indicator.Text = "Indicator:";
            // 
            // groupBox_Value
            // 
            this.groupBox_Value.Controls.Add(this.Set);
            this.groupBox_Value.Controls.Add(this.textBox_Max);
            this.groupBox_Value.Controls.Add(this.Min);
            this.groupBox_Value.Controls.Add(this.Max);
            this.groupBox_Value.Controls.Add(this.textBox_Min);
            this.groupBox_Value.Location = new System.Drawing.Point(7, 176);
            this.groupBox_Value.Name = "groupBox_Value";
            this.groupBox_Value.Size = new System.Drawing.Size(279, 119);
            this.groupBox_Value.TabIndex = 3;
            this.groupBox_Value.TabStop = false;
            this.groupBox_Value.Text = "Value";
            // 
            // Set
            // 
            this.Set.Location = new System.Drawing.Point(106, 86);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(75, 25);
            this.Set.TabIndex = 2;
            this.Set.Text = "Set";
            this.Set.UseVisualStyleBackColor = true;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // textBox_Max
            // 
            this.textBox_Max.Location = new System.Drawing.Point(84, 24);
            this.textBox_Max.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Max.Name = "textBox_Max";
            this.textBox_Max.Size = new System.Drawing.Size(161, 22);
            this.textBox_Max.TabIndex = 0;
            this.textBox_Max.Text = "100";
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Location = new System.Drawing.Point(45, 57);
            this.Min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(34, 17);
            this.Min.TabIndex = 35;
            this.Min.Text = "Min:";
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Location = new System.Drawing.Point(42, 27);
            this.Max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(37, 17);
            this.Max.TabIndex = 34;
            this.Max.Text = "Max:";
            // 
            // textBox_Min
            // 
            this.textBox_Min.Location = new System.Drawing.Point(84, 54);
            this.textBox_Min.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Min.Name = "textBox_Min";
            this.textBox_Min.Size = new System.Drawing.Size(161, 22);
            this.textBox_Min.TabIndex = 1;
            this.textBox_Min.Text = "0";
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 299);
            this.Controls.Add(this.groupBox_Value);
            this.Controls.Add(this.groupBox_Color);
            this.Controls.Add(this.checkBox_ReadOnly);
            this.Controls.Add(this.textBox_ToolTip);
            this.Controls.Add(this.label_ToolTip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Knob";
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SetupForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit_Knob.Properties)).EndInit();
            this.groupBox_Color.ResumeLayout(false);
            this.groupBox_Color.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit_Scale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit_Indicator.Properties)).EndInit();
            this.groupBox_Value.ResumeLayout(false);
            this.groupBox_Value.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ToolTip;
        private System.Windows.Forms.Label label_ToolTip;
        private DevExpress.XtraEditors.ColorEdit colorEdit_Knob;
        private System.Windows.Forms.Label label_Knob;
        private System.Windows.Forms.CheckBox checkBox_ReadOnly;
        private System.Windows.Forms.GroupBox groupBox_Color;
        private DevExpress.XtraEditors.ColorEdit colorEdit_Scale;
        private System.Windows.Forms.Label label_Scale;
        private DevExpress.XtraEditors.ColorEdit colorEdit_Indicator;
        private System.Windows.Forms.Label label_Indicator;
        private System.Windows.Forms.GroupBox groupBox_Value;
        private System.Windows.Forms.Button Set;
        private System.Windows.Forms.TextBox textBox_Max;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.TextBox textBox_Min;
    }
}