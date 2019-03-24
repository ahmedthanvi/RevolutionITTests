namespace WeatherAPIWinForm
{
    partial class WeatherForm
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
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnForecast = new System.Windows.Forms.Button();
            this.lvwForecast = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboQuery = new System.Windows.Forms.ComboBox();
            this.lblReportFilter = new System.Windows.Forms.Label();
            this.txtBoxfiltertemp = new System.Windows.Forms.TextBox();
            this.lblDegrees = new System.Windows.Forms.Label();
            this.chkBoxSunny = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Forecast report:";
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.Location = new System.Drawing.Point(121, 11);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(373, 22);
            this.txtLocation.TabIndex = 15;
            this.txtLocation.Text = "Sydney";
            // 
            // btnForecast
            // 
            this.btnForecast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnForecast.Location = new System.Drawing.Point(187, 110);
            this.btnForecast.Margin = new System.Windows.Forms.Padding(4);
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.Size = new System.Drawing.Size(100, 28);
            this.btnForecast.TabIndex = 16;
            this.btnForecast.Text = "Start";
            this.btnForecast.UseVisualStyleBackColor = true;
            this.btnForecast.Click += new System.EventHandler(this.btnForecast_Click);
            // 
            // lvwForecast
            // 
            this.lvwForecast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwForecast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwForecast.Location = new System.Drawing.Point(16, 146);
            this.lvwForecast.Margin = new System.Windows.Forms.Padding(4);
            this.lvwForecast.Name = "lvwForecast";
            this.lvwForecast.Size = new System.Drawing.Size(479, 378);
            this.lvwForecast.TabIndex = 19;
            this.lvwForecast.UseCompatibleStateImageBehavior = false;
            this.lvwForecast.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Day";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Temperature";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sunny?";
            this.columnHeader4.Width = 72;
            // 
            // cboQuery
            // 
            this.cboQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuery.FormattingEnabled = true;
            this.cboQuery.Location = new System.Drawing.Point(16, 10);
            this.cboQuery.Margin = new System.Windows.Forms.Padding(4);
            this.cboQuery.Name = "cboQuery";
            this.cboQuery.Size = new System.Drawing.Size(96, 24);
            this.cboQuery.TabIndex = 30;
            // 
            // lblReportFilter
            // 
            this.lblReportFilter.AutoSize = true;
            this.lblReportFilter.Location = new System.Drawing.Point(18, 52);
            this.lblReportFilter.Name = "lblReportFilter";
            this.lblReportFilter.Size = new System.Drawing.Size(269, 17);
            this.lblReportFilter.TabIndex = 31;
            this.lblReportFilter.Text = "Filter report for temperature greater than ";
            this.lblReportFilter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBoxfiltertemp
            // 
            this.txtBoxfiltertemp.Location = new System.Drawing.Point(283, 49);
            this.txtBoxfiltertemp.Name = "txtBoxfiltertemp";
            this.txtBoxfiltertemp.Size = new System.Drawing.Size(39, 22);
            this.txtBoxfiltertemp.TabIndex = 32;
            this.txtBoxfiltertemp.Text = "20";
            this.txtBoxfiltertemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDegrees
            // 
            this.lblDegrees.AutoSize = true;
            this.lblDegrees.Location = new System.Drawing.Point(328, 54);
            this.lblDegrees.Name = "lblDegrees";
            this.lblDegrees.Size = new System.Drawing.Size(60, 17);
            this.lblDegrees.TabIndex = 33;
            this.lblDegrees.Text = "degrees";
            // 
            // chkBoxSunny
            // 
            this.chkBoxSunny.AutoSize = true;
            this.chkBoxSunny.Location = new System.Drawing.Point(21, 73);
            this.chkBoxSunny.Name = "chkBoxSunny";
            this.chkBoxSunny.Size = new System.Drawing.Size(254, 21);
            this.chkBoxSunny.TabIndex = 34;
            this.chkBoxSunny.Text = "Only show Sunny days in the report";
            this.chkBoxSunny.UseVisualStyleBackColor = true;
            // 
            // WeatherForm
            // 
            this.AcceptButton = this.btnForecast;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 539);
            this.Controls.Add(this.chkBoxSunny);
            this.Controls.Add(this.lblDegrees);
            this.Controls.Add(this.txtBoxfiltertemp);
            this.Controls.Add(this.lblReportFilter);
            this.Controls.Add(this.cboQuery);
            this.Controls.Add(this.lvwForecast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnForecast);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WeatherForm";
            this.Text = "Ahmed Khan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnForecast;
        private System.Windows.Forms.ListView lvwForecast;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox cboQuery;
        private System.Windows.Forms.Label lblReportFilter;
        private System.Windows.Forms.TextBox txtBoxfiltertemp;
        private System.Windows.Forms.Label lblDegrees;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.CheckBox chkBoxSunny;
    }
}


