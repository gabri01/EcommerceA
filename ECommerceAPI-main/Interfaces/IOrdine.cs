using System;
using Models;

namespace Interfaces
{
	public interface IOrdine
	{
        //GetAllOrdini
        public List<OrdiniUtente> GetOrdini(string Email);
        bool InsertOrdine(NuovoOrdine ordine, string Email);
        public int DeleteOrderByUser(int idOrdine, string email, string password);
        public int UpdateOrder(int idOrdine, int idStato);
        public int DeleteOrder(int idOrdine, string Email);
    }
}

