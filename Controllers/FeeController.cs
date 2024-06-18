using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Controllers
{
    internal class FeeController
    {

        public static bool AddFee(Fee fee)
        {
            if (fee != null)
            {
                Program.db.Fees.Add(fee);
                Program.db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateFee(int id, decimal valor, decimal numHoras)
        {
            try
            {
                Fee fee = GetFeeById(id);
                fee.valor = valor;
                fee.numHoras = numHoras;
                Program.db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                Program.db.Dispose();
                Program.db = new CantinaContext();
                MessageBox.Show("Erro ao atualizar multa");
                return false;
            }
        }

        public static bool DeleteFee(int id)
        {
            Fee fee = GetFeeById(id);
            if (fee != null)
            {
                Program.db.Fees.Remove(fee);
                Program.db.SaveChanges();
                return true;
            }
            return false;
        }

        public static Fee GetFeeById(int id)
        {
            return Program.db.Fees.Find(id);
        }

        public static List<Fee> ShowAll()
        {
            return Program.db.Fees.ToList();
        }
    }
}
