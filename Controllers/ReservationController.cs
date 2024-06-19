using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Controllers
{
    internal class ReservationController
    {
        public static bool AddReservation(Reservation reservation)
        {
            try
            {
                Program.db.Reservations.Add(reservation);
                Program.db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                Program.db.Dispose();
                Program.db = new CantinaContext();
                return false;
            }

            return false;
        }
    }
}
