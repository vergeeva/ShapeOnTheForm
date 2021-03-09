
namespace ГеометрическиеФигуры
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Okay = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.ValueX = new System.Windows.Forms.TextBox();
            this.ValueY = new System.Windows.Forms.TextBox();
            this.ValueR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Х-координата центра";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "У-координата центра";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Радиус";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Okay
            // 
            this.Okay.Location = new System.Drawing.Point(72, 178);
            this.Okay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Okay.Name = "Okay";
            this.Okay.Size = new System.Drawing.Size(98, 36);
            this.Okay.TabIndex = 3;
            this.Okay.Text = "ОК";
            this.Okay.UseVisualStyleBackColor = true;
            this.Okay.Click += new System.EventHandler(this.Okay_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(176, 178);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(98, 36);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ValueX
            // 
            this.ValueX.Location = new System.Drawing.Point(72, 34);
            this.ValueX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValueX.Name = "ValueX";
            this.ValueX.Size = new System.Drawing.Size(202, 27);
            this.ValueX.TabIndex = 5;
            // 
            // ValueY
            // 
            this.ValueY.Location = new System.Drawing.Point(72, 91);
            this.ValueY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValueY.Name = "ValueY";
            this.ValueY.Size = new System.Drawing.Size(202, 27);
            this.ValueY.TabIndex = 6;
            // 
            // ValueR
            // 
            this.ValueR.Location = new System.Drawing.Point(72, 145);
            this.ValueR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValueR.Name = "ValueR";
            this.ValueR.Size = new System.Drawing.Size(202, 27);
            this.ValueR.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 236);
            this.Controls.Add(this.ValueR);
            this.Controls.Add(this.ValueY);
            this.Controls.Add(this.ValueX);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Okay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод данных";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Okay;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox ValueX;
        private System.Windows.Forms.TextBox ValueY;
        private System.Windows.Forms.TextBox ValueR;
    }
}