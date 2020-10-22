using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYRIS_V8_Base
{
    public partial class MenuWnd : WeifenLuo.WinFormsUI.Docking.DockContent//step01
    {
        public MainWnd m_MainWnd;//step02
        public MenuWnd()
        {
            InitializeComponent();
        }
        public void SetMainWnd(MainWnd MainWnd)//step03
        {
            m_MainWnd = MainWnd;
        }

        private void MenuWnd_Load(object sender, EventArgs e)
        {
            //step04_start
            CloseButton = false;//禁止選單被關閉 http://m.blog.csdn.net/article/details?id=7681430
            this.CloseButtonVisible = false;//隱藏關閉按鈕 http://m.blog.csdn.net/article/details?id=7681430
            //step04_end
        }
    }
}
