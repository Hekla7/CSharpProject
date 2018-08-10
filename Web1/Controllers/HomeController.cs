using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web1.Models;

namespace Web1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ContactModel model = GetData().Contacts;

            return View(model);
        }

        public ActionResult Catalog()
        {
            List<ItemModel> items = new List<ItemModel>();
            return View(items);
        }
        public ActionResult Buy(string name)
        {
            ItemModel item = null;
            foreach(ItemModel m in GetData().Items)
            {
                if(m.Name == name)
                {
                    item = m;
                    break;
                }
            }
            if (Session["preces"] == null)
            {
                Session["preces"] = new List<ItemModel>();
            }
            (Session["prece"] as List<ItemModel>).Add(item);
            return RedirectToAction("Catalog");
        }
        public static ShopModel GetData() {
            return new ShopModel()
            {
                Name = "Digital",
                Contacts = new ContactModel()
                {
                    Email = "hmm@gmail.ru",
                    Phonenumber = "+371 29401423",
                    Location = new AdressModel()
                    {
                        Country = "Latvia",
                        City = "Riga",
                        Street = "JaunaTeika",
                        HouseNo = "1",
                        ApartmentNo = "0",

                    }
                },
                Items = new List<ItemModel>()
                {
                    new ItemModel()
                    {
                        // Nosaukums + Cena
                        Name = "Laptop",
                        Price = new PriceModel(){
                            Amount =  2.00,
                            Currency = "$",
                        },

                    },
                    new ItemModel()
                    {
                        // Nosaukums + Cena
                        Name = "TV",
                        Price = new PriceModel(){
                            Amount =  150,
                            Currency = "$",
                        },

                    },
                     new ItemModel()
                    {
                        // Nosaukums + Cena
                        Name = "TeddyBear",
                        Price = new PriceModel(){
                            Amount =  50,
                            Currency = "$",
                        },

                    }

                }

            };
    }
    }
}