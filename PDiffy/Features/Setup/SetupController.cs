﻿using System.Web.Mvc;
using PDiffy.Infrastructure;

namespace PDiffy.Features.Setup
{
	public class SetupController : Controller
	{
		public ActionResult Index()
		{
			if (!string.IsNullOrWhiteSpace(Environment.ImageStorePath) && !string.IsNullOrWhiteSpace(Environment.DataStorePath))
				return RedirectToAction("Index", "Differences");
			return View();
		}

		public ActionResult Setup(string imageStorePath, string dataStorePath)
		{
			Environment.ImageStorePath = imageStorePath;
			Environment.DataStorePath = dataStorePath;

			return RedirectToAction("Index", "Differences");
		}
	}
}