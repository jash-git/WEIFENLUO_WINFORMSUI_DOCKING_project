using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WeifenLuo.WinFormsUI.Docking;
/*
Dock_Step01.引用WeifenLuo.WinFormsUI.Docking.dll
Dock_Step02.设置主窗体Mainwnd的IsMdiContainer属性为true
Dock_Step03.添加dockPanel控件到工具箱中：工具箱—>右键—>选择项—>.net组件—>浏览—>weiFenLuo.winFormsUI.Docking.dll，此时在工具箱将出现dockPanel，将dockPanel拖放到Mainwnd中，设置dockpanel的相关属性：dockPanel.Dock=Fill
Dock_Step04.開啟MainWnd.Designer.cs加入對應程式碼
Dock_Step05.修改MainWnd.cs新增 _dockpanelConfigFile和m_Menu變數
Dock_Step06.顯示m_Menu
Dock_Step07.撰寫觸發儲存Dock UI參數
*/
namespace SYRIS_V8_Base
{
    public partial class MainWnd : Form
    {
        //Dock_Step05_start
        private static string _dockpanelConfigFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockManager.config");
        private MenuWnd m_Menu;
        //Dock_Step05_end
        static public MainWnd m_MW;

        public IDockContent GetDeserializeDockContent(string persistString)
        {
            if (persistString == typeof(MenuWnd).ToString())
                return m_Menu;
            /*
            if (persistString == typeof(Form2).ToString())
                return _form2;
            */
            return null;
        } 
        public MainWnd()
        {
            InitializeComponent();
            m_MW = this;
        }

        private void MainWnd_Load(object sender, EventArgs e)
        {
            //Dock_Step06_start
            try
            {
                if (File.Exists(_dockpanelConfigFile))
                    m_dockPanel.LoadFromXml(_dockpanelConfigFile, new DeserializeDockContent(GetDeserializeDockContent));
            }
            catch (Exception)
            {
            }
            m_Menu = new MenuWnd();
            m_Menu.SetMainWnd(this);
            m_Menu.Show(m_dockPanel, DockState.DockLeft);
            //Dock_Step06_end
        }

        private void MainWnd_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_dockPanel.SaveAsXml(_dockpanelConfigFile);//Dock_Step07
        }
    }
}
