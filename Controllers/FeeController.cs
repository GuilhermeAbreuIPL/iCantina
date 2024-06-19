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

        
        public static DateTime ObterHoraAtual()
        {
            return DateTime.Now;
        }

        
        public static TimeSpan CalcularTempoRestante(int horaReserva)
        {
            DateTime horaAtual = ObterHoraAtual();
            DateTime horaReservaDateTime = new DateTime(horaAtual.Year, horaAtual.Month, horaAtual.Day, horaReserva, 0, 0);

            if (horaReservaDateTime < horaAtual)
            {
                horaReservaDateTime = horaReservaDateTime.AddDays(1); // Adiciona um dia se a hora da reserva já passou hoje
            }

            TimeSpan tempoRestante = horaReservaDateTime - horaAtual;
            return tempoRestante;
        } 

        public static Fee ProcurarMulta(TimeSpan tempoRestante)
        {
            
            List<Fee> multas = Program.db.Fees.ToList();
            List<Fee> multasOrdenadas = multas.OrderBy(m => m.numHoras).ToList();
            if(multas == null)
            {
                //Return null pois não existem multas
                return null;
            }
            else
            {
                //Check se existe alguma multa que se aplique ao tempo restante de forma a devolver a multa correta
                foreach (Fee multa in multasOrdenadas)
                {
                    if (tempoRestante.TotalHours <= Double.Parse(multa.numHoras.ToString()))
                    {
                        return multa;
                    }
                }
            }
            return null;
        }

        //Criar uma função onde não seja premitido criar multas a mesma hora
        public static bool VerificarMultaExistente(decimal hora)
        {
            List<Fee> multas = Program.db.Fees.ToList();
            foreach (Fee multa in multas)
            {
                if (multa.numHoras == hora)
                {
                    return true;
                }
            }
            return false;
        }

        public static List<Fee> ShowAll()
        {
            return Program.db.Fees.ToList();
        }
    }
}
