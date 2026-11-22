using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Pizzarendeles.Data;
using Pizzarendeles.Models;

// Szóval alapvetően letiltanám a rendelés gombot, ha nincsenek kiválasztva cuccok, de sokkal viccesebbnek tartom, ha cringe üzeneteket dobálok, ha valami nincs kiválasztva, vagy üresen hagyják a mezőket. :D
 


namespace Pizzarendeles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadPizzak();
        }

        // Ez egy sokkal jobb cucc, mint amit én csináltam, de a másikat legalább én csináltam, ezt meg valamiért az AI beokádta ide ;)
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNev.Text) || string.IsNullOrWhiteSpace(txtCim.Text) || string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Kérlek töltsd ki az összes mezőt!");
                return;
            }
            using (var context = new Data.PizzarendelesekContext())
            {
                var ugyfel = new Models.Ugyfel
                {
                    Nev = txtNev.Text,
                    Cim = txtCim.Text,
                    Telefonszam = txtTelefon.Text
                };
                context.Ugyfelek.Add(ugyfel);
                context.SaveChanges();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewBeallit();
            LoadPizzak();
            UgyfelBetolt();
            alapUgyfel();
        }

        // Itt volt két tanulság.1: Nem volt bent a contextben a pizzaadat, mert kellett egy külön model configuring, ami betölti
        //2. Újra kelleett egy Add-Migration és egy Update-Database, hogy végül bekerüljön
        public void LoadPizzak()
        {
            var context = new Data.PizzarendelesekContext();

            foreach (var pizza in context.Pizzak)
            {
                cmbPizza.Items.Add(pizza);
            }


        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (txtNev.Text == "" || txtCim.Text == "" || txtTelefon.Text == "")
            {
                MessageBox.Show("Kérlek töltsd ki az összes mezőt!");
            }
            using PizzarendelesekContext db = new();
            db.Ugyfelek.Add(new Ugyfel
            {
                Nev = txtNev.Text,
                Cim = txtCim.Text,
                Telefonszam = txtTelefon.Text
            }
            );
            lstUgyfel.Items.Clear();
            mezoUrites();
            // EZ itt először kimaradt és nem értettem, hogy miért nem jelentek meg az ügyfelek a listában
            db.SaveChanges();
            UgyfelBetolt();
        }

        private void UgyfelBetolt()
        {
            using PizzarendelesekContext db = new();
            lstUgyfel.Items.Clear();
            foreach (var ugyfel in db.Ugyfelek)
            {
                lstUgyfel.Items.Add(ugyfel);
            }

        }
        private void mezoUrites()
        {
            txtNev.Text = "";
            txtCim.Text = "";
            txtTelefon.Text = "";
        }

        private void lstUgyfel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUgyfel.SelectedItem is not Ugyfel kivalasztott)
            {
                alapUgyfel();
                dgvRendelesek.DataSource = null;
                return;
            }
            using PizzarendelesekContext db = new();
            lblKivalasztott.Text = $"A kiválsztott ügyfél: {lstUgyfel.SelectedItem.ToString()}";
            
            Ugyfel? ugyfel = db.Ugyfelek
            .Include(u => u.Rendelesek)
            .ThenInclude(r => r.Pizza)
            .FirstOrDefault(u => u.Id == kivalasztott.Id);

            if (ugyfel == null)
            {
                dgvRendelesek.DataSource = null;
            }

            var rendelesLlista = ugyfel.Rendelesek.Select(r => new
            {
                UgyfelNev = ugyfel.Nev,
                PizzaNev = r.Pizza.Nev,
                Darab = r.Darab,
                Datum = r.Datum,
                TeljesAr = r.Darab * r.Pizza.Ar,
            }).ToList();
            dgvRendelesek.DataSource = rendelesLlista;

        }
        //Ez nem volt benne a feladatok között, de hülyén nézett ki csak úgy üresen
        private void alapUgyfel()
        {
            lblKivalasztott.Text = "Nincs kiválasztott ügyfél";
        }

        // Ez amúgy eddig a legizgalmasabb ebben a feladatban :D
        private void txtKereses_TextChanged(object sender, EventArgs e)
        {
            using PizzarendelesekContext db = new();
            string keresett = txtKereses.Text.Trim();

            var lista = db.Ugyfelek.Where(u => keresett == "" || u.Nev.Contains(keresett) || u.Telefonszam.Contains(keresett)).OrderBy(u => u.Nev).ToList();

            lstUgyfel.Items.Clear();
            foreach (var ugyfel in lista)
            {
                lstUgyfel.Items.Add(ugyfel);
            }
        }
        private void rendelesBetolt()
        {
            using PizzarendelesekContext db = new();

            var rendelesLlista = db.Rendelesek.Select(r => new
            {
                UgyfelNev = r.Ugyfel.Nev,
                PizzaNev = r.Pizza.Nev,
                Darab = r.Darab,
                Datum = r.Datum,
                TeljesAr = r.Darab * r.Pizza.Ar,
            }).ToList();
            dgvRendelesek.DataSource = rendelesLlista;
        }

        private void btnRendeles_Click(object sender, EventArgs e)
        {

            if (lstUgyfel.SelectedItem is not Ugyfel kivalasztottUgyfel)
            {
                // Itt simán kihagytam a return-ket és hát annyira nem volt jó..
                MessageBox.Show("Oké, de kinek is küldjük? :D\nNa jó válassz egyet az ügyfelek közül vagy vigyél fel egy új ügyfelet!");
                lstUgyfel.Focus();
                return;
            }
            if (cmbPizza.SelectedItem is not Pizza kivalasztottPizza)
            {
                MessageBox.Show("Nem lehet üres rendelés küldeni! ;)\nVálassz egyet a kiváló pizzák közül a legördülőből!");
                cmbPizza.Focus();
                return;
            }
            if (nudDarab.Value == 0)
            {
                MessageBox.Show("Haver, nem lehet 0 pizzát rendelni! :D");
                nudDarab.Focus();
                return;
            }
            if (dtRendelesDatum.Value < DateTime.Today)
            {
                MessageBox.Show("Haver nem vagyunk időutazók :P\nAzt ajánlom adj időt a legyártáshoz és a kiszállításhoz ");
                dtRendelesDatum.Focus();
                return;
            }
            string kivalasztott = lblKivalasztott.Text.Trim();
            using PizzarendelesekContext db = new();
            var ugyfel = db.Ugyfelek.FirstOrDefault(u => u.Nev == kivalasztottUgyfel.Nev);
            //Eredetileg kiolvastam az lblKivalaszottat,de nem igazán működött, mert van egy string override a pizza-ban ahol a nevet és az árat is visszaadja(meg ugye a "Kiválsztott ugyfél" feliratot is :P), viszont ez nem fog soha egyezni a p.Nev-vel érthető módon
            //ezért csináltam egy ellenőrzést az eljárás elején és abból az objektumból húzom be az adatot
            var pizza = db.Pizzak.FirstOrDefault(p => p.Nev == kivalasztottPizza.Nev);
            db.Rendelesek.Add(new Rendeles
            {

                UgyfelId = ugyfel.Id,
                PizzaId = pizza.Id,
                Darab = (int)nudDarab.Value,
                Datum = dtRendelesDatum.Value,
            });

            db.SaveChanges();

            rendelesBetolt();


            



        }

        private void btnOsszesRendeles_Click(object sender, EventArgs e)
        {
            using PizzarendelesekContext db = new();

            var lista = db.Rendelesek.Join(db.Ugyfelek, r => r.UgyfelId, u => u.Id, (r, u) => new
            {
                r, u
            }).Join(db.Pizzak, ru => ru.r.PizzaId, p => p.Id, (ru, p) => new
            {
                UgyfelNev = ru.u.Nev,
                PizzaNev = p.Nev,
                Darab = ru.r.Darab,
                Datum = ru.r.Datum,
                TeljesAr = ru.r.Darab * p.Ar
            }).ToList();
            dgvRendelesek.DataSource = lista;
        }
        private void DataGridViewBeallit()
        {
            dgvRendelesek.ReadOnly = true;
            dgvRendelesek.AllowUserToAddRows = false;
            dgvRendelesek.AllowUserToDeleteRows = false;
            dgvRendelesek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRendelesek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
