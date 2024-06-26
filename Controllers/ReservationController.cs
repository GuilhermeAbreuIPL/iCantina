﻿using iCantina.Models;
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

        
        public static List<Reservation> GetReservationsByDate(DateTime date)
        {
            //Função utilizada para mostar as reservas de um determinado dia porem não coloca na lista as reservas que já foram consumidas
            List<Reservation> querry = Program.db.Reservations.Where(r => r.Menu.DataHora.Year == date.Year && r.Menu.DataHora.Month == date.Month && r.Menu.DataHora.Day == date.Day && r.Consumido == false).ToList();

            return querry;
        }

        //Funcao para consumir reserva

        public static bool ConsumirReserva(int id)
        {
            try
            {
                // procura a reserva pelo id
                Reservation reservation = Program.db.Reservations.Find(id);
                reservation.Consumido = true;
                Program.db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                Program.db.Dispose();
                Program.db = new CantinaContext();
                return false;
            }
        }




    }
    
}
