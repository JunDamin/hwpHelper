using System.IO;

namespace hwpHelper
{
    partial class mainForm
    {
        public struct Action
        {
            public Action(HWPCONTROLLib.DHwpAction action, HWPCONTROLLib.DHwpParameterSet param)
            {  
                Act = action;
                Set = param;
            }

            public HWPCONTROLLib.DHwpAction Act { get; }
            public HWPCONTROLLib.DHwpParameterSet Set { get; }
        }
        private void SetupToolbar()
        { 
            axHwpCtrl1.SetToolBar(-1, "#0;1:TOOLBAR_MENU");
            axHwpCtrl1.SetToolBar(-1, "#1;1:TOOLBAR_STANDARD");
            axHwpCtrl1.SetToolBar(-1, "#1;2:TOOLBAR_FORMAT");
//            axHwpCtrl1.SetToolBar(-1, "#1;3:TOOLBAR_DRAW");
            axHwpCtrl1.SetToolBar(-1, "#1;4:TOOLBAR_TABLE");
//            axHwpCtrl1.SetToolBar(-1, "#1;5:TOOLBAR_IMAGE");
            axHwpCtrl1.SetToolBar(-1, "#6;1:TOOLBAR_NUMBERBULLET"); // 5
//            axHwpCtrl1.SetToolBar(-1, "#7;1:TOOLBAR_HEADER_FOOTER"); // 6
//            axHwpCtrl1.SetToolBar(-1, "#8;1:TOOLBAR_MASTERPAGE");     // 7
//            axHwpCtrl.SetToolBar(-1, "#9;1:TOOLBAR_NOTE");         // 8
//            axHwpCtrl.SetToolBar(-1, "#10;1:TOOLBAR_COMMENT");     // 9
//            axHwpCtrl.SetToolBar(11, "#11;1:새 도구상자, FileNew, FileSave, FileSaveAs, FileOpen");
            axHwpCtrl1.ShowToolBar(1);
        }
        public HWPCONTROLLib.DHwpAction CreateAction(string action)
        {
            HWPCONTROLLib.DHwpAction act = (HWPCONTROLLib.DHwpAction)axHwpCtrl1.CreateAction(action);
            return act;
        }
        public HWPCONTROLLib.DHwpParameterSet CreateSet(string action)
        {
            HWPCONTROLLib.DHwpParameterSet set = (HWPCONTROLLib.DHwpParameterSet)axHwpCtrl1.CreateSet(action);
            return set;
        }

        private Action GetActionSet(string action)
        {
            HWPCONTROLLib.DHwpAction act = CreateAction(action);
            HWPCONTROLLib.DHwpParameterSet set = CreateSet(action);
            act.GetDefault(set);
            var actionSet = new Action(act, set);
            return actionSet;
        }

        private void InsertFile(string path)
        {
            var actionSet = GetActionSet("InsertFile");
            var fpath = Path.GetFullPath(path);
            actionSet.Set.SetItem("FileName", fpath);
            actionSet.Act.Execute(actionSet.Set);
        }
    }
}