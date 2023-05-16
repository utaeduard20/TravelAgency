using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Cms;
using TravelAgencyTest.Models;

namespace TravelAgencyTest.Controllers
{
    public class DataController : Controller
    {
        public ActionResult CompressAndSaveToDatabase(string input)
        {
            byte[] compressedData = Models.CompressionHelper.CompressString(input);

            // Save the compressed data to the database using your preferred method

            return RedirectToAction("Index");
        }

        public ActionResult RetrieveAndDecompressFromDatabase(int id, byte[] compressedData)
        {

            string decompressedData = CompressionHelper.DecompressString(compressedData);

            ViewBag.DecompressedData = decompressedData;

            return View();
        }
    }
}
