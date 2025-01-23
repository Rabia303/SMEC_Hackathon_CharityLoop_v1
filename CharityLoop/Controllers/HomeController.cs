using CharityLoop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CharityLoop.Controllers

{
	public class HomeController : Controller
	{
		public readonly ngoDbContext db;

		public HomeController(ngoDbContext db)
		{
			this.db = db;
		}

		public IActionResult Index()
		{
			return View(db.OurPrograms.ToList());
		}
		public IActionResult Contact()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Contact(contact op)
		{
			if (HttpContext.Session.GetString("s") != null)
			{
				// Set user ID in the donation object
				op.UserId = Convert.ToInt32(HttpContext.Session.GetString("s"));

				db.Contact.Add(op);
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			else
			{
				// If user ID is not set in session, redirect to another action or page
				return RedirectToAction("login");
			}

		}

		// GET: Home/DonateClothes (for displaying the donation form)
		public IActionResult DonateClothes()
		{
			// Passing the list of NGOs to the view to allow users to select an NGO
			ViewBag.ngoList = db.NGOs.Select(n => new SelectListItem
			{
				Text = n.Name + " - " + n.Location,
				Value = n.NGOId.ToString()
			}).ToList();

			return View();
		}

		// POST: Home/DonateClothes (for processing the form submission)
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult DonateClothes(DonateClothes donation)
		{
			if (ModelState.IsValid)
			{
				// If the donation is valid, add the new donation to the database
				donation.CreatedAt = DateTime.Now;

				// Save the donation details in the database
				db.DonateClothes.Add(donation);
				db.SaveChanges();

				// Redirect to a thank you page or back to donation page
				return RedirectToAction("ThankYou");
			}

			// If there were validation errors, send the NGO list again and return the same form
			ViewBag.ngoList = db.NGOs.Select(n => new SelectListItem
			{
				Text = n.Name + " - " + n.Location,
				Value = n.NGOId.ToString()
			}).ToList();

			return View(donation);
		}

		// GET: Home/ThankYou (this will be the page the user sees after donation)
		public IActionResult ThankYou()
		{
			return View();
		}
	

	public IActionResult About()
		{
			var cwu = db.About_Career_with_us.ToList();
			var om = db.ABout_Our_Mission.ToList();
			var os = db.About_Our_Supporters.ToList();
			var team = db.About_team.ToList();
			var wwd = db.About_what_we_do.ToList();
			about1 ab = new about1()
			{
				aboutcwu = cwu,
				aboutom = om,
				aboutos = os,
				aboutteam = team,
				aboutwwd = wwd,
			};

			return View(ab);
		}

		public IActionResult Donate()
		{
			// Check if the user is signed in
			bool isUserSignedIn = HttpContext.Session.GetString("s") != null;

			// Get the donation data
			var ep = db.AddDonation.ToList();
			ViewBag.ep = new SelectList(ep, "donationId", "cause");

			// Pass the flag to the view
			ViewBag.IsUserSignedIn = isUserSignedIn;

			return View();
		}

		[HttpPost]
		public IActionResult Donate(donation add)
		{
			// Check if user ID is set in session
			if (HttpContext.Session.GetString("s") != null)
			{
				add.UserId = Convert.ToInt32(HttpContext.Session.GetString("s"));
				db.Donation.Add(add);
				db.SaveChanges();
				return RedirectToAction("donationthanks");
			}
			else
			{
				// If user is not signed in, show message to sign in
				TempData["ErrorMessage"] = "Please sign in to make a donation.";
				return RedirectToAction("Donate");
			}
		}

		public IActionResult donationthanks()
		{
			return View();
		}
		public IActionResult Our_Programes()
		{
			return View(db.OurPrograms.ToList());
		}
		public IActionResult Help_Center()
		{
			return View(db.HelpCentre.ToList());

		}
		public IActionResult Partners()
		{
			return View(db.About_team.ToList());
		}

		public IActionResult Gallery()
		{
			return View(db.Gallery.ToList());
		}

		public IActionResult Teams()
		{
			return View(db.About_team.ToList());
		}

		public IActionResult Careers()
		{

			return View();
		}
		[HttpPost]
		public IActionResult Careers(about_cwu op)
		{
			db.About_Career_with_us.Add(op);
			db.SaveChanges();
			return RedirectToAction("Careers");
		}
		public IActionResult register()
		{
			return View();
		}
		[HttpPost]
		public IActionResult register(UserReg add)
		{
			db.User_Reg.Add(add);
			db.SaveChanges();
			return RedirectToAction("Login");
		}

		public IActionResult Login()
		{
			if (HttpContext.Session.GetString("s") != null)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		[HttpPost]
		public IActionResult Login(UserReg log)
		{
			var login = db.User_Reg.Where(db => db.UserEmail == log.UserEmail && db.UserPass == log.UserPass).FirstOrDefault();
			if (login != null)
			{
				//		HttpContext.Session.SetString("s", login.UserId.Convert.ToInt32);
				HttpContext.Session.SetString("s", login.UserId.ToString());

				return RedirectToAction("Index");
			}
			else
			{
				ViewBag.m = "Login Failed";
			}
			return View();
		}
		public IActionResult logout()
		{

			if (HttpContext.Session.GetString("s") != null)
			{
				HttpContext.Session.Remove("s");
				return RedirectToAction("Login");
			}
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
