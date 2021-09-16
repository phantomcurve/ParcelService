using Microsoft.AspNetCore.Mvc;
using ParcelService.Models;
using System.Collections.Generic;

namespace ParcelService.Controllers
{
  public class ParcelController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(int length, int height, int width, int weight)
    {
      Parcel myParcel = new Parcel(length, height, width, weight);
      return RedirectToAction("Index");
    }
  }
}