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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
           // EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
            var values =db.GuideTbl.ToList();
            dataGridView1.DataSource = values;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //  EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
            GuideTbl guide = new GuideTbl();
            guide.GuideName = textName.Text;
            guide.GuideSurname = textSurname.Text;
            db.GuideTbl.Add(guide);
            db.SaveChanges();
            MessageBox.Show("RehberId Başarıyla Güncellendi");
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textId.Text);
            var removeValue = db.GuideTbl.Find(id);
            db.GuideTbl.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber Bşarıyla Silindi"); 

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id=int.Parse(textId.Text);
            var updateValue = db.GuideTbl.Find(id);
            updateValue.GuideName = textName.Text;
            updateValue.GuideSurname= textSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id=int.Parse(textId.Text);
            var values = db.GuideTbl.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
