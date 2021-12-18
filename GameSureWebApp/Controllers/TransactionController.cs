using GameSureWebApp.Areas.Identity.Data;
using GameSureWebApp.Data;
using GameSureWebApp.Models;
using GameSureWebApp.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSureWebApp.Controllers
{

    public class TransactionController : Controller
    {
        private GameSureDBContext _gameSureDBContext;
        private readonly UserManager<GameSureWebAppUser> _userManager;

        public TransactionController(GameSureDBContext gameSureDBContext, UserManager<GameSureWebAppUser> userManager)
        {
            _gameSureDBContext = gameSureDBContext;
            _userManager = userManager;
        }
        // GET: Transaction
        public ActionResult Index()
        {
            return View();
        }

        // GET: Transaction/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Transaction/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Transaction/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: Transaction/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Transaction/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Transaction/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Transaction/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public IActionResult TxnComplete(UserForm userForm)
        {



            //GameSureWebAppUser gameSureWebAppUser = new GameSureWebAppUser
            //{
            //    FirstName = userForm.FirstName,
            //    LastName=userForm.LastName,
            //    Email = userForm.EmailId,
            //    Phone = userForm.Phone,
            //};
            GameSureWebAppUser appuser = _userManager.GetUserAsync(User).GetAwaiter().GetResult();
            Address address = new Address
            {
                Address1 = userForm.Addr1,
                Address2 = userForm.Addr2,
                City = userForm.City,
                Province = userForm.Province.ToString(),
                Country = userForm.Country.ToString(),
                Zipcode = userForm.Zipcode,
                GameSureWebAppUser = appuser
            };

            PaymentMethod paymentMethod = new PaymentMethod
            {
                PaymentType = userForm.CardType
            };

            Product product = new Product();

            product = _gameSureDBContext.Products.FirstOrDefault(P => P.ProdPlan == userForm.ProdPlan);
            TransactionDet transactionDet = new TransactionDet
            {
                StartDate = userForm.StartDate,
                EndDate = userForm.EndDate,
                EquipmentDet = userForm.EquipmentDet,
                TotalPrice = product.Price

            };

            Transaction transaction = new Transaction
            {
                TxnDate = DateTime.Now,
                TxnStatus = "C",
                PaymentMethod = paymentMethod,
                GameSureWebAppUser = appuser,
                transactionDets=new List<TransactionDet>() { transactionDet}
                
            };

            _gameSureDBContext.Transactions.Add(transaction);
            _gameSureDBContext.Addresses.Add(address);

            _gameSureDBContext.SaveChanges();
                    
         return View();
    }

    }
}
