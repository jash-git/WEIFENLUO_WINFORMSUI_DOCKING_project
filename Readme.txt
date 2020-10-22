Microsoft Visual C# 2010 Express 使用『WeifenLuo.WinFormsUI.Docking.dll』實現畫面(Dock)分割視窗步驟

Dock_Step01.引用WeifenLuo.WinFormsUI.Docking.dll

 

Dock_Step02.设置主窗体Mainwnd的IsMdiContainer属性为true

 

Dock_Step03.添加dockPanel控件到工具箱中：工具箱—>右键—>选择项—>.net组件—>浏览—>weiFenLuo.winFormsUI.Docking.dll，此时在工具箱将出现dockPanel，将dockPanel拖放到Mainwnd中，设置dockpanel的相关属性：dockPanel.Dock=Fill

 

Dock_Step04.開啟MainWnd.Designer.cs加入對應程式碼

 

Dock_Step05.修改MainWnd.cs新增 _dockpanelConfigFile和m_Menu變數

 

Dock_Step06.顯示m_Menu

 

Dock_Step07.撰寫觸發儲存Dock UI參數


PS 壓縮檔密碼:asd......