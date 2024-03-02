using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Iris
{

    class PositionAccess
    {
        // メソッド名:GetPostitionData()
        // 引　数　　:なし
        // 戻り値　　:役職データ
        // 機能　　　:役職データの取得
        public List<M_PositionCombo> GetPostitionCombo()
        {
            List<M_PositionCombo> exist = new List<M_PositionCombo>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_Positions
                            where (t1.PoFlag == 0)
                            select new {
                                t1.PoID,
                                t1.PoName
                            };
                foreach(var p in table)
                {
                    exist.Add(new M_PositionCombo()
                    {
                        Display = p.PoID + " " + p.PoName,
                        Value = p.PoID.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "役職DBエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exist;
        }
        // メソッド名:GetPostitionDisplay()
        // 引　数　　:なし
        // 戻り値　　:役職(表示)データ
        // 機能　　　:役職表示データの取得
        public List<M_PositionDsp> GetPostitionDisplay()
        {
            List<M_PositionDsp> positionDsp = new List<M_PositionDsp>();
            try
            {
                var context = new SalesManagement_DevContext();
                var table = from t1 in context.M_Positions
                            select new
                            {
                                t1.PoID,
                                t1.PoName
                            };
                foreach(var p in table)
                {
                    positionDsp.Add(new M_PositionDsp() { PoID = p.PoID, PoName = p.PoName });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "役職表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return positionDsp;
        }

        public bool AddPosition(M_Position AddThis)
        {
            try
            {
                SalesManagement_DevContext context = new SalesManagement_DevContext();
                context.M_Positions.Add(AddThis);
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "役職登録エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool ModifyPosition(M_Position ModifyThis)
        {
            try
            {
                using (SalesManagement_DevContext context = new SalesManagement_DevContext())
                {
                    var Modify = context.M_Positions.Single(x => x.PoID == ModifyThis.PoID);
                    Modify.PoName = ModifyThis.PoName;
                    Modify.Positions = ModifyThis.Positions;
                    context.SaveChanges();
                };
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "役職変更エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public List<M_PositionDsp> Search(string Keyword, int type,int Pos, string Lvl)
        {
            List<M_PositionDsp> Position = new List<M_PositionDsp>();
            try
            {
                SalesManagement_DevContext context = new SalesManagement_DevContext();
                var table = from t1 in context.M_Positions
                            select new
                            {
                                t1.PoID,
                                t1.PoName,
                                t1.Positions
                            };
                var a = table.AsEnumerable();
                if (Pos >= 0)
                { a = table.AsEnumerable().Where(x => x.Positions.Split(',')[Pos] == Lvl); }
                switch (type)
                {
                    case 0:a = a.Where(x => x.PoID.ToString().Contains(Keyword) || x.PoName.Contains(Keyword));
                            break;
                    case 1:a = a.Where(x => x.PoID.ToString().Contains(Keyword));
                        break;
                    case 2:a = a.Where(x => x.PoName.Contains(Keyword));
                        break;
                }
                foreach (var p in a)
                {
                    Position.Add(new M_PositionDsp() { PoID = p.PoID, PoName = p.PoName });
                }
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "役職検索エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return Position;
        }
    }
}
