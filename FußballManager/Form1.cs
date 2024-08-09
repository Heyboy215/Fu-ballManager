using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace FußballManager
{
    public partial class Form1 : Form
    {
        List<Spieler> spielerList;

        string tmpfilepath;

        public Form1()
        {
            spielerList = new List<Spieler>();
            InitializeComponent();
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HinzuButton_Click(object sender, EventArgs e)
        {
            bool foundPlayer = spielerList.Find(spieler => spieler.Spielername == PlayerInput.Text) != null;

            if (foundPlayer) 
            {
                PlayerInput.Text = null;
                StaatsangehörigkeitInput.Text = null;
                GeburtstagInput.Text = null;
                GeburtsortInput.Text = null;
                PositionInput.Text = null;
                AlterInput.Text = null;
                GrößeInput.Text = null;
                MannschaftInput.Text = null;
                TransferwertInput.Text = null;
                AktNationalspielerInput.Text = null;
                LänderspieleToreInput.Text = null;

                MessageBox.Show("Dieser Spieler existiert schon!", "Fehler 409");
            }
            else 
            { 
                PlayerList.Items.Add(PlayerInput.Text);

                int Alter;
                int.TryParse(AlterInput.Text, out Alter);

                Spieler spieler = new Spieler(MannschaftInput.Text, PlayerInput.Text, StaatsangehörigkeitInput.Text, GeburtstagInput.Text, GeburtsortInput.Text, Alter, GrößeInput.Text, PositionInput.Text, TransferwertInput.Text, AktNationalspielerInput.Text, LänderspieleToreInput.Text);
            
                if (tmpfilepath != null )
                {
                    spieler.filepath = tmpfilepath;
                    tmpfilepath = null;
                }

                spielerList.Add(spieler);
    
                PlayerInput.Text = null;
                StaatsangehörigkeitInput.Text = null;
                GeburtstagInput.Text = null;
                GeburtsortInput.Text = null;
                PositionInput.Text = null;
                AlterInput.Text = null;
                GrößeInput.Text = null;
                MannschaftInput.Text = null;
                TransferwertInput.Text = null;
                AktNationalspielerInput.Text = null;
                LänderspieleToreInput.Text = null;
            }

        }

        private void PlayerInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                HinzuButton_Click(sender, e);
                SpeicherButton_KeyPress(sender, e);
            }
        }

        private void PlayerInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PlayerList_SelectedValueChanged(object sender, EventArgs e)
        {
            string spielerName = PlayerList.SelectedItem?.ToString();

            if (spielerName != null)
            {
                Spieler spieler = spielerList.Find(spieler => spieler.Spielername == spielerName);

                Mannschaftsname.Text = spieler.Mannschaftsname;
                Spielername.Text = spieler.Spielername;
                Staatsangehörigkeit.Text = spieler.Staatsangehörigkeit;
                Geburtstag.Text = spieler.Geburtstag;
                Geburtsort.Text = spieler.Geburtsort;
                Alter.Text = spieler.Alter.ToString();
                Größe.Text = spieler.Größe;
                Position.Text = spieler.Position;
                Transferwert.Text = spieler.Transferwert;
                AktNationalspieler.Text = spieler.AktNationalspieler;
                LänderspieleTore.Text = spieler.LänderspieleTore;

                if (spieler.filepath != null)
                {
                    pictureBox1.Image = new Bitmap(spieler.filepath);
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void AlterInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void PositionInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void MannschaftInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                HinzuButton_Click(sender, e);
                SpeicherButton_KeyPress(sender, e);
            }
        }

        private void AlterInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                HinzuButton_Click(sender, e);
                SpeicherButton_KeyPress(sender, e);
            }
        }

        private void PositionInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                HinzuButton_Click(sender, e);
                SpeicherButton_KeyPress(sender, e);
            }
        }

        private void LöschenButton_Click(object sender, EventArgs e)
        {
            spielerList.Remove(spielerList.Find(spieler => spieler.Spielername == PlayerList.SelectedItem.ToString()));
            PlayerList.Items.Remove(PlayerList.SelectedItem);
            Mannschaftsname.Text = null;
            Spielername.Text = null;
            Staatsangehörigkeit.Text = null;
            Geburtstag.Text = null;
            Geburtsort.Text = null;
            Alter.Text = null;
            Größe.Text = null;
            Position.Text = null;
            Transferwert.Text = null;
            AktNationalspieler.Text = null;
            LänderspieleTore.Text = null;

            SpeicherButton_Click(sender, e);
        }

        private void PlayerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SpeicherButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter stream = new StreamWriter("Spielerdaten.json"))
            {
                using (JsonTextWriter writer = new JsonTextWriter(stream))
                {
                    var json = JsonConvert.SerializeObject(spielerList);
                    writer.WriteRaw(json);
                }
            }
        }

        private void LoadData()
        {
            using (StreamReader stream = new StreamReader("Spielerdaten.json"))
            {
                using (JsonTextReader reader = new JsonTextReader(stream))
                {
                    string json = stream.ReadToEnd();
                    if (json != string.Empty)
                    {
                        spielerList = JsonConvert.DeserializeObject<List<Spieler>>(json);
                    }
                }
            }

            foreach (Spieler spieler in spielerList)
            {
                PlayerList.Items.Add(spieler.Spielername);
            }
        }

        private void BearbeitenButton_Click(object sender, EventArgs e)
        {
            string spielerName = PlayerList.SelectedItem?.ToString();

            if (spielerName != null)
            {
                Spieler spieler = spielerList.Find(spieler => spieler.Spielername == spielerName);

                MannschaftInput.Text = spieler.Mannschaftsname;
                PlayerInput.Text = spieler.Spielername;
                StaatsangehörigkeitInput.Text = spieler.Staatsangehörigkeit;
                GeburtstagInput.Text = spieler.Geburtstag;
                GeburtsortInput.Text = spieler.Geburtsort;
                AlterInput.Text = spieler.Alter.ToString();
                GrößeInput.Text = spieler.Größe;
                PositionInput.Text = spieler.Position;
                TransferwertInput.Text = spieler.Transferwert;
                AktNationalspielerInput.Text = spieler.AktNationalspieler;
                LänderspieleToreInput.Text = spieler.LänderspieleTore;

                this.tmpfilepath = spieler.filepath;

                LöschenButton_Click(sender, e);
            }
        }

        private void SpeicherButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SpeicherButton_Click(sender, e);
            }
        }

        private void TransferwertInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransferwertInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                HinzuButton_Click(sender, e);
                SpeicherButton_KeyPress(sender, e);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void GrößeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                HinzuButton_Click(sender, e);
                SpeicherButton_KeyPress(sender, e);
            }
        }

        private void LänderspieleToreInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                HinzuButton_Click(sender, e);
                SpeicherButton_KeyPress(sender, e);
            }

        }

        private void GrößeInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BildHochladen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = openFileDialog.FileName;

                    pictureBox1.Image = new Bitmap(sourceFilePath);

                    string targetFolder = Path.Combine(Application.StartupPath, "UploadedImages");

                    if (!Directory.Exists(targetFolder))
                    {
                        Directory.CreateDirectory(targetFolder);
                    }

                    string fileName = Path.GetFileName(sourceFilePath);
                    string targetFilePath = Path.Combine(targetFolder, fileName);

                    File.Copy(sourceFilePath, targetFilePath, true);

                    string spielerName = PlayerList.SelectedItem?.ToString();

                    if (spielerName != null)
                    {
                        Spieler spieler = spielerList.Find(spieler => spieler.Spielername == spielerName);
                        spieler.filepath = targetFilePath;

                        SpeicherButton_Click(sender, e);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StaatsangehörigkeitInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                HinzuButton_Click(sender, e);
                SpeicherButton_KeyPress(sender, e);
            }
        }

        private void GeburtstagInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                HinzuButton_Click(sender, e);
                SpeicherButton_KeyPress(sender, e);
            }
        }

        private void GeburtsortInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
            HinzuButton_Click(sender, e);
            SpeicherButton_KeyPress(sender, e);
            }
        }

        private void AktNationalspielerInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                HinzuButton_Click(sender, e);
                SpeicherButton_KeyPress(sender, e);
            }
        }
    }
}