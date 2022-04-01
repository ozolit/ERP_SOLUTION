using ERP_SOLUTION.DAL;
using ERP_SOLUTION.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_SOLUTION.Areas.Common.Controllers
{
    public class CommonController : Controller
    {
        // GET: Common/Common
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }
        public ActionResult AccountSettings()
        {
            return View();
        }


        public ActionResult logout()
        {
            return View();
        }

        public ActionResult PersonType()
        {
            return View();
        }
        public ActionResult SchoolType()
        {
            return View();
        }
        public ActionResult ExamType()
        {
            return View();
        }
        public ActionResult EntryType()
        {
            return View();
        }
        public ActionResult PaymentType()
        {
            return View();
        }
        public ActionResult FeeType()
        {
            return View();
        }
        //bellow function creates person type ##STARTS###
        public ActionResult CreatePersonType(PersonType personType)
        {
            try
            {
                if (personType != null)
                {

                    using (ERPEntities db = new ERPEntities())
                    {
                        List<PERSON_TYPE> CheckPersonTypeEntity = db.PERSON_TYPE.Where(p => p.Name == personType.Name).ToList();
                        if (CheckPersonTypeEntity.Count == 1)
                        {
                            return Json(-2); //Person Type Already exists
                        }
                        else
                        {
                            PERSON_TYPE PersonTypeEntity = new PERSON_TYPE();
                            PersonTypeEntity.Name = personType.Name;
                            PersonTypeEntity.AddedBy = personType.AddedBy;
                            db.PERSON_TYPE.Add(PersonTypeEntity);
                            db.SaveChanges();
                            return Json(PersonTypeEntity.PersonTypeId);
                        }
                    }

                }
                else
                {
                    return Json(-1);////server Could not be reached
                }
                
            } catch (Exception ex)
            {
                return Json(0);// Error while processing the submission
            }
        }
        //Above function creates person type ##ENDS###


        



        //bellow function creates person type ##STARTS###
        public ActionResult CreateSchoolType(SchoolType schoolType)
        {
            try
            {
                if (schoolType != null)
                {

                    using (ERPEntities db = new ERPEntities())
                    {
                        List<SCHOOL_TYPE> CheckSchoolTypeEntity = db.SCHOOL_TYPE.Where(p => p.Name == schoolType.Name).ToList();
                        if (CheckSchoolTypeEntity.Count == 1)
                        {
                            return Json(-2); //School Type Already exists
                        }
                        else
                        {
                            SCHOOL_TYPE SchoolTypeEntity = new SCHOOL_TYPE();
                            SchoolTypeEntity.Name = schoolType.Name;
                            SchoolTypeEntity.AddedBy = schoolType.AddedBy;
                            db.SCHOOL_TYPE.Add(SchoolTypeEntity);
                            db.SaveChanges();
                            return Json(SchoolTypeEntity.SchoolTypeId);
                        }
                    }

                }
                else
                {
                    return Json(-1);////server Could not be reached
                }

            }
            catch (Exception ex)
            {
                return Json(0);// Error while processing the submission
            }
        }
        //Above function creates person type ##ENDS###
    }
}