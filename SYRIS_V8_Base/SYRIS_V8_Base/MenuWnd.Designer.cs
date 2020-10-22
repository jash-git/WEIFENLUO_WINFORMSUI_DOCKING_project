namespace SYRIS_V8_Base
{
    partial class MenuWnd
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView_Menu = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView_Menu
            // 
            this.treeView_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Menu.Location = new System.Drawing.Point(0, 0);
            this.treeView_Menu.Name = "treeView_Menu";
            this.treeView_Menu.Size = new System.Drawing.Size(284, 262);
            this.treeView_Menu.TabIndex = 0;
            // 
            // MenuWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.treeView_Menu);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "MenuWnd";
            this.Text = "MenuWnd";
            this.Load += new System.EventHandler(this.MenuWnd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_Menu;
    }
}