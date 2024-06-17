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
        protected static CantinaContext db = Program.DbContext;

        public static bool AddExtra(Extra extra)
        {
            if (extra != null)
            {
                db.Extras.Add(extra);
                db.SaveChanges();
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
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                db.Dispose();
                db = new CantinaContext();
                MessageBox.Show("Erro ao atualizar extra");
                return false;
            }
        }

        public static bool DeleteExtra(int id)
        {
            Extra extra = GetExtraById(id);
            if (extra != null)
            {
                db.Extras.Remove(extra);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static List<Extra> ShowAll()
        {
            return db.Extras.ToList();
        }

        public static Extra GetExtraById(int id)
        {
            return db.Extras.Find(id);
        }
    }
}
