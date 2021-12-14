using System.ComponentModel;

namespace Notebook
{
    partial class ActivityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lbl_Main = new System.Windows.Forms.Label();
            this.btn_Change = new System.Windows.Forms.Button();
            this.txt_Text = new System.Windows.Forms.RichTextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CloseDetail = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Main
            // 
            this.lbl_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Main.Location = new System.Drawing.Point(12, 9);
            this.lbl_Main.Name = "lbl_Main";
            this.lbl_Main.Size = new System.Drawing.Size(145, 36);
            this.lbl_Main.TabIndex = 5;
            this.lbl_Main.Text = "Note options";
            this.lbl_Main.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Change
            // 
            this.btn_Change.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Change.Location = new System.Drawing.Point(294, 81);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(109, 39);
            this.btn_Change.TabIndex = 8;
            this.btn_Change.Text = "Edit";
            this.btn_Change.UseVisualStyleBackColor = false;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // txt_Text
            // 
            this.txt_Text.Location = new System.Drawing.Point(17, 144);
            this.txt_Text.Name = "txt_Text";
            this.txt_Text.Size = new System.Drawing.Size(261, 103);
            this.txt_Text.TabIndex = 13;
            this.txt_Text.Text = "";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(16, 81);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(261, 20);
            this.txt_Name.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Note text:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Note name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_CloseDetail
            // 
            this.btn_CloseDetail.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_CloseDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CloseDetail.Location = new System.Drawing.Point(294, 208);
            this.btn_CloseDetail.Name = "btn_CloseDetail";
            this.btn_CloseDetail.Size = new System.Drawing.Size(109, 39);
            this.btn_CloseDetail.TabIndex = 14;
            this.btn_CloseDetail.Text = "Close";
            this.btn_CloseDetail.UseVisualStyleBackColor = false;
            this.btn_CloseDetail.Click += new System.EventHandler(this.btn_CloseDetail_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(294, 144);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(109, 39);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // ActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 262);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_CloseDetail);
            this.Controls.Add(this.txt_Text);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.lbl_Main);
            this.Name = "ActivityForm";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btn_CloseDetail;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Main;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.RichTextBox txt_Text;

        #endregion
    }
}