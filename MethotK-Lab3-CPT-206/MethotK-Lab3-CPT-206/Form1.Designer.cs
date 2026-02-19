namespace MethotK_Lab3_CPT_206
{
    partial class Form1
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
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFullDatabase = new System.Windows.Forms.Button();
            this._Lab_3_Database_AccessDataSet = new MethotK_Lab3_CPT_206._Lab_3_Database_AccessDataSet();
            this.state_DatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.state_DatabaseTableAdapter = new MethotK_Lab3_CPT_206._Lab_3_Database_AccessDataSetTableAdapters.State_DatabaseTableAdapter();
            this.tableAdapterManager = new MethotK_Lab3_CPT_206._Lab_3_Database_AccessDataSetTableAdapters.TableAdapterManager();
            this.toolTipState = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._Lab_3_Database_AccessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.state_DatabaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxState
            // 
            this.comboBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(106, 47);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(414, 37);
            this.comboBoxState.TabIndex = 1;
            // 
            // btnDetails
            // 
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Location = new System.Drawing.Point(106, 175);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(129, 90);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "View &Details";
            this.toolTipState.SetToolTip(this.btnDetails, "View selected State Details");
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(401, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 90);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.toolTipState.SetToolTip(this.btnExit, "Exit");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFullDatabase
            // 
            this.btnFullDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullDatabase.Location = new System.Drawing.Point(241, 175);
            this.btnFullDatabase.Name = "btnFullDatabase";
            this.btnFullDatabase.Size = new System.Drawing.Size(154, 90);
            this.btnFullDatabase.TabIndex = 4;
            this.btnFullDatabase.Text = "View &Full Database";
            this.toolTipState.SetToolTip(this.btnFullDatabase, "View Full Database");
            this.btnFullDatabase.UseVisualStyleBackColor = true;
            this.btnFullDatabase.Click += new System.EventHandler(this.btnFullDatabase_Click);
            // 
            // _Lab_3_Database_AccessDataSet
            // 
            this._Lab_3_Database_AccessDataSet.DataSetName = "_Lab_3_Database_AccessDataSet";
            this._Lab_3_Database_AccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // state_DatabaseBindingSource
            // 
            this.state_DatabaseBindingSource.DataMember = "State Database";
            this.state_DatabaseBindingSource.DataSource = this._Lab_3_Database_AccessDataSet;
            // 
            // state_DatabaseTableAdapter
            // 
            this.state_DatabaseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.State_DatabaseTableAdapter = this.state_DatabaseTableAdapter;
            this.tableAdapterManager.UpdateOrder = MethotK_Lab3_CPT_206._Lab_3_Database_AccessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnFullDatabase;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(630, 295);
            this.Controls.Add(this.btnFullDatabase);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.comboBoxState);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kyle Methot Lab 3 State Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Lab_3_Database_AccessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.state_DatabaseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _Lab_3_Database_AccessDataSet _Lab_3_Database_AccessDataSet;
        private System.Windows.Forms.BindingSource state_DatabaseBindingSource;
        private _Lab_3_Database_AccessDataSetTableAdapters.State_DatabaseTableAdapter state_DatabaseTableAdapter;
        private _Lab_3_Database_AccessDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFullDatabase;
        private System.Windows.Forms.ToolTip toolTipState;
    }
}

