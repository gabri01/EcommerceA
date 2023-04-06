using Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ECommerceAP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdineController : ControllerBase
    {
        IBusiness business;

        public OrdineController(IBusiness business)
        {
            this.business = business;
        }

        [HttpGet("GetOrdine")]
        [Authorize]
        public IActionResult Get()
        {
            var IdUtenteEmailClaim = User.Claims.FirstOrDefault(e => e.Type.Equals("Email",
                StringComparison.InvariantCultureIgnoreCase));

            return Ok(business.GetOrdini(IdUtenteEmailClaim.Value));
        }

        //Per Amministratore
        [HttpDelete("DeleteOrderByUser")]
        public IActionResult Delete(int idOrdine, string email, string password)
        {
            var IdUtenteEmailClaim = User.Claims.FirstOrDefault(e => e.Type.Equals("Email",
               StringComparison.InvariantCultureIgnoreCase));
            try
            {
                var result = business.DeleteOrderByUser(idOrdine, email, password);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Per utente
        [HttpDelete("DeleteOrder")]
        [Authorize]
        public IActionResult Delete(int idOrdine)
        {
            var IdUtenteEmailClaim = User.Claims.FirstOrDefault(e => e.Type.Equals("Email",
             StringComparison.InvariantCultureIgnoreCase));

            try
            {
                var result = business.DeleteOrder(idOrdine, IdUtenteEmailClaim.Value);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateOrder")]
        [Authorize]
        public IActionResult Update(int idOrdine, int idStato)
        {
            try
            {
                var result = business.UpdateOrder(idOrdine, idStato);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("NewOrdine")]
        [Authorize]
        public IActionResult Insert(NuovoOrdine Ordine)
        {
            var IdUtenteEmailClaim = User.Claims.FirstOrDefault(e => e.Type.Equals("Email",
              StringComparison.InvariantCultureIgnoreCase));

            //if (business.AutenticazioneUtente(Utente))
            //    return BadRequest(new { message = "Utente non registrato." });
            if (business.InsertOrdine(Ordine, IdUtenteEmailClaim.Value))
                return Ok("Oridine effettuato.");
            return BadRequest(new { message = "Ordine non effettuato!" });
        }
    }
}