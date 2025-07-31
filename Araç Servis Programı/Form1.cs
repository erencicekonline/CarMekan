using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        private bool karanlikMod = false;


        bool emailUyarisiVerildi = false;

        public bool Mod { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Otomobil")
            {

                if (comboBox2.Text == "Alfa Romeo")
                {
                    comboBox3.Items.Clear();
                    string[] alfaoto = { "Giulia", "Giulia Quadrifoglio", "Giulietta", "147", "156", "159", "166", "Brera", "GT", "MiTo", "Spider" };
                    comboBox3.Items.AddRange(alfaoto);
                }

                else if (comboBox2.Text == "Audi")
                {
                    comboBox3.Items.Clear();
                    string[] audioto = { "A1", "A3", "A4", "A5", "A6", "A6 E-Tron", "A7", "A8", "E-Tron GT", "R8", "RS", "S Serisi", "TT", "TTS" };
                    comboBox3.Items.AddRange(audioto);
                }

                else if (comboBox2.Text == "BMW")
                {
                    comboBox3.Items.Clear();
                    string[] bmwoto = { "1 Serisi", "2 Serisi", "3 Serisi", "4 Serisi", "5 Serisi", "6 Serisi", "7 Serisi", "8 Serisi", "i Serisi", "M Serisi", "Z Serisi" };
                    comboBox3.Items.AddRange(bmwoto);
                }

                else if (comboBox2.Text == "Chevrolet")
                {
                    comboBox3.Items.Clear();
                    string[] chevroletoto = { "Aveo", "Camaro", "Corvette", "Cruze", "Epica", "Kalos", "Lacetti", "Rezzo", "Spark" };
                    comboBox3.Items.AddRange(chevroletoto);
                }

                else if (comboBox2.Text == "Citroen")
                {
                    comboBox3.Items.Clear();
                    string[] citroenoto = { "AMI", "C-Elysée", "C1", "C2", "C3", "C3 Picasso", "C4", "C4 Grand Picasso", "C4 Picasso", "C4 X", "e-C4", "e-C4 X", "C5", "Xsara" };
                    comboBox3.Items.AddRange(citroenoto);
                }

                else if (comboBox2.Text == "Dacia")
                {
                    comboBox3.Items.Clear();
                    string[] daciaoto = { "Jogger", "Lodgy", "Logan", "Sandero" };
                    comboBox3.Items.AddRange(daciaoto);
                }

                else if (comboBox2.Text == "Fiat")
                {
                    comboBox3.Items.Clear();
                    string[] fiatoto = { "Albea", "Bravo", "500 Ailesi", "Egea", "Linea", "Marea", "Palio", "Panda", "Punto", "Stilo", "Topolino" };
                    comboBox3.Items.AddRange(fiatoto);
                }

                else if (comboBox2.Text == "Ford")
                {
                    comboBox3.Items.Clear();
                    string[] fordoto = { "B-Max", "C-Max", "Fiesta", "Focus", "Fusion", "Galaxy", "Grand C-Max", "Mondeo", "S-Max" };
                    comboBox3.Items.AddRange(fordoto);
                }

                else if (comboBox2.Text == "Honda")
                {
                    comboBox3.Items.Clear();
                    string[] hondaoto = { "Accord", "City", "Civic", "CR-Z", "Jazz", "Legend", "S2000" };
                    comboBox3.Items.AddRange(hondaoto);
                }

                else if (comboBox2.Text == "Hyundai")
                {
                    comboBox3.Items.Clear();
                    string[] hyundaioto = { "Accent", "Accent Blue", "Accent Era", "Atos", "Coupe", "Elantra", "Genesis", "Getz", "i10", "i20", "i20 Active", "i20 N", "i20 Troy", "i30", "i40", "Ioniq", "Ioniq 6", "iX20", "Matrix", "Sonata" };
                    comboBox3.Items.AddRange(hyundaioto);
                }

                else if (comboBox2.Text == "Kia")
                {
                    comboBox3.Items.Clear();
                    string[] kiaoto = { "Carnival", "Ceed", "Cerato", "Optima", "Picanto", "Pro Ceed", "Rio", "Venga" };
                    comboBox3.Items.AddRange(kiaoto);
                }

                else if (comboBox2.Text == "Mazda")
                {
                    comboBox3.Items.Clear();
                    string[] mazdaoto = { "2", "3", "5", "6", "MX", "RX" };
                    comboBox3.Items.AddRange(mazdaoto);
                }

                else if (comboBox2.Text == "Mercedes-Benz")
                {
                    comboBox3.Items.Clear();
                    string[] mercedesoto = { "A Serisi", "AMG GT", "B Serisi", "C Serisi", "CL", "CLA", "CLE", "CLC", "CLK", "CLS", "E Serisi", "EQE", "EQS", "Maybach S", "R Serisi", "S Serisi", "SL", "SLC", "SLK", "SLS AMG" };
                    comboBox3.Items.AddRange(mercedesoto);
                }

                else if (comboBox2.Text == "Mitsubishi")
                {
                    comboBox3.Items.Clear();
                    string[] mitsubishioto = { "Attrage", "Colt", "Lancer", "Lancer Evolution", "Carisma", "Space Star" };
                    comboBox3.Items.AddRange(mitsubishioto);
                }

                else if (comboBox2.Text == "Nissan")
                {
                    comboBox3.Items.Clear();
                    string[] nissanoto = { "350 Z", "Almera", "GT-R", "Micra", "Note", "Primera", "Pulsar" };
                    comboBox3.Items.AddRange(nissanoto);
                }

                else if (comboBox2.Text == "Opel")
                {
                    comboBox3.Items.Clear();
                    string[] opeloto = { "Adam", "Astra", "Astra-e", "Cascada", "Corsa", "Corsa-e", "Insignia", "Meriva", "Tigra", "Vectra", "Zafira" };
                    comboBox3.Items.AddRange(opeloto);
                }

                else if (comboBox2.Text == "Peugeot")
                {
                    comboBox3.Items.Clear();
                    string[] peugeototo = { "107", "206", "206 +", "207", "208", "e-208", "301", "307", "308", "e-308", "407", "508", "RCZ" };
                    comboBox3.Items.AddRange(peugeototo);
                }

                else if (comboBox2.Text == "Porsche")
                {
                    comboBox3.Items.Clear();
                    string[] porscheoto = { "718", "911", "Boxster", "Cayman", "Panamera", "Taycan" };
                    comboBox3.Items.AddRange(porscheoto);
                }

                else if (comboBox2.Text == "Renault")
                {
                    comboBox3.Items.Clear();
                    string[] renaultoto = { "Clio", "Espace", "Fluence", "Fluence Z.E.", "Grand Scenic", "Laguna", "Latitude", "Megane", "Megane E-Tech", "Modus", "Scenic", "Symbol", "Taliant", "Talisman", "Twizy", "ZOE" };
                    comboBox3.Items.AddRange(renaultoto);
                }

                else if (comboBox2.Text == "Seat")
                {
                    comboBox3.Items.Clear();
                    string[] seatoto = { "Alhambra", "Altea", "Cordoba", "Exeo", "Ibiza", "Leon", "Toledo" };
                    comboBox3.Items.AddRange(seatoto);
                }

                else if (comboBox2.Text == "Skoda")
                {
                    comboBox3.Items.Clear();
                    string[] skodaoto = { "Citigo", "Fabia", "Octavia", "Rapid", "Roomster", "Scala", "Superb" };
                    comboBox3.Items.AddRange(skodaoto);
                }

                else if (comboBox2.Text == "Subaru")
                {
                    comboBox3.Items.Clear();
                    string[] subaruoto = { "BRZ", "Impreza", "Legacy", "Levorg" };
                    comboBox3.Items.AddRange(subaruoto);
                }

                else if (comboBox2.Text == "Suzuki")
                {
                    comboBox3.Items.Clear();
                    string[] suzukioto = { "Alto", "Baleno", "Splash", "Swift", "SX4" };
                    comboBox3.Items.AddRange(suzukioto);
                }

                else if (comboBox2.Text == "Toyota")
                {
                    comboBox3.Items.Clear();
                    string[] toyotaoto = { "Auris", "Avensis", "Camry", "Corolla", "GT86", "Prius", "Urban Cruiser", "Verso", "Yaris" };
                    comboBox3.Items.AddRange(toyotaoto);
                }

                else if (comboBox2.Text == "Volkswagen")
                {
                    comboBox3.Items.Clear();
                    string[] volkswagenoto = { "Arteon", "Beetle", "Bora", "EOS", "Golf", "Jetta", "Passat", "Passat Alltrack", "Passat Variant", "Phaeton", "Polo", "Scirocco", "Sharan", "Touran", "VW CC" };
                    comboBox3.Items.AddRange(volkswagenoto);
                }

                else if (comboBox2.Text == "Volvo")
                {
                    comboBox3.Items.Clear();
                    string[] volvooto = { "C30", "C70", "S40", "S60", "S80", "S90", "V40", "V40 Cross Country", "V50", "V60", "V60 Cross Country", "V70", "V90 Cross Country" };
                    comboBox3.Items.AddRange(volvooto);
                }

            }

            else if (comboBox1.Text == "Arazi, SUV & Pickup")
            {
                if (comboBox2.Text == "Alfa Romeo")
                {
                    comboBox3.Items.Clear();
                    string[] alfasuv = { "Junior Elettrica","Junior Ibrida","Stelvio","Tonale" };
                    comboBox3.Items.AddRange(alfasuv);
                }

                else if (comboBox2.Text == "Audi")
                {
                    comboBox3.Items.Clear();
                    string[] audisuv = { "E-Tron","E-Tron Sportback","Q2","Q3","Q3 Sportback","Q4 E-tron","Q4 Sportback","Q5","Q5 Sportback","Q7","Q8","Q8 E-tron","Q8 E-tron Sportback","RS Q8" };
                    comboBox3.Items.AddRange(audisuv);
                }

                else if (comboBox2.Text == "BMW")
                {
                    comboBox3.Items.Clear();
                    string[] bmwsuv = { "iX", "iX1", "iX2", "iX3", "X1", "X2", "X3", "X4", "X5", "X6" };
                    comboBox3.Items.AddRange(bmwsuv);
                }

                else if (comboBox2.Text == "BYD")
                {
                    comboBox3.Items.Clear();
                    string[] bydsuv = { "Atto 3 EV", "Seal U", "Seal U EV" };
                    comboBox3.Items.AddRange(bydsuv);
                }

                else if (comboBox2.Text == "Chery")
                {
                    comboBox3.Items.Clear();
                    string[] cherysuv = { "Omoda 5", "Omoda 5 Pro", "Tiggo 3", "Tiggo 7 Pro", "Tiggo 7 Pro Max", "Tiggo 8 Pro", "Tiggo 8 Pro Max" };
                    comboBox3.Items.AddRange(cherysuv);
                }

                else if (comboBox2.Text == "Chevrolet")
                {
                    comboBox3.Items.Clear();
                    string[] chevroletsuv = { "Captiva", "Equinox", "Silverado", "Trax" };
                    comboBox3.Items.AddRange(chevroletsuv);
                }

                else if (comboBox2.Text == "Citroen")
                {
                    comboBox3.Items.Clear();
                    string[] citroensuv = { "C3 AirCross", "C4 Cactus", "C5 AirCross" };
                    comboBox3.Items.AddRange(citroensuv);
                }

                else if (comboBox2.Text == "Dacia")
                {
                    comboBox3.Items.Clear();
                    string[] daciasuv = { "Duster", "Logan Pickup", "Sandero Stepway", "Spring" };
                    comboBox3.Items.AddRange(daciasuv);
                }

                else if (comboBox2.Text == "Fiat")
                {
                    comboBox3.Items.Clear();
                    string[] fiatsuv = { "Egea Cross", "Freemont", "Fullback", "Sedici", "500 X", "600", "600e" };
                    comboBox3.Items.AddRange(fiatsuv);
                }

                else if (comboBox2.Text == "Ford")
                {
                    comboBox3.Items.Clear();
                    string[] fordsuv = { "EcoSport", "Edge", "Kuga", "Mustang Mach-E", "Puma", "Ranger", "Ranger Raptor" };
                    comboBox3.Items.AddRange(fordsuv);
                }
                
                else if (comboBox2.Text == "Honda")
                {
                    comboBox3.Items.Clear();
                    string[] hondasuv = { "CR-V", "HR-V", "ZR-V" };
                    comboBox3.Items.AddRange(hondasuv);
                }

                else if (comboBox2.Text == "Hyundai")
                {
                    comboBox3.Items.Clear();
                    string[] hyundaisuv = { "Bayon", "Ioniq 5", "Ioniq 5 N", "ix35", "Kona", "Santa Fe", "Tucson" };
                    comboBox3.Items.AddRange(hyundaisuv);
                }

                else if (comboBox2.Text == "Jeep")
                {
                    comboBox3.Items.Clear();
                    string[] jeepsuv = { "Avenger Electric", "Avenger Hybrid", "Cherokee", "Commander", "Compass", "Grand Cherokee", "Patriot", "Renegade", "Wrangler" };
                    comboBox3.Items.AddRange(jeepsuv);
                }

                else if (comboBox2.Text == "Kia")
                {
                    comboBox3.Items.Clear();
                    string[] kiasuv = { "EV3", "EV6", "EV9", "Niro", "Niro EV", "Sorento", "Soul", "Sportage", "Stonic" };
                    comboBox3.Items.AddRange(kiasuv);
                }

                else if (comboBox2.Text == "Land Rover")
                {
                    comboBox3.Items.Clear();
                    string[] landsuv = { "Defender", "Discovery", "Discovery Sport", "Range Rover", "Range Rover Evoque", "Range Rover Sport", "Range Rover Velar", "Freelander" };
                    comboBox3.Items.AddRange(landsuv);
                }

                else if (comboBox2.Text == "Mazda")
                {
                    comboBox3.Items.Clear();
                    string[] mazdasuv = { "CX-3", "CX-5", "B Serisi" };
                    comboBox3.Items.AddRange(mazdasuv);
                }

                else if (comboBox2.Text == "Mercedes-Benz")
                {
                    comboBox3.Items.Clear();
                    string[] mercedessuv = { "EQA", "EQB", "EQC", "G Serisi", "GL", "GLA", "GLB", "GLC", "GLC Coupe", "GLE", "GLE Coupe", "GLK", "GLS", "ML", "X" };
                    comboBox3.Items.AddRange(mercedessuv);
                }

                else if (comboBox2.Text == "MG")
                {
                    comboBox3.Items.Clear();
                    string[] mgsuv = { "EHS", "HS", "Marvel R", "ZS", "ZS EV" };
                    comboBox3.Items.AddRange(mgsuv);
                }

                else if (comboBox2.Text == "Mitsubishi")
                {
                    comboBox3.Items.Clear();
                    string[] mitsubishisuv = { "ASX", "Eclipse Cross", "L 200", "Outlander" };
                    comboBox3.Items.AddRange(mitsubishisuv);
                }

                else if (comboBox2.Text == "Nissan")
                {
                    comboBox3.Items.Clear();
                    string[] nissansuv = { "Juke", "Navara", "Pathfinder", "Qashqai", "Qashqai+2", "X-Trail", "Country", "Rally Raid", "Skystar" };
                    comboBox3.Items.AddRange(nissansuv);
                }

                else if (comboBox2.Text == "Opel")
                {
                    comboBox3.Items.Clear();
                    string[] opelsuv = { "Crossland", "Crossland X", "Grandland", "Grandland-e", "Grandland X", "Mokka", "Mokka-e", "Mokka X" };
                    comboBox3.Items.AddRange(opelsuv);
                }

                else if (comboBox2.Text == "Peugeot")
                {
                    comboBox3.Items.Clear();
                    string[] peugeotsuv = { "408", "2008", "e-2008", "3008", "e-3008", "4007", "5008", "e-5008" };
                    comboBox3.Items.AddRange(peugeotsuv);
                }

                else if (comboBox2.Text == "Porsche")
                {
                    comboBox3.Items.Clear();
                    string[] porschesuv = { "Cayenne", "Cayenne Coupe", "Macan" };
                    comboBox3.Items.AddRange(porschesuv);
                }

                else if (comboBox2.Text == "Renault")
                {
                    comboBox3.Items.Clear();
                    string[] renaultsuv = { "Austral", "Duster", "Captur", "Kadjar", "Koleos", "Rafale" };
                    comboBox3.Items.AddRange(renaultsuv);
                }

                else if (comboBox2.Text == "Seat")
                {
                    comboBox3.Items.Clear();
                    string[] seatsuv = { "Tarraco", "Arona", "Ateca" };
                    comboBox3.Items.AddRange(seatsuv);
                }

                else if (comboBox2.Text == "Skoda")
                {
                    comboBox3.Items.Clear();
                    string[] skodasuv = { "Kamiq", "Karoq", "Kodiaq", "Yeti" };
                    comboBox3.Items.AddRange(skodasuv);
                }

                else if (comboBox2.Text == "Skywell")
                {
                    comboBox3.Items.Clear();
                    string[] skywellsuv = { "Exclusive", "Legend", "Premium Line", "Premium Plus" };
                    comboBox3.Items.AddRange(skywellsuv);
                }

                else if (comboBox2.Text == "SsangYong")
                {
                    comboBox3.Items.Clear();
                    string[] ssangyongsuv = { "Actyon", "Actyon Sports", "Korando", "Korando Sports", "Kyron", "Musso", "Musso Grand", "Rexton", "Tivoli", "Torres", "Torres EVX" };
                    comboBox3.Items.AddRange(ssangyongsuv);
                }

                else if (comboBox2.Text == "Subaru")
                {
                    comboBox3.Items.Clear();
                    string[] subarusuv = { "Crosstrek", "Forester", "Outback", "Solterra", "XV" };
                    comboBox3.Items.AddRange(subarusuv);
                }

                else if (comboBox2.Text == "Suzuki")
                {
                    comboBox3.Items.Clear();
                    string[] suzikisuv = { "Grand Vitara", "Jimny", "S-Cross", "Vitara" };
                    comboBox3.Items.AddRange(suzikisuv);
                }

                else if (comboBox2.Text == "TOGG")
                {
                    comboBox3.Items.Clear();
                    string[] toggsuv = { "V1", "V2" };
                    comboBox3.Items.AddRange(toggsuv);
                }

                else if (comboBox2.Text == "Toyota")
                {
                    comboBox3.Items.Clear();
                    string[] toyotasuv = { "C-HR", "Corolla Cross", "FJ Cruiser", "Hilux", "Land Cruiser", "Land Cruiser Prado", "RAV4", "Yaris Cross" };
                    comboBox3.Items.AddRange(toyotasuv);
                }

                else if (comboBox2.Text == "Volkswagen")
                {
                    comboBox3.Items.Clear();
                    string[] volkswagensuv = { "Amarok", "ID.4", "ID.6", "T-Cross", "T-Roc", "Taigo", "Tayron", "Tiguan", "Tiguan AllSpace", "Touareg" };
                    comboBox3.Items.AddRange(volkswagensuv);
                }

                else if (comboBox2.Text == "Volvo")
                {
                    comboBox3.Items.Clear();
                    string[] volvosuv = { "C40", "EX40", "XC40", "XC60", "XC70", "XC90" };
                    comboBox3.Items.AddRange(volvosuv);
                }

            }

            else if (comboBox1.Text == "Minivan & Panelvan")
            {
                if (comboBox2.Text == "Citroen")
                {
                    comboBox3.Items.Clear();
                    string[] citroenvan = { "Berlingo", "Jumper", "Jumpy", "Nemo" };
                    comboBox3.Items.AddRange(citroenvan);
                }

                else if (comboBox2.Text == "Dacia")
                {
                    comboBox3.Items.Clear();
                    string[] daciavan = { "Dokker", "Logan" };
                    comboBox3.Items.AddRange(daciavan);
                }

                else if (comboBox2.Text == "Fiat")
                {
                    comboBox3.Items.Clear();
                    string[] fiatvan = { "Doblo Cargo", "Doblo Combi", "Doblo Panorama", "e-Doblo Panorama", "Ducato", "Fiorino Cargo", "Fiorino Combi", "Fiorino Combi Mix", "Fiorino Panorama", "Scudo", "Ulysse", "Doblo Combi Mix", "Multipla", "Palio Van", "Panda Van" };
                    comboBox3.Items.AddRange(fiatvan);
                }

                else if (comboBox2.Text == "Ford")
                {
                    comboBox3.Items.Clear();
                    string[] fordvan = { "Tourneo Connect", "Tourneo Courier", "Tourneo Custom", "Transit", "Transit Connect", "Transit Courier", "Transit Custom", "E-Transit", "Fiesta Van" };
                    comboBox3.Items.AddRange(fordvan);
                }

                else if (comboBox2.Text == "Hyundai")
                {
                    comboBox3.Items.Clear();
                    string[] hyundaivan = { "H 100", "H 350", "H 1", "Starex", "Staria" };
                    comboBox3.Items.AddRange(hyundaivan);
                }

                else if (comboBox2.Text == "Mercedes-Benz")
                {
                    comboBox3.Items.Clear();
                    string[] mercedesvan = { "Citan", "EQV", "Sprinter Panel Van", "Vaneo", "V-Class", "Viano", "Vito", "Vito Mixto/Kombi", "Vito Tourer", "Vito Tourer Select" };
                    comboBox3.Items.AddRange(mercedesvan);
                }

                else if (comboBox2.Text == "Mitsubishi")
                {
                    comboBox3.Items.Clear();
                    string[] mitsubishivan = { "L 300" };
                    comboBox3.Items.AddRange(mitsubishivan);
                }

                else if (comboBox2.Text == "Opel")
                {
                    comboBox3.Items.Clear();
                    string[] opelvan = { "Combo", "Combo Cargo", "Combo Elektrik", "Combo Life", "Movano", "Vivaro", "Zafira Life", "Corsa Van" };
                    comboBox3.Items.AddRange(opelvan);
                }

                else if (comboBox2.Text == "Peugeot")
                {
                    comboBox3.Items.Clear();
                    string[] peugeotvan = { "Bipper", "Boxer", "Expert", "Expert Traveller", "Partner", "Rifter", "206 Van" };
                    comboBox3.Items.AddRange(peugeotvan);
                }

                else if (comboBox2.Text == "Renault")
                {
                    comboBox3.Items.Clear();
                    string[] renaultvan = { "Kangoo", "Kangoo E-Tech", "Kangoo Express", "Kangoo Multix", "Master", "Trafic", "Trafic Multix", "Express Combi", "Express Van" };
                    comboBox3.Items.AddRange(renaultvan);
                }

                else if (comboBox2.Text == "Toyota")
                {
                    comboBox3.Items.Clear();
                    string[] toyotavan = { "Hi-Ace", "Proace City", "Proace City Cargo" };
                    comboBox3.Items.AddRange(toyotavan);
                }

                else if (comboBox2.Text == "Volkswagen")
                {
                    comboBox3.Items.Clear();
                    string[] volkswagenvan = { "Caddy", "Caravelle", "Crafter", "Grand California", "ID. Buzz", "Multivan", "Transporter" };
                    comboBox3.Items.AddRange(volkswagenvan);
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool Mod = false;

            MessageBox.Show("CarMekan' a Hoşgeldiniz!");

            string[] aractipi = { "Otomobil", "Arazi, SUV & Pickup", "Minivan & Panelvan" };
            comboBox1.Items.AddRange(aractipi);
            string[] bakim = { "Ağır Bakım Yaptırmak İstiyorum", "Periyodik Bakım Yaptırmak İstiyorum", "10.000 Bakımı", "20.000 Bakımı", "30.000 Bakımı", "40.000 Bakımı", "50.000 Bakımı", "60.000 Bakımı", "70.000 Bakımı", "80.000 Bakımı", "90.000 Bakımı", "100.000 Bakımı" };
            comboBox6.Items.AddRange(bakim);
            string[] istek = { "Frenlerin kontrol edilmesi / balataların değişimi","Motor arızasının giderilmesi","Aracın titreme veya ses yapmasının kontrol edilmesi","Direksiyon sertliği / boşluğunun giderilmesi","Süspansiyon / amortisör kontrolü ve değişimi","Vites geçişlerinde sorun (otomatik / manuel)",
             "Egzozdan duman gelmesi (beyaz, mavi, siyah)","Far, sinyal, stop lambalarının kontrolü ve değişimi","Akü kontrolü ve gerekirse değişimi","Park sensörü çalışmıyor","Klima soğutmuyor / ısıtmıyor",    "Multimedya ekranı / geri görüş kamerası arızası","Merkezi kilit / cam açma mekanizması çalışmıyor",
             "İç detaylı temizlik","Ozonla koku giderme","Pasta cila","Seramik kaplama","Far temizliği","Cam filmi uygulaması","Ses sistemi montajı / kontrolü" };
            comboBox5.Items.AddRange(istek);
            comboBox6.Enabled = false;
            comboBox5.Enabled = false;
            string[] yakit = { "Benzin", "Benzin & LPG", "Dizel", "Hybrid", "Elektrik" };
            comboBox7.Items.AddRange(yakit);
            string[] vites = { "Manuel", "Otomatik", "Yarı Otomatik" };
            comboBox8.Items.AddRange(vites);
            string[] renk = { "Bej", "Beyaz", "Bordo", "Füme", "Gri", "Gümüş Gri", "Kahverengi", "Kırmızı", "Lacivert", "Mavi", "Mor", "Pembe", "Sarı", "Siyah", "Şampanya", "Turkuaz", "Turuncu", "Yeşil" };
            comboBox4.Items.AddRange(renk);
            string[] yil = { "2025", "2024", "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005" };
            comboBox9.Items.AddRange(yil);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Mod)
            {
                // Açık Moda Geç
                this.BackColor = Color.White;

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Name == "label49")
                    {
                        ctrl.ForeColor = Color.Red;
                        continue;
                    }

                    if (ctrl is Label || ctrl is GroupBox || ctrl is RadioButton || ctrl is CheckBox ||
                        ctrl is TextBox || ctrl is ComboBox || ctrl is ListBox || ctrl is Button)
                    {
                        ctrl.ForeColor = Color.Black;
                        ctrl.BackColor = Color.White;
                    }
                }

                Mod = false;
                button2.Text = "🌙";
            }
            else
            {
                // Koyu Moda Geç
                this.BackColor = Color.Black;

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Name == "label49")
                    {
                        ctrl.ForeColor = Color.Red;
                        continue;
                    }

                    if (ctrl is Label || ctrl is GroupBox || ctrl is RadioButton || ctrl is CheckBox ||
                        ctrl is TextBox || ctrl is ComboBox || ctrl is ListBox || ctrl is Button)
                    {
                        ctrl.ForeColor = Color.White;
                        ctrl.BackColor = Color.Black;
                    }
                }

                Mod = true;
                button2.Text = "🔆";
            }

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Otomobil")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                string[] otomobil = { "Alfa Romeo", "Audi", "BMW", "Chevrolet", "Citroen", "Dacia", "Fiat", "Ford", "Honda", "Hyundai", "Kia", "Mazda", "Mercedes-Benz", "Mitsubishi", "Nissan", "Opel", "Peugeot", "Porsche", "Renault", "Seat", "Skoda", "Subaru", "Suzuki", "Toyota", "Volkswagen", "Volvo" };
                comboBox2.Items.AddRange(otomobil);
            }

            else if (comboBox1.Text == "Arazi, SUV & Pickup")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                string[] suv = { "Alfa Romeo", "Audi", "BMW", "BYD", "Chery", "Chevrolet", "Citroen", "Dacia", "Fiat", "Ford", "Honda", "Hyundai", "Jeep", "Kia", "Land Rover", "Mazda", "Mercedes-Benz", "MG", "Mitsubishi", "Nissan", "Opel", "Peugeot", "Porsche", "Renault", "Seat", "Skoda", "Skywell", "SsangYong", "Subaru", "Suzuki", "TOGG", "Toyota", "Volkswagen", "Volvo" };
                comboBox2.Items.AddRange(suv);
            }

            else if (comboBox1.Text == "Minivan & Panelvan")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                string[] panelvan = { "Citroen", "Dacia", "Fiat", "Ford", "Hyundai", "Mercedes-Benz", "Mitsubishi", "Opel", "Peugeot", "Renault", "Toyota", "Volkswagen" };
                comboBox2.Items.AddRange(panelvan);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White; //Formun arka plan rengini beyaz yapar.

            foreach (Control ctrl in this.Controls) //Formun içindeki tüm kontrolleri (Label, Button, GroupBox vb.) sırayla dolaşır.
            {
                if (ctrl is Label || ctrl is GroupBox || ctrl is RadioButton || ctrl is CheckBox) //Eğer kontrol bir Label, GroupBox, RadioButton veya CheckBox ise, yani bu türlerden biri ise, bu bloğa girer.
                {
                    ctrl.ForeColor = Color.Black; //Yazı rengini siyah yapar.
                    ctrl.BackColor = Color.White; //Arka plan rengini beyaz yapar.
                }
            }
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox6.Enabled = checkBox1.Checked;
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox5.Enabled = checkBox2.Checked;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seçtiğiniz Randevu Tarihi Rezerve Edilmiştir.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked && string.IsNullOrWhiteSpace(comboBox5.SelectedItem?.ToString()))
            {
                MessageBox.Show("Lütfen istek türünü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkBox1.Checked && comboBox6.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bakım türünü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string telefon = textBox6.Text.Trim();

            if (telefon.Length < 10)
            {
                MessageBox.Show("Telefon numarası en az 10 karakter olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox6.Text = "";
            }
         
            label38.Text = textBox2.Text;
            label39.Text = textBox5.Text;
            label40.Text = textBox6.Text;
            label41.Text = textBox7.Text;
            label42.Text = label32.Text;
            label10.Text = comboBox1.Text;
            label11.Text = comboBox2.Text;
            label12.Text = comboBox3.Text;
            label27.Text = comboBox9.Text;
            label13.Text = textBox3.Text;
            label20.Text = textBox1.Text;
            label21.Text = textBox4.Text;
            label45.Text = comboBox7.Text;
            label47.Text = comboBox8.Text;
            label22.Text = comboBox4.Text;
            label24.Text = dateTimePicker1.Text;

            if (string.IsNullOrWhiteSpace(textBox2.Text) ||   // textbox ve labelların dolu olup olmadığını kontrol ediyoruz.
        string.IsNullOrWhiteSpace(textBox5.Text) ||
        string.IsNullOrWhiteSpace(textBox6.Text) ||
        string.IsNullOrWhiteSpace(textBox7.Text) ||
        string.IsNullOrWhiteSpace(label32.Text) ||
        string.IsNullOrWhiteSpace(textBox3.Text) ||
        string.IsNullOrWhiteSpace(textBox1.Text) ||
        string.IsNullOrWhiteSpace(textBox4.Text) ||
        comboBox1.SelectedIndex == -1 ||       // combobox içinde seçim yapılıp yapılmadığını kontrol ediyoruz.
        comboBox4.SelectedIndex == -1 ||
        comboBox2.SelectedIndex == -1 ||
        comboBox3.SelectedIndex == -1 ||
        comboBox9.SelectedIndex == -1 ||
        comboBox7.SelectedIndex == -1 ||
        comboBox8.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Bilgileriniz 'Servis Onay' bölümünde yer almaktadır. Lütfen bilgilerinizi kontrol edin ve randevunuzu onaylayın.");
                

            }
            ServisKaydi kayit = new ServisKaydi()
            {
                Ad = label38.Text,
                Soyad = label39.Text,
                Telefon = label40.Text,
                Eposta = label41.Text,
                MusteriNo = label42.Text,
                AracTipi = label10.Text,
                Marka = label11.Text,
                Model = label12.Text,
                Yil = label27.Text,
                Plaka = label13.Text,
                SasiNo = label20.Text,
                Kilometre = label21.Text,
                Yakit = label45.Text,
                Vites = label47.Text,
                Renk = label22.Text,
                RandevuTarihi = label24.Text,
            };

            // JSON dosyasını kontrol et ve listeyi oku
            List<ServisKaydi> kayitlar = new List<ServisKaydi>();
            string Proje = "servisler.json";

            if (File.Exists(Proje))
            {
                string jsonOnceki = File.ReadAllText(Proje);
                kayitlar = JsonConvert.DeserializeObject<List<ServisKaydi>>(jsonOnceki) ?? new List<ServisKaydi>();
            }

            // Yeni kaydı ekle
            kayitlar.Add(kayit);

            // JSON olarak tekrar kaydet
            string yeniJson = JsonConvert.SerializeObject(kayitlar, Formatting.Indented);
            string Algoritma = Path.Combine(Application.StartupPath, "servis_kayitlari.json");

            File.WriteAllText(Proje, yeniJson);

            MessageBox.Show("Servis kaydı başarıyla kaydedildi!");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||   // textbox ve labelların dolu olup olmadığını kontrol ediyoruz.
        string.IsNullOrWhiteSpace(textBox5.Text) ||
        string.IsNullOrWhiteSpace(textBox6.Text) ||
        string.IsNullOrWhiteSpace(textBox7.Text) ||
        string.IsNullOrWhiteSpace(label32.Text) ||
        string.IsNullOrWhiteSpace(textBox3.Text) ||
        string.IsNullOrWhiteSpace(textBox1.Text) ||
        string.IsNullOrWhiteSpace(textBox4.Text) ||
        comboBox1.SelectedIndex == -1 ||       // combobox içinde seçim yapılıp yapılmadığını kontrol ediyoruz.
        comboBox4.SelectedIndex == -1 ||
        comboBox2.SelectedIndex == -1 ||
        comboBox3.SelectedIndex == -1 ||
        comboBox9.SelectedIndex == -1 ||
        comboBox7.SelectedIndex == -1 ||
        comboBox8.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Servis randevunuz başarıyla onaylanmıştır. Bizi tercih ettiğiniz için teşekkür ederiz!");
                Close();
            }
            
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(10000,1000000);
            label32.Text = number.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string email = textBox7.Text;

            
            if (email.Length > 10 && !email.Contains("@") && !emailUyarisiVerildi)
            {
                MessageBox.Show("E-posta adresinde '@' işareti olmalıdır.");
                emailUyarisiVerildi = true; 
            }

            if (email.Contains("@"))
            {
                emailUyarisiVerildi = false;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox6.Text)) // textbox'ın boş olup olmadığını kontrol ediyoruz.
            {
                if (!long.TryParse(textBox6.Text, out _))   //girilen değerin sayı olup olmadığını kontrol ediyoruz.
                {
                    MessageBox.Show("Sadece sayı giriniz!");
                    textBox6.Clear();
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox4.Text)) // textbox'ın boş olup olmadığını kontrol ediyoruz.
            {
                if (!long.TryParse(textBox4.Text, out _))   //girilen değerin sayı olup olmadığını kontrol ediyoruz.
                {
                    MessageBox.Show("Sadece sayı giriniz!");
                    textBox4.Clear();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                if (int.TryParse(textBox2.Text, out _))
                {
                    MessageBox.Show("Sadece metin giriniz!");
                    textBox2.Clear();
                }
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox5.Text))
            {
                if (int.TryParse(textBox5.Text, out _))
                {
                    MessageBox.Show("Sadece metin giriniz!");
                    textBox5.Clear();
                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click_1(object sender, EventArgs e)
        {

        }
    }
}
