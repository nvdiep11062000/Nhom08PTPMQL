using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using Nhom08PTPMQL.Models;

namespace Nhom08PTPMQL.Controllers
{
    public class AccountController : Controller
    {
        //Action Login (HTTP GET)
        public ViewResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        // Kiểm tra xem return URL có thuộc hệ thống hay không
        private ActionResult RedirectToLocal(string returnURL)
        {
            if(Url.IsLocalUrl(returnURL))
            {
                return Redirect(returnURL);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        Encrytion encry = new Encrytion();
        DemoDbContext db = new DemoDbContext();
        // GET: Account
        
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]

        public ActionResult Register(Account acc)
        {
            if (ModelState.IsValid)
            {
                acc.Password = encry.PasswordEncrytion(acc.Password);
                db.Accounts.Add(acc);
                db.SaveChanges();
                return RedirectToAction("Login", "Account");
            }
            return View(acc);
        }
        [HttpGet]

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]

        public ActionResult Login(Account acc)
        {
            if (ModelState.IsValid)
            {
                string encrytionpass = encry.PasswordEncrytion(acc.Password);
                var model = db.Accounts.Where(m => m.Username == acc.Username && m.Password == encrytionpass).ToList().Count();
                if(model == 1)
                {
                    FormsAuthentication.SetAuthCookie(acc.Username, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "thông tin đăng nhập không chính xác");
                }
            }
            return View(acc);
        }
        // view thứ hai

        
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}