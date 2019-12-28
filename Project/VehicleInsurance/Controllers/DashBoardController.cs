using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace VehicleInsurance.Controllers
{

    public class DashBoardController : Controller
    {
        Database1Entities db = new Database1Entities();
        // GET: DashBoard
        public ActionResult Index()
        {
            return View();
        }

       
        //CLAIM DETAILS
        public ActionResult claimlist()
        {
            return View();
        }

        public ActionResult claimcreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult claimcreate(claim_details c)
        {
            db.claim_details.Add(c);
            db.SaveChanges();
            return RedirectToAction("claimlist");
        }

        public ActionResult claimedit(int? id)
        {
            claim_details x = db.claim_details.Find(id);
            if (id == null)
                return HttpNotFound();
            else
                return View();
        }
        [HttpPost]
        public ActionResult claimedit(claim_details c)
        {
            db.Entry(c).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("claimlist");
        }

        public ActionResult claimdelete(int? id)
        {
            claim_details cl = db.claim_details.Find(id);
            if (cl == null)
                return HttpNotFound();
            else
                return View();
        }
        [HttpPost]
        public ActionResult claimdelete(claim_details c)
        {
            claim_details x = db.claim_details.Find(c.cus_name);
            db.claim_details.Remove(x);
            db.SaveChanges();
            return View();
        }

        //COMP EXPENSES
        public ActionResult expensesList()
        {
            return View();
        }

        public ActionResult expensescreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult expensescreate(comp_exp e)
        {
            db.comp_exp.Add(e);
            db.SaveChanges();
            return RedirectToAction("expensesList");
        }

        public ActionResult expensesedit(int? id)
        {
            comp_exp x = db.comp_exp.Find(id);
            if (id == null)
                return HttpNotFound();
            else
                return View();
        }
        [HttpPost]
        public ActionResult expensesedit(comp_exp e)
        {
            db.Entry(e).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("expensesList");
        }

        public ActionResult expensesdelete(int? id)
        {
            comp_exp c = db.comp_exp.Find(id);
            if (c == null)
                return HttpNotFound();
            else
                return View();
        }
        [HttpPost]
        public ActionResult expensesdelete(comp_exp e)
        {
            comp_exp x = db.comp_exp.Find(e.amount_of_exp);
            db.comp_exp.Remove(x);
            db.SaveChanges();
            return View();
        }


        //CUS BILL INFO
        public ActionResult BILLlist()
        {
            return View();
        }

        public ActionResult BILLcreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BILLcreate(cus_bill_info b)
        {
            db.cus_bill_info.Add(b);
            db.SaveChanges();
            return RedirectToAction("BILLlist");
            
        }

        public ActionResult BILLedit(int? id)
        {
            CUSTOMER x = db.CUSTOMERs.Find(id);
            if (id == null)
                return HttpNotFound();
            else
                return View();
        }
        [HttpPost]
        public ActionResult BILLedit(cus_bill_info b)
        {
            db.Entry(b).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("BILLlist");
        }

        public ActionResult BILLdelete(int? id)
        {
            cus_bill_info c = db.cus_bill_info.Find(id);
            if (c == null)
                return HttpNotFound();
            else
                return View();
        }
        [HttpPost]
        public ActionResult BILLdelete(cus_bill_info b)
        {
            cus_bill_info x = db.cus_bill_info.Find(b.cus_name);
            db.cus_bill_info.Remove(x);
            db.SaveChanges();
            return View();
        }



        //CUSTOMER
        public ActionResult Customerlist()
        {
            return View();
        }
        
        public ActionResult Customercreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Customercreate(CUSTOMER u)
        {
            db.CUSTOMERs.Add(u);
            db.SaveChanges();
            return RedirectToAction("Customerlist");
        }
        
        public ActionResult Customeredit(int? id)
        {
            CUSTOMER x = db.CUSTOMERs.Find(id);
            if (id == null)
                return HttpNotFound();
            else
                return View();
        }
        [HttpPost]
        public ActionResult Customeredit(CUSTOMER u)
        {
            db.Entry(u).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Customerlist");
        }
       
        public ActionResult Customerdelete(int? id)
        {
            CUSTOMER cu = db.CUSTOMERs.Find(id);
            if(cu==null)
                    return HttpNotFound();
                else
                    return View();
        }
        [HttpPost]
        public ActionResult Customerdelete(CUSTOMER u)
        {
           CUSTOMER x=db.CUSTOMERs.Find(u.cus_Id);
            db.CUSTOMERs.Remove(x);
            db.SaveChanges();
            return View();
        }
       


        //ESTIMATE
        public ActionResult estimatelist()
        {
            return View();
        }

        public ActionResult estimatecreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult estimatecreate(estimate s)
        {
            db.estimates.Add(s);
            db.SaveChanges();
            return RedirectToAction("estimatelist");
        }

        public ActionResult estimateEdit(int? id)
        {
            estimate x = db.estimates.Find(id);
            if (id == null)
                return HttpNotFound();
            else
                return View();
        }
        [HttpPost]
        public ActionResult estimateEdit(estimate s)
        {
            db.Entry(s).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("expensesList");
        }

        public ActionResult estimatedelete(int? id)
        {
            estimate es = db.estimates.Find(id);
            if (es == null)
                return HttpNotFound();
            else
                return View();
        }
        [HttpPost]
        public ActionResult estimatedelete(estimate s)
        {
           estimate x=db.estimates.Find(s.cus_id);
            db.estimates.Remove(x);
            db.SaveChanges();
            return View();
        }


        // Vehicle INFO 
        public ActionResult vehlist()
        {
            return View();
        }

        public ActionResult vehcreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult vehcreate(Vehicle_info v)
        {
            db.Vehicle_info.Add(v);
            db.SaveChanges();
            return RedirectToAction("vehlist");
        }

        public ActionResult vehedit(int? id)
        {
            Vehicle_info x = db.Vehicle_info.Find(id);
            if (id == null)
                return HttpNotFound();
            else
                return View();
        }
        [HttpPost]
        public ActionResult vehedit(Vehicle_info v)
        {
            db.Entry(v).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("vehlist");
        }
        public ActionResult vehdelete(int? id)
        {
            Vehicle_info es = db.Vehicle_info.Find(id);
            if (es == null)
                return HttpNotFound();
            else
                return View();
        }
        [HttpPost]
        public ActionResult vehdelete(Vehicle_info v)
        {
            Vehicle_info x = db.Vehicle_info.Find(v.Id);
            db.Vehicle_info.Remove(x);
            db.SaveChanges();
            return View();
        }
     

      



        //SIGNUP
        public ActionResult Signuplist()
        {
            return View();
        }

        public ActionResult Signupcreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signupcreate(signup up)
        {
            db.signups.Add(up);
            db.SaveChanges();
            return RedirectToAction("Signuplist"); 
        }

        public ActionResult Signupedit(int? id)
        {
            signup x = db.signups.Find(id);
            if (id == null)
                return HttpNotFound();
            else
                return View();
        }
        [HttpPost]
        public ActionResult Signupedit(signup up)
        {
            db.Entry(up).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Signuplist");
        }

        public ActionResult Signupdelete(int? id)
        {
            signup es = db.signups.Find(id);
            if (es == null)
                return HttpNotFound();
            else
                return View();
        }
        [HttpPost]
        public ActionResult Signupdelete(signup up)
        {
            signup x = db.signups.Find(up.Id);
            db.signups.Remove(x);
            db.SaveChanges();
            return View();
        }



        //SIGNIN
        public ActionResult Signinlist()
        {
            return View();
        }

        public ActionResult Signincreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signincreate(signup i)
        {
            db.signups.Add(i);
            db.SaveChanges();
            return RedirectToAction("Signinlist");
        }

        public ActionResult Signinedit(int? id)
        {
            signup x = db.signups.Find(id);
            if (id == null)
                return HttpNotFound();
            else
                return View();
        }
        [HttpPost]
        public ActionResult Signinedit(signup i)
        {
            db.Entry(i).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Signinlist");
        }

        public ActionResult Signindelete(int? id)
        {
            signup es = db.signups.Find(id);
            if (es == null)
                return HttpNotFound();
            else
                return View();
        }
        [HttpPost]
        public ActionResult Signindelete(signup i)
        {
            signup x = db.signups.Find(i.Id);
            db.signups.Remove(x);
            db.SaveChanges();
            return View();
        }
    }
}