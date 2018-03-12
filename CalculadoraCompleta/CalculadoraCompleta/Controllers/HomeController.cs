using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculadoraCompleta.Controllers {
   public class HomeController : Controller {
      // GET: Home
      public ActionResult Index() {

         // incializa variaáveis
         ViewBag.Visor = "0";

         return View();
      }

      // POST: Home
      [HttpPost]
      public ActionResult Index(string bt, string visor) {

         // avalia o botão selecionado
         switch(bt) {
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "0":
               // se ainda não se começou a escrever o nº, ou ele começa por
               // zero, atribui o 'visor' o nº
               if(visor.Equals("0")) visor = bt;
               // caso contrário, acrescenta-o
               else visor += bt;
               break;
            case ",":
               if(!visor.Contains(",")) visor += ",";
               break;
            case "+/-":
               visor = (Convert.ToDouble(visor) * -1) + "";
               break;

         }

         // devolve valor à View
         ViewBag.Visor = visor;

         return View();
      }
   }
}