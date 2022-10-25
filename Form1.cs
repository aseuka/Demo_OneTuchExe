using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
    SettingViewMode(); 
        : 기본모드 ( 실행버젼으로 각 프로그램 실행 흐름 뷰 )
    SettingModifyMode();
        : 수정모드 ( 수정버젼으로 해당 파일을 수정할수 있는 뷰 )
    
*/

namespace Demo_OneTuchExe
{
    public partial class Form1 : Form
    {
        List<PGM> PGMS { get; set; } = null;

        public Form1()
        {
            InitializeComponent();
        }

        internal static void Run(bool isShow = false)
        {
            using (Form1 fm = new Form1())
            {
                fm.ReLoad();
                if (isShow)
                { 
                    Application.Run(fm);
                }
                else
                {
                    fm.Execute();
                }
            }
        }

        private void ReLoad()
        {
            // json Load
            PGMS?.Clear();
            PGMS = null;

            string[] cmds = Environment.GetCommandLineArgs();

            string jsexeFilePath = "";

            if (2 <= (cmds?.Length ?? 0))
            { // 첫파라미터는 현재 실행파일 경로.

                jsexeFilePath = cmds[1];
            }

            this.Text = jsexeFilePath;

            //if (string.IsNullOrWhiteSpace(jsexeFilePath))
            //{
            //    jsexeFilePath = @"C:\Users\aseuk\Desktop\onestart.jsexe";
            //}

            if (string.IsNullOrWhiteSpace(jsexeFilePath))
            {
                return;
            }

            string txt = File.ReadAllText(jsexeFilePath);
            if (string.IsNullOrWhiteSpace(txt)) { return; }

            txtLog.Clear();
            txtLog.AppendText(txt);

            PGM PGM = null;
            try
            {
                PGM = JsonConvert.DeserializeObject<PGM>(txt);
                if (PGM != null)
                {
                    PGMS = new List<PGM>() { PGM };
                }
            }
            catch (Exception)
            {
            }

            try
            { 
                if (PGM == null)
                {
                    PGMS = JsonConvert.DeserializeObject<List<PGM>>(txt);
                }
            }
            catch (Exception)
            { 
            }
        }

        private void Execute()
        {
            //실행
            if (PGMS == null) return; 

            foreach (PGM pgm in PGMS)
            {
                if (PGM_Executor.IsRunning(pgm)) continue;

                PGM_Executor.Execute(pgm);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            //string exepgm = @"C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\devenv.exe";
            //string targetfileName = @"D:\Dev\Demo_SoSo\Demo_SoSo.sln";

            //PGM pgm = new PGM();
            //pgm.ExeFileName = @"C:\Windows\System32\notepad.exe";
            //pgm.TargetExeFileName = @"D:\SQL\환산율_역환산율_Q.sql";
            //pgm.Title = "환산율_역환산율_Q.sql-Windows메모장";
            //pgm.RunAs = false;

            //List<PGM> pgms = new List<PGM>();
            //pgms.Add(pgm); 

            //PGM_Executor.SetExecuteTitle(pgm);
            if (PGMS == null) return;

            foreach (PGM pgm in PGMS)
            {
                if (PGM_Executor.IsRunning(pgm)) continue;

                PGM_Executor.Execute(pgm);
            }
            //System.Threading.Thread.Sleep(1000); 
            /*
                 1. 실행 프로그램을 선택 
                 2. 실행 시킬 대상 파일 선택
                 3. 관리자권한 여부 설정
                 4. 프로세스 타이틀< SetTitle >로 title 설정
                 5. 프로세스 실행여부 확인.
                 
                 1~5까지 한 아이템을 목록으로 가지고 있으며, 순서변경.

            >> OneStart 하면... 차례로 실행!
            */
        }

        private void btnExeFileOpen_Click(object sender, EventArgs e)
        {
            //실행 파일 찾기
            lbExeFilePath.Text = "";
            lbTargetFilePath.Text = "";
            chkRunAs.Checked = false;
            lbTitle.Text = "";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    lbExeFilePath.Text = ofd.FileName;
                }
            }
        }

        private void btnTargetFileOpen_Click(object sender, EventArgs e)
        {
            //대상 파일 찾기           
            lbTargetFilePath.Text = "";
            chkRunAs.Checked = false;
            lbTitle.Text = "";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    lbTargetFilePath.Text = ofd.FileName;
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // 테스트
            if (string.IsNullOrWhiteSpace(lbExeFilePath.Text.Trim()))
            {
                MessageBox.Show("실행파일 필수!");
                return;
            }

            //if (string.IsNullOrWhiteSpace(lbTargetFilePath.Text.Trim()))
            //{
            //    MessageBox.Show("대상파일 필수!");
            //    return;
            //}

            PGM testPGM = new PGM()
            {
                ExeFileName = lbExeFilePath.Text.Trim(),
                TargetExeFileName = lbTargetFilePath.Text.Trim(),
                RunAs = chkRunAs.Checked,                
            };

            PGM_Executor.SetExecuteTitle(testPGM);
            lbTitle.Text = testPGM.Title;

            txtLog.Clear();
            List<PGM> pgms = PGMS != null ? new List<PGM>(PGMS?.ToArray()) : new List<PGM>();
            pgms.Add(testPGM);
            txtLog.AppendText(JsonConvert.SerializeObject(pgms, Formatting.Indented));
            //txtLog.AppendText(Environment.NewLine);
            //txtLog.AppendText( !string.IsNullOrWhiteSpace( testPGM?.Title ?? "" ) ? "성공" : "실패");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string reg = $@"Windows Registry Editor Version 5.00

[HKEY_CLASSES_ROOT\SystemFileAssociations\.jsexe\shell\onestarter]
@=""프로그램 목록 실행""

[HKEY_CLASSES_ROOT\SystemFileAssociations\.jsexe\shell\onestarter]
""Icon""=""{Application.StartupPath.Replace("\\", @"\\")}\\gb_list.ico""

[HKEY_CLASSES_ROOT\SystemFileAssociations\.jsexe\shell\onestarter\command]
@=""\""{Application.ExecutablePath.Replace("\\", @"\\")}\"" \""%1\""""";
          
            string regFileName = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            regFileName += "\\jsexe.reg";
            File.WriteAllText(regFileName, reg, Encoding.UTF8);

            MessageBox.Show("바탕화면에 레지스트리 등록파일 생성 완료!");

        }
    }

    public class PGM
    {
        public string ExeFileName { get; set; }

        public string TargetExeFileName { get; set; }

        public string Title { get; set; }

        public bool RunAs { get; set; } = false;
    }

    public class PGM_Executor
    {
        public static bool Execute(PGM pgm)
        {
            bool success = false;

            if (pgm == null || string.IsNullOrWhiteSpace(pgm.ExeFileName) || string.IsNullOrWhiteSpace(pgm.TargetExeFileName) || string.IsNullOrWhiteSpace(pgm.Title)) return success;

            Process pc = new Process();
            pc.StartInfo.FileName = pgm.ExeFileName;
            pc.StartInfo.Arguments = pgm.TargetExeFileName;
            if (pgm.RunAs)
            {
                pc.StartInfo.Verb = "RunAs";
            }

            Dictionary<string, List<string>> ExeProcessList = new Dictionary<string, List<string>>();
            foreach (Process proc in Process.GetProcesses())
            {
                if (!ExeProcessList.ContainsKey(proc.ProcessName))
                {
                    ExeProcessList.Add(proc.ProcessName, new List<string>());
                }
                ExeProcessList[proc.ProcessName].Add(proc.MainWindowTitle.Replace(" ", ""));
            }

            string procName = "";
            pc.Start();
            try
            {
                procName = pc.ProcessName;
                // visual studio를 실행 처음 했을 경우 == 프로세스가 종료되지 않고 유휴상태가 아닌 경우 - 대기 ( 유휴상태가 될때까지.  )
                while (pc.HasExited == false && !pc.WaitForInputIdle(1000))
                {
                    Task.Delay(200);
                    //System.Threading.Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
                // WaitForInputIdle에 실패했습니다. 이 오류는 프로세스에 그래픽 인터페이스가 없는 경우 발생할 수 있습니다.
                // RunAs 일때 발생. 
            }
            System.Threading.Thread.Sleep(1000);// 3초..?

            Dictionary<string, List<string>> newExeProcessList = new Dictionary<string, List<string>>();
            string json = "";
            Process[] procs = (string.IsNullOrWhiteSpace(procName) ? Process.GetProcesses() : Process.GetProcessesByName(procName));
            foreach (Process proc in procs)
            {
                if (!ExeProcessList.ContainsKey(proc.ProcessName))
                {
                    newExeProcessList.Add(proc.ProcessName, new List<string>());

                    while (string.IsNullOrWhiteSpace(proc.MainWindowTitle))
                    {
                        proc.Refresh();
                        System.Threading.Thread.Sleep(100);
                    }

                    if (newExeProcessList[proc.ProcessName].Contains(proc.MainWindowTitle.Replace(" ", "")) == false)
                    {
                        newExeProcessList[proc.ProcessName].Add(proc.MainWindowTitle.Replace(" ", ""));
                    }
                }
                else
                {
                    // devenv 같이 같은 프로세스 이름일때
                    if (!ExeProcessList[proc.ProcessName].Contains(proc.MainWindowTitle.Replace(" ", "")))
                    {
                        if (!newExeProcessList.ContainsKey(proc.ProcessName))
                        {
                            newExeProcessList.Add(proc.ProcessName, new List<string>());
                        }

                        while (string.IsNullOrWhiteSpace(proc.MainWindowTitle))
                        {
                            proc.Refresh();
                            System.Threading.Thread.Sleep(100);
                        }

                        if (newExeProcessList[proc.ProcessName].Contains(proc.MainWindowTitle.Replace(" ", "")) == false)
                        {
                            newExeProcessList[proc.ProcessName].Add(proc.MainWindowTitle.Replace(" ", ""));
                        }
                    }
                }
            }

            foreach (var item in newExeProcessList)
            {
                foreach (string title in item.Value)
                {
                    if (title.Replace(" ", "") == pgm.Title)
                    {
                        success = true;
                        return success;
                    }
                }
            }

            if (newExeProcessList.Count <= 0)
            {
                success = false;
            }
            return success;
        }

        internal static void SetExecuteTitle(PGM pgm)
        {
            string title = "";
            if (pgm == null || string.IsNullOrWhiteSpace(pgm.ExeFileName)) return;

            Dictionary<string, List<string>> ExeProcessList = new Dictionary<string, List<string>>();
            foreach (Process proc in Process.GetProcesses())
            {
                if (!ExeProcessList.ContainsKey(proc.ProcessName))
                {
                    ExeProcessList.Add(proc.ProcessName, new List<string>());
                }
                ExeProcessList[proc.ProcessName].Add(proc.MainWindowTitle.Replace(" ", ""));
            }
            Process pc = new Process();
            pc.StartInfo.FileName = pgm.ExeFileName;
            pc.StartInfo.Arguments = pgm.TargetExeFileName;
            if (pgm.RunAs)
            {
                pc.StartInfo.Verb = "RunAs";
            }
            pc.Start();
            string procName = "";
            try
            {
                procName = "" + pc.ProcessName;
                // visual studio를 실행 처음 했을 경우 == 프로세스가 종료되지 않고 유휴상태가 아닌 경우 - 대기 ( 유휴상태가 될때까지.  )
                while (pc.HasExited == false && !pc.WaitForInputIdle(1000))
                {
                    Task.Delay(200);
                }
            }
            catch (Exception ex)
            {
                // WaitForInputIdle에 실패했습니다. 이 오류는 프로세스에 그래픽 인터페이스가 없는 경우 발생할 수 있습니다.
                // RunAs 일때 발생. 
            }
            System.Threading.Thread.Sleep(1000);// 3초..?

            Dictionary<string, List<string>> newExeProcessList = new Dictionary<string, List<string>>();
            string json = "";

            Process[] procs = (string.IsNullOrWhiteSpace(procName) ? Process.GetProcesses() : Process.GetProcessesByName(procName));
            foreach (Process proc in procs)
            {
                if (!ExeProcessList.ContainsKey(proc.ProcessName))
                {
                    newExeProcessList.Add(proc.ProcessName, new List<string>());

                    while (string.IsNullOrWhiteSpace(proc.MainWindowTitle))
                    {
                        proc.Refresh();
                        System.Threading.Thread.Sleep(100);
                    }

                    if (newExeProcessList[proc.ProcessName].Contains(proc.MainWindowTitle.Replace(" ", "")) == false)
                    {
                        newExeProcessList[proc.ProcessName].Add(proc.MainWindowTitle.Replace(" ", ""));
                    }
                }
                else
                {
                    // devenv 같이 같은 프로세스 이름일때
                    if (!ExeProcessList[proc.ProcessName].Contains(proc.MainWindowTitle.Replace(" ", "")))
                    {
                        if (!newExeProcessList.ContainsKey(proc.ProcessName))
                        {
                            newExeProcessList.Add(proc.ProcessName, new List<string>());
                        }

                        while (string.IsNullOrWhiteSpace(proc.MainWindowTitle))
                        {
                            proc.Refresh();
                            System.Threading.Thread.Sleep(100);
                        }

                        if (newExeProcessList[proc.ProcessName].Contains(proc.MainWindowTitle.Replace(" ", "")) == false)
                        {
                            newExeProcessList[proc.ProcessName].Add(proc.MainWindowTitle.Replace(" ", ""));
                        }
                    }
                }
            }

            if (newExeProcessList.ContainsKey(procName) && 1 == newExeProcessList[procName].Count)
            {
                title = newExeProcessList[procName][0];
                pgm.Title = title.Replace(" ", "");
            }
            else if (newExeProcessList.ContainsKey(procName) && 1 < newExeProcessList[procName].Count)
            {
                // 이름 선택 팝업!
                title = newExeProcessList[procName][0];
                pgm.Title = title.Replace(" ", "");
                // 선택된 것으로 설정. 
            }
        }

        internal static bool IsRunning(PGM pgm)
        {
            bool isRunning = false;
            if (pgm == null || string.IsNullOrWhiteSpace(pgm.ExeFileName) || string.IsNullOrWhiteSpace(pgm.TargetExeFileName) || string.IsNullOrWhiteSpace(pgm.Title)) return isRunning;

            foreach (Process proc in Process.GetProcesses())
            {
                if (proc.MainWindowTitle.Replace(" ", "") == pgm.Title.Trim())
                {
                    isRunning = true;
                    break;
                }
            }
            return isRunning;
        }

    }
}
