using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Interfaces;
using System.Security.Claims;

namespace BusinessLogic
{
    public class BusinessClass : IBusiness
    {
        IDAL dal;
        public BusinessClass(IDAL dal)
        {
            this.dal = dal;
        }

        public bool VerificaUtenteEsistente(string Email)
        {
            return dal.VerificaUtenteEsistente(Email);
        }
        public long Registrazione(Registrazione NuovoUtente)
        {
            return dal.Registrazione(NuovoUtente);
        }
        //public bool AutenticazioneUtente(Utente Utente)
        //{
        //    return dal.AutenticazioneUtente(Utente);
        //}
        public string Login(Login Utente)
        {
            return dal.Login(Utente);
        }
        public bool EsisteUtente(Login Utente)
        {
            return dal.EsisteUtente(Utente);
        }
        public bool ModificaUtente(int ID, string Nome, string Cognome, string Email)
        {
            return dal.ModificaUtente(ID, Nome, Cognome, Email);
        }
        public List<Prodotto> GetAllProdotti()
        {
            return dal.GetAllProdotti();
        }
        public List<OrdiniUtente> GetOrdini(string Email)
        {
            return dal.GetOrdini(Email);
        }
        public bool InsertOrdine(NuovoOrdine Ordine, string Email)
        {
            return dal.InsertOrdine(Ordine, Email);
        }
        public long InsertProdotto(Prodotto prodotto)
        {
            return dal.InsertProdotto(prodotto);
        }
        public List<Corriere> GetAllCorrieri()
        {
            return dal.GetAllCorrieri();
        }
        public List<Pagamento> GetAllPagamenti()
        {
            return dal.GetAllPagamenti();
        }
        public List<Categoria> GetAllCategorie()
        {
            return dal.GetAllCategorie();
        }
        public Utente GetUtenteByID(string Email)
        {
            return dal.GetUtenteByID(Email);
        }
        public int DeleteOrder(int idOrdine, string Email) 
        {
            return dal.DeleteOrder(idOrdine, Email);
        } 

        //GABRIELE
        public int DeleteOrderByUser(int idOrdine, string email, string password)
        {
            return dal.DeleteOrderByUser(idOrdine, email, password);
        }
        public int UpdateProduct(Prodotto prodotto)
        {
            return dal.UpdateProduct(prodotto);
        }
        public int DeleteProduct(int idProdotto)
        {
            return dal.DeleteProduct(idProdotto);
        }
        public int UpdateOrder(int idOrdine, int idStato)
        {
            return dal.UpdateOrder(idOrdine, idStato);
        }
        public List<Prodotto> SearchProductsByName(string nomeProdotto)
        {
            return dal.SearchProductsByName(nomeProdotto);
        }
        public List<Prodotto> SearchProductByCategory(string nomeCategoria)
        {
            return dal.SearchProductByCategory(nomeCategoria);
        }
    }
}
