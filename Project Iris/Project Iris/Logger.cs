using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Iris
{
    class Logger
    {
        public static bool WriteLogOp(DateTime Time,string Who, string Where,int Op, string DoBefore, string DoAfter)
        {
            try
            {
                FileStream File = new FileStream(string.Format("{0}\\{1}", Path.GetTempPath(), "Project_Iris"), FileMode.Append, FileAccess.Write);
                StreamWriter Writer = new StreamWriter((Stream)File);
                string Compile = "Blank Log Op";
                switch(Op)
                {
                    case 0: Compile = "[ " + Time.ToString("yyyy年MM月dd日 HH時mm分ss秒") + " ]   " + Who + " が " + Where + " で " + DoAfter + " を登録";
                        break;
                    case 1: Compile = "[ " + Time.ToString("yyyy年MM月dd日 HH時mm分ss秒") + " ]   " + Who + " が " + Where + " で " + DoBefore + " を " + DoAfter + " に更新";
                        break;

                }
                Writer.WriteLine(Compile);
                Writer.Close();
                File.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("ログファイルの書き込み中にエラーが発生しました。\n" + ex, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool WriteLogEnter(DateTime Time,string Who, string Where, string Position)
        {
            try
            {
                FileStream File = new FileStream(string.Format("{0}\\{1}", Path.GetTempPath(), "Project_Iris"), FileMode.Append, FileAccess.Write);
                StreamWriter Writer = new StreamWriter((Stream)File);
                string Compile = "[ " + Time.ToString("yyyy年MM月dd日 HH時mm分ss秒") + " ]   " + Who + " が " + Where + "にアクセス。権限 [ " + Position + " ]";
                Writer.WriteLine(Compile);
                Writer.Close();
                File.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ログファイルの書き込み中にエラーが発生しました。\n" + ex, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool WriteLogLeave(DateTime Time, string Who, string WhereWhat)
        {
            try
            {
                FileStream File = new FileStream(string.Format("{0}\\{1}", Path.GetTempPath(), "Project_Iris"), FileMode.Append, FileAccess.Write);
                StreamWriter Writer = new StreamWriter((Stream)File);
                string Compile = "[ " + Time.ToString("yyyy年MM月dd日 HH時mm分ss秒") + " ]   " + Who + " が " + WhereWhat;
                Writer.WriteLine(Compile);
                Writer.Close();
                File.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ログファイルの書き込み中にエラーが発生しました。\n" + ex, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
