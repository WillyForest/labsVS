namespace lab_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.brandPage = new System.Windows.Forms.TabPage();
            this.brandDgw = new System.Windows.Forms.DataGridView();
            this.supplierPage = new System.Windows.Forms.TabPage();
            this.supplierDgw = new System.Windows.Forms.DataGridView();
            this.classPage = new System.Windows.Forms.TabPage();
            this.classDgw = new System.Windows.Forms.DataGridView();
            this.toolPage = new System.Windows.Forms.TabPage();
            this.toolDgw = new System.Windows.Forms.DataGridView();
            this.customerPage = new System.Windows.Forms.TabPage();
            this.customerDgw = new System.Windows.Forms.DataGridView();
            this.receiptPage = new System.Windows.Forms.TabPage();
            this.receiptDgw = new System.Windows.Forms.DataGridView();
            this.warrantyPage = new System.Windows.Forms.TabPage();
            this.warrantyDgw = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl.SuspendLayout();
            this.brandPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandDgw)).BeginInit();
            this.supplierPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDgw)).BeginInit();
            this.classPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDgw)).BeginInit();
            this.toolPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolDgw)).BeginInit();
            this.customerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDgw)).BeginInit();
            this.receiptPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDgw)).BeginInit();
            this.warrantyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warrantyDgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.brandPage);
            this.tabControl.Controls.Add(this.supplierPage);
            this.tabControl.Controls.Add(this.classPage);
            this.tabControl.Controls.Add(this.toolPage);
            this.tabControl.Controls.Add(this.customerPage);
            this.tabControl.Controls.Add(this.receiptPage);
            this.tabControl.Controls.Add(this.warrantyPage);
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.Location = new System.Drawing.Point(12, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(676, 355);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // brandPage
            // 
            this.brandPage.Controls.Add(this.brandDgw);
            this.brandPage.Location = new System.Drawing.Point(4, 22);
            this.brandPage.Name = "brandPage";
            this.brandPage.Padding = new System.Windows.Forms.Padding(3);
            this.brandPage.Size = new System.Drawing.Size(668, 329);
            this.brandPage.TabIndex = 1;
            this.brandPage.Text = "Brand";
            this.brandPage.UseVisualStyleBackColor = true;
            // 
            // brandDgw
            // 
            this.brandDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brandDgw.Location = new System.Drawing.Point(4, 4);
            this.brandDgw.Name = "brandDgw";
            this.brandDgw.Size = new System.Drawing.Size(662, 319);
            this.brandDgw.TabIndex = 0;
            // 
            // supplierPage
            // 
            this.supplierPage.Controls.Add(this.supplierDgw);
            this.supplierPage.Location = new System.Drawing.Point(4, 22);
            this.supplierPage.Name = "supplierPage";
            this.supplierPage.Size = new System.Drawing.Size(668, 329);
            this.supplierPage.TabIndex = 2;
            this.supplierPage.Text = "Supplier";
            this.supplierPage.UseVisualStyleBackColor = true;
            // 
            // supplierDgw
            // 
            this.supplierDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDgw.Location = new System.Drawing.Point(4, 4);
            this.supplierDgw.Name = "supplierDgw";
            this.supplierDgw.Size = new System.Drawing.Size(662, 319);
            this.supplierDgw.TabIndex = 0;
            // 
            // classPage
            // 
            this.classPage.Controls.Add(this.classDgw);
            this.classPage.Location = new System.Drawing.Point(4, 22);
            this.classPage.Name = "classPage";
            this.classPage.Padding = new System.Windows.Forms.Padding(3);
            this.classPage.Size = new System.Drawing.Size(668, 329);
            this.classPage.TabIndex = 0;
            this.classPage.Text = "Tool Class";
            this.classPage.UseVisualStyleBackColor = true;
            // 
            // classDgw
            // 
            this.classDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDgw.Location = new System.Drawing.Point(4, 4);
            this.classDgw.Name = "classDgw";
            this.classDgw.Size = new System.Drawing.Size(662, 319);
            this.classDgw.TabIndex = 0;
            // 
            // toolPage
            // 
            this.toolPage.Controls.Add(this.toolDgw);
            this.toolPage.Location = new System.Drawing.Point(4, 22);
            this.toolPage.Name = "toolPage";
            this.toolPage.Size = new System.Drawing.Size(668, 329);
            this.toolPage.TabIndex = 3;
            this.toolPage.Text = "Tool";
            this.toolPage.UseVisualStyleBackColor = true;
            // 
            // toolDgw
            // 
            this.toolDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toolDgw.Location = new System.Drawing.Point(4, 4);
            this.toolDgw.Name = "toolDgw";
            this.toolDgw.Size = new System.Drawing.Size(662, 319);
            this.toolDgw.TabIndex = 0;
            // 
            // customerPage
            // 
            this.customerPage.Controls.Add(this.customerDgw);
            this.customerPage.Location = new System.Drawing.Point(4, 22);
            this.customerPage.Name = "customerPage";
            this.customerPage.Size = new System.Drawing.Size(668, 329);
            this.customerPage.TabIndex = 4;
            this.customerPage.Text = "Customer";
            this.customerPage.UseVisualStyleBackColor = true;
            // 
            // customerDgw
            // 
            this.customerDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDgw.Location = new System.Drawing.Point(4, 4);
            this.customerDgw.Name = "customerDgw";
            this.customerDgw.Size = new System.Drawing.Size(662, 319);
            this.customerDgw.TabIndex = 0;
            // 
            // receiptPage
            // 
            this.receiptPage.Controls.Add(this.receiptDgw);
            this.receiptPage.Location = new System.Drawing.Point(4, 22);
            this.receiptPage.Name = "receiptPage";
            this.receiptPage.Size = new System.Drawing.Size(668, 329);
            this.receiptPage.TabIndex = 5;
            this.receiptPage.Text = "Receipt";
            this.receiptPage.UseVisualStyleBackColor = true;
            // 
            // receiptDgw
            // 
            this.receiptDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptDgw.Location = new System.Drawing.Point(4, 4);
            this.receiptDgw.Name = "receiptDgw";
            this.receiptDgw.Size = new System.Drawing.Size(662, 319);
            this.receiptDgw.TabIndex = 0;
            // 
            // warrantyPage
            // 
            this.warrantyPage.Controls.Add(this.warrantyDgw);
            this.warrantyPage.Location = new System.Drawing.Point(4, 22);
            this.warrantyPage.Name = "warrantyPage";
            this.warrantyPage.Size = new System.Drawing.Size(668, 329);
            this.warrantyPage.TabIndex = 6;
            this.warrantyPage.Text = "Warranty";
            this.warrantyPage.UseVisualStyleBackColor = true;
            // 
            // warrantyDgw
            // 
            this.warrantyDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.warrantyDgw.Location = new System.Drawing.Point(4, 4);
            this.warrantyDgw.Name = "warrantyDgw";
            this.warrantyDgw.Size = new System.Drawing.Size(662, 319);
            this.warrantyDgw.TabIndex = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(701, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 395);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(717, 433);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(717, 433);
            this.Name = "Form1";
            this.Text = "DB Browser";
            this.tabControl.ResumeLayout(false);
            this.brandPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brandDgw)).EndInit();
            this.supplierPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplierDgw)).EndInit();
            this.classPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classDgw)).EndInit();
            this.toolPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolDgw)).EndInit();
            this.customerPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerDgw)).EndInit();
            this.receiptPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receiptDgw)).EndInit();
            this.warrantyPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warrantyDgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage classPage;
        private System.Windows.Forms.TabPage brandPage;
        private System.Windows.Forms.TabPage supplierPage;
        private System.Windows.Forms.TabPage toolPage;
        private System.Windows.Forms.TabPage customerPage;
        private System.Windows.Forms.TabPage receiptPage;
        private System.Windows.Forms.TabPage warrantyPage;
        private System.Windows.Forms.DataGridView brandDgw;
        private System.Windows.Forms.DataGridView supplierDgw;
        private System.Windows.Forms.DataGridView classDgw;
        private System.Windows.Forms.DataGridView toolDgw;
        private System.Windows.Forms.DataGridView customerDgw;
        private System.Windows.Forms.DataGridView receiptDgw;
        private System.Windows.Forms.DataGridView warrantyDgw;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}

