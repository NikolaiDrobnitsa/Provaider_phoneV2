
namespace Provaider_phone
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Name_label = new System.Windows.Forms.Label();
            this.Surname_Label = new System.Windows.Forms.Label();
            this.Number_Label = new System.Windows.Forms.Label();
            this.More_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Provaider_phone.Properties.Resources.info_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_label.Location = new System.Drawing.Point(80, 4);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(44, 24);
            this.Name_label.TabIndex = 1;
            this.Name_label.Text = "ivan";
            // 
            // Surname_Label
            // 
            this.Surname_Label.AutoSize = true;
            this.Surname_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname_Label.Location = new System.Drawing.Point(183, 3);
            this.Surname_Label.Name = "Surname_Label";
            this.Surname_Label.Size = new System.Drawing.Size(72, 24);
            this.Surname_Label.TabIndex = 2;
            this.Surname_Label.Text = "ivanilov";
            // 
            // Number_Label
            // 
            this.Number_Label.AutoSize = true;
            this.Number_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_Label.Location = new System.Drawing.Point(79, 28);
            this.Number_Label.Name = "Number_Label";
            this.Number_Label.Size = new System.Drawing.Size(142, 25);
            this.Number_Label.TabIndex = 3;
            this.Number_Label.Text = "3803234123";
            // 
            // More_button
            // 
            this.More_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.More_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.More_button.Location = new System.Drawing.Point(296, 10);
            this.More_button.Name = "More_button";
            this.More_button.Size = new System.Drawing.Size(62, 36);
            this.More_button.TabIndex = 4;
            this.More_button.Text = "More";
            this.More_button.UseVisualStyleBackColor = true;
            this.More_button.Click += new System.EventHandler(this.More_button_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.More_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Number_Label);
            this.Controls.Add(this.Surname_Label);
            this.Controls.Add(this.Name_label);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(364, 58);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Surname_Label;
        private System.Windows.Forms.Label Number_Label;
        private System.Windows.Forms.Button More_button;
    }
}
