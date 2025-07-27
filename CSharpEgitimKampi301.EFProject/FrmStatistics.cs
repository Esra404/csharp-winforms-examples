using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text=db.LocationTbl.Count().ToString();
            //lblSumCapacity.Text = db.LocationTbl.Sum(x => x.LocationCapacity).ToString();
            lblSumCapacity.Text = db.LocationTbl
      .ToList() // Verileri önce belleğe al
      .Select(x => {
          int val;
          return int.TryParse(x.LocationCapacity, out val) ? val : 0;
      })
      .Sum()
      .ToString();
            lblGuideCount.Text=db.GuideTbl.Count().ToString();
            // lblAvgCapacity.Text = db.LocationTbl.Average(x=>x.LocationCapacity).ToString();
            lblAvgCapacity.Text = db.LocationTbl
     .ToList()
     .Select(x => {
         int val;
         return int.TryParse(x.LocationCapacity, out val) ? val : 0;
     })
     .Average()
     .ToString();

            lblAvgLocation.Text=db.LocationTbl.Average(x=>x.LocationPrice).ToString();
             lblLastCountryName.Text = db.LocationTbl.OrderByDescending(x => x.LocationId).Select(x => x.LocationCity).FirstOrDefault();
            //int lastCountryId = db.LocationTbl.Max(x => x.LocationId);
            //lblLastCountryName.Text = db.LocationTbl.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();
            //lblCappadociaLocationCapacity.Text=db.LocationTbl.LocationCapacity.Count.ToString(); 

            //        lblCappadociaLocationCapacity.Text = db.LocationTbl
            //.Count(x => x.LocationCity == "Konya")
            //.ToString();
            //        lblTurkiyeCapacityAvg.Text=db.LocationTbl.Where(
            //            x=>x.LocationCountry=="Türkiye").Average(y=>y.LocationCapacity).ToString();

            lblTurkiyeCapacityAvg.Text = db.LocationTbl
                .Where(x => x.LocationCountry == "Türkiye")
                .ToList()
            .Select(x => {
                    int val;
                    return int.TryParse(x.LocationCapacity, out val) ? val : 0;
                })
                .Average()
                .ToString("0.##");
            //lblTurkiyeCapacityAvg.Text = db.LocationTbl.Where(x => x.LocationCapacity == "Türkiye").Average(y => y.LocationCapacity).ToString();

           var romeGuideId=db.LocationTbl.Where(x=>x.LocationCity=="Roma" ).Select(y=>y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.GuideTbl.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

            var maxCapasity=db.LocationTbl.Max(x=>x.LocationCapacity);
            lblMaxCapacityLocation.Text=db.LocationTbl.Where(x=>x.LocationCapacity==maxCapasity).Select(y=>y.LocationCity).FirstOrDefault().ToString();

            var maxPrice = db.LocationTbl.Max(x => x.LocationPrice);
            lblMaxPriceLocation.Text = db.LocationTbl.Where(x => x.LocationPrice == maxPrice).Select(y => y.LocationCity).FirstOrDefault().ToString();


            var guideIdByNameAysegulCinar=db.GuideTbl.Where(x=>x.GuideName=="Esra" && x.GuideSurname=="Durmaz").Select(
                y=>y.GuideId).FirstOrDefault();
            lblAysegulCinarLocation.Text = db.LocationTbl.Where(x => x.GuideId == guideIdByNameAysegulCinar).Count().ToString();
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}