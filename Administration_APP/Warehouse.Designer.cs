namespace Administration_APP
{
    partial class Warehouse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtLogout = new MetroFramework.Controls.MetroTile();
            this.StorageGridView = new System.Windows.Forms.DataGridView();
            this.mtDelete = new MetroFramework.Controls.MetroTile();
            this.mtModify = new MetroFramework.Controls.MetroTile();
            this.mtRefresh = new MetroFramework.Controls.MetroTile();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StorageGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtLogout
            // 
            this.mtLogout.BackColor = System.Drawing.Color.White;
            this.mtLogout.Location = new System.Drawing.Point(24, 382);
            this.mtLogout.Name = "mtLogout";
            this.mtLogout.Size = new System.Drawing.Size(87, 74);
            this.mtLogout.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtLogout.TabIndex = 9;
            this.mtLogout.Text = "Log Out";
            this.mtLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtLogout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtLogout.UseVisualStyleBackColor = false;
            this.mtLogout.Click += new System.EventHandler(this.mtLogout_Click);
            // 
            // StorageGridView
            // 
            this.StorageGridView.AllowUserToAddRows = false;
            this.StorageGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StorageGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.StorageGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StorageGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StorageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StorageGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StorageGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.StorageGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StorageGridView.Location = new System.Drawing.Point(117, 62);
            this.StorageGridView.Name = "StorageGridView";
            this.StorageGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StorageGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StorageGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StorageGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.StorageGridView.Size = new System.Drawing.Size(557, 394);
            this.StorageGridView.TabIndex = 8;
            this.StorageGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StorageGridView_CellContentClick);
            this.StorageGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.StorageGridView_MouseDoubleClick);
            // 
            // mtDelete
            // 
            this.mtDelete.Location = new System.Drawing.Point(23, 302);
            this.mtDelete.Name = "mtDelete";
            this.mtDelete.Size = new System.Drawing.Size(88, 74);
            this.mtDelete.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtDelete.TabIndex = 4;
            this.mtDelete.Text = "Delete";
            this.mtDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDelete.Click += new System.EventHandler(this.mtDel_Click);
            // 
            // mtModify
            // 
            this.mtModify.Location = new System.Drawing.Point(23, 222);
            this.mtModify.Name = "mtModify";
            this.mtModify.Size = new System.Drawing.Size(88, 74);
            this.mtModify.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtModify.TabIndex = 5;
            this.mtModify.Text = "Modify";
            this.mtModify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtModify.Click += new System.EventHandler(this.MtModify_Click);
            // 
            // mtRefresh
            // 
            this.mtRefresh.Location = new System.Drawing.Point(23, 62);
            this.mtRefresh.Name = "mtRefresh";
            this.mtRefresh.Size = new System.Drawing.Size(88, 74);
            this.mtRefresh.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtRefresh.TabIndex = 6;
            this.mtRefresh.Text = "Refresh";
            this.mtRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtRefresh.Click += new System.EventHandler(this.mtRefresh_Click);
            // 
            // mtAdd
            // 
            this.mtAdd.Location = new System.Drawing.Point(23, 142);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(88, 74);
            this.mtAdd.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtAdd.TabIndex = 7;
            this.mtAdd.Text = "Add";
            this.mtAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAdd.Click += new System.EventHandler(this.MtAdd_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(689, 467);
            this.Controls.Add(this.mtLogout);
            this.Controls.Add(this.StorageGridView);
            this.Controls.Add(this.mtDelete);
            this.Controls.Add(this.mtModify);
            this.Controls.Add(this.mtRefresh);
            this.Controls.Add(this.mtAdd);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Warehouse";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Warehouse";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.StorageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StorageGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtLogout;
        private System.Windows.Forms.DataGridView StorageGridView;
        private MetroFramework.Controls.MetroTile mtDelete;
        private MetroFramework.Controls.MetroTile mtModify;
        private MetroFramework.Controls.MetroTile mtRefresh;
        private MetroFramework.Controls.MetroTile mtAdd;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}