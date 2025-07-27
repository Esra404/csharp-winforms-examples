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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textId.Text);
            var updateValue = db.LocationTbl.Find(id);
            updateValue.DayNight = textDayNight.Text;
            updateValue.LocationPrice = byte.Parse(textPrice.Text);
            updateValue.LocationCapacity=(nudCapacity.Value.ToString());
            updateValue.LocationCity=textCity.Text;
            updateValue.LocationCountry=textCountry.Text;   
            updateValue.GuideId=int.Parse(combGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textId.Text);
            var deletedValue = db.LocationTbl.Find(id);
            db.LocationTbl.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Silme işlmei başarıyla tammalandı");


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LocationTbl location=new LocationTbl();
            location.LocationCapacity =(nudCapacity.Value.ToString());
            location.LocationCity = textCity.Text;
            location.LocationCountry=textCountry.Text;
            location.LocationPrice=byte.Parse(textPrice.Text);
            location.DayNight = textDayNight.Text;
            location.GuideId=int.Parse(combGuide.SelectedValue.ToString());
            db.LocationTbl.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi tamamlandı");
        }

        private void textSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values=db.LocationTbl.ToList();
            dataGridView1.DataSource = values;

        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values=db.GuideTbl.Select(x=> new
            {
                FullName=x.GuideName+" "+x.GuideSurname,
                x.GuideId
            }).ToList();
            combGuide.DisplayMember = "FullName" ;
            combGuide.ValueMember = "GuideId";
            combGuide.DataSource = values;
        }
    }
}
