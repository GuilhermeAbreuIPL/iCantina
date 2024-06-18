using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Controllers
{
    internal class ExtraController
    {
        

        public static bool AddExtra(Extra extra)
        {
            if (extra != null)
            {
                Program.db.Extras.Add(extra);
                Program.db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateExtra(int id, string descricao, decimal preco, bool state)
        {
            try
            {
                Extra extra = GetExtraById(id);
                extra.Descricao = descricao;
                extra.Preco = preco;
                extra.Ativo = state;
                Program.db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                Program.db.Dispose();
                Program.db = new CantinaContext();
                MessageBox.Show("Erro ao atualizar extra");
                return false;
            }
        }

        public static bool DeleteExtra(int id)
        {
            Extra extra = GetExtraById(id);
            if (extra != null)
            {
                Program.db.Extras.Remove(extra);
                Program.db.SaveChanges();
                return true;
            }
            return false;
        }

        public static List<Extra> ShowAll()
        {
            return Program.db.Extras.ToList();
        }

        public static Extra GetExtraById(int id)
        {
            return Program.db.Extras.Find(id);
        }

        public static List<Extra> GetExtrasByState(bool state)
        {
            return Program.db.Extras.Where(e => e.Ativo == state).ToList();
        }
    }
}
