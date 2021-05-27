namespace Widget
{
    partial class Widget
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxExchangeRate = new System.Windows.Forms.GroupBox();
            this.listBoxExchangeRate = new System.Windows.Forms.ListBox();
            this.groupBoxWeather = new System.Windows.Forms.GroupBox();
            this.pictureBoxWeather = new System.Windows.Forms.PictureBox();
            this.labelWeather = new System.Windows.Forms.Label();
            this.groupBoxHoroscope = new System.Windows.Forms.GroupBox();
            this.comboBoxZodiak = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxHoroscope = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxExchangeRate.SuspendLayout();
            this.groupBoxWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).BeginInit();
            this.groupBoxHoroscope.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxExchangeRate
            // 
            this.groupBoxExchangeRate.Controls.Add(this.listBoxExchangeRate);
            this.groupBoxExchangeRate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxExchangeRate.Location = new System.Drawing.Point(0, 0);
            this.groupBoxExchangeRate.Name = "groupBoxExchangeRate";
            this.groupBoxExchangeRate.Size = new System.Drawing.Size(121, 76);
            this.groupBoxExchangeRate.TabIndex = 0;
            this.groupBoxExchangeRate.TabStop = false;
            this.groupBoxExchangeRate.Text = "Курс валют";
            // 
            // listBoxExchangeRate
            // 
            this.listBoxExchangeRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxExchangeRate.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxExchangeRate.FormattingEnabled = true;
            this.listBoxExchangeRate.ItemHeight = 15;
            this.listBoxExchangeRate.Location = new System.Drawing.Point(3, 16);
            this.listBoxExchangeRate.Name = "listBoxExchangeRate";
            this.listBoxExchangeRate.Size = new System.Drawing.Size(115, 57);
            this.listBoxExchangeRate.TabIndex = 1;
            // 
            // groupBoxWeather
            // 
            this.groupBoxWeather.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxWeather.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxWeather.Location = new System.Drawing.Point(127, 0);
            this.groupBoxWeather.Name = "groupBoxWeather";
            this.groupBoxWeather.Size = new System.Drawing.Size(254, 76);
            this.groupBoxWeather.TabIndex = 1;
            this.groupBoxWeather.TabStop = false;
            this.groupBoxWeather.Text = "Погода в Ярцево";
            // 
            // pictureBoxWeather
            // 
            this.pictureBoxWeather.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxWeather.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxWeather.Location = new System.Drawing.Point(193, 3);
            this.pictureBoxWeather.Name = "pictureBoxWeather";
            this.pictureBoxWeather.Size = new System.Drawing.Size(46, 51);
            this.pictureBoxWeather.TabIndex = 1;
            this.pictureBoxWeather.TabStop = false;
            // 
            // labelWeather
            // 
            this.labelWeather.AutoSize = true;
            this.labelWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWeather.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeather.Location = new System.Drawing.Point(3, 0);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(184, 57);
            this.labelWeather.TabIndex = 0;
            // 
            // groupBoxHoroscope
            // 
            this.groupBoxHoroscope.Controls.Add(this.comboBoxZodiak);
            this.groupBoxHoroscope.Controls.Add(this.label1);
            this.groupBoxHoroscope.Controls.Add(this.richTextBoxHoroscope);
            this.groupBoxHoroscope.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxHoroscope.Location = new System.Drawing.Point(3, 82);
            this.groupBoxHoroscope.Name = "groupBoxHoroscope";
            this.groupBoxHoroscope.Size = new System.Drawing.Size(381, 189);
            this.groupBoxHoroscope.TabIndex = 2;
            this.groupBoxHoroscope.TabStop = false;
            this.groupBoxHoroscope.Text = "Гороскоп";
            // 
            // comboBoxZodiak
            // 
            this.comboBoxZodiak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZodiak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxZodiak.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxZodiak.FormattingEnabled = true;
            this.comboBoxZodiak.Location = new System.Drawing.Point(127, 13);
            this.comboBoxZodiak.Name = "comboBoxZodiak";
            this.comboBoxZodiak.Size = new System.Drawing.Size(242, 22);
            this.comboBoxZodiak.TabIndex = 2;
            this.comboBoxZodiak.SelectionChangeCommitted += new System.EventHandler(this.comboBoxZodiak_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Знак зодиака:";
            // 
            // richTextBoxHoroscope
            // 
            this.richTextBoxHoroscope.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxHoroscope.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxHoroscope.Location = new System.Drawing.Point(12, 41);
            this.richTextBoxHoroscope.Name = "richTextBoxHoroscope";
            this.richTextBoxHoroscope.ReadOnly = true;
            this.richTextBoxHoroscope.Size = new System.Drawing.Size(360, 141);
            this.richTextBoxHoroscope.TabIndex = 0;
            this.richTextBoxHoroscope.Text = "";
            this.richTextBoxHoroscope.ZoomFactor = 1.002F;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Controls.Add(this.labelWeather, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxWeather, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(242, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 270);
            this.Controls.Add(this.groupBoxHoroscope);
            this.Controls.Add(this.groupBoxWeather);
            this.Controls.Add(this.groupBoxExchangeRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Widget";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Widget_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseUp);
            this.groupBoxExchangeRate.ResumeLayout(false);
            this.groupBoxWeather.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).EndInit();
            this.groupBoxHoroscope.ResumeLayout(false);
            this.groupBoxHoroscope.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxExchangeRate;
        private System.Windows.Forms.ListBox listBoxExchangeRate;
        private System.Windows.Forms.GroupBox groupBoxWeather;
        private System.Windows.Forms.PictureBox pictureBoxWeather;
        private System.Windows.Forms.Label labelWeather;
        private System.Windows.Forms.GroupBox groupBoxHoroscope;
        private System.Windows.Forms.RichTextBox richTextBoxHoroscope;
        private System.Windows.Forms.ComboBox comboBoxZodiak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

