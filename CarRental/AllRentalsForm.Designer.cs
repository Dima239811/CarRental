namespace CarRental
{
    partial class AllRentalsForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddRentBtn = new System.Windows.Forms.Button();
            this.DeleteRentBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(171, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Текущий список аренд";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(626, 122);
            this.dataGridView1.TabIndex = 2;
            // 
            // AddRentBtn
            // 
            this.AddRentBtn.BackColor = System.Drawing.SystemColors.Info;
            this.AddRentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRentBtn.Location = new System.Drawing.Point(22, 205);
            this.AddRentBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddRentBtn.Name = "AddRentBtn";
            this.AddRentBtn.Size = new System.Drawing.Size(267, 39);
            this.AddRentBtn.TabIndex = 3;
            this.AddRentBtn.Text = "Добавить новую аренду";
            this.AddRentBtn.UseVisualStyleBackColor = false;
            this.AddRentBtn.Click += new System.EventHandler(this.AddRentBtn_Click);
            // 
            // DeleteRentBtn
            // 
            this.DeleteRentBtn.BackColor = System.Drawing.SystemColors.Info;
            this.DeleteRentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteRentBtn.Location = new System.Drawing.Point(370, 205);
            this.DeleteRentBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteRentBtn.Name = "DeleteRentBtn";
            this.DeleteRentBtn.Size = new System.Drawing.Size(267, 39);
            this.DeleteRentBtn.TabIndex = 4;
            this.DeleteRentBtn.Text = "Удалить аренду";
            this.DeleteRentBtn.UseVisualStyleBackColor = false;
            this.DeleteRentBtn.Click += new System.EventHandler(this.DeleteRentBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AllRentalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 270);
            this.Controls.Add(this.DeleteRentBtn);
            this.Controls.Add(this.AddRentBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AllRentalsForm";
            this.Text = "Все аренды";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddRentBtn;
        private System.Windows.Forms.Button DeleteRentBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}