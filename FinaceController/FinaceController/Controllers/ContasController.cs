using Modelos;
using Modelos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FinaceController.Controllers
{
    public class ContasController : Controller
    {
        // GET: Conta
        public ActionResult Index()
        {
            MeuContexto contexto = new MeuContexto();
            List<Conta> contas = contexto.Contas.ToList();

            return View(contas);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
         public ActionResult Create(Conta conta)
         {
             if(ModelState.IsValid)
             {
                 MeuContexto contexto = new MeuContexto();
                 contexto.Contas.Add(conta);
                 contexto.SaveChanges();
                 return RedirectToAction("Index");
             }
 
             return View(conta);
         }

        //GET
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MeuContexto contexto = new MeuContexto();

            Conta con = contexto.Contas.Find(id);

            if (con == null)
            {
                return HttpNotFound();
            }

            return View(con);
        }

        //GET
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MeuContexto contexto = new MeuContexto();

            Conta con = contexto.Contas.Find(id);

            if (con == null)
            {
                return HttpNotFound();
            }

            return View(con);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Conta con)
        {
            if (ModelState.IsValid)
            {
                MeuContexto contexto = new MeuContexto();

                contexto.Entry(con).State =
                    System.Data.Entity.EntityState.Modified;

                contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(con);
        }

        //GET
         public ActionResult Delete(int? id)
         {
             if (id == null)
             {
                 return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
             }
 
             MeuContexto contexto = new MeuContexto();

            Conta con = contexto.Contas.Find(id);
 
             if (con == null)
             {
                 return HttpNotFound();
             }
 
             return View(con);
         }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MeuContexto contexto = new MeuContexto();
            Conta con = contexto.Contas.Find(id);

            contexto.Contas.Remove(con);
            contexto.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}