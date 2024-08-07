using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;

namespace FußballManager
{
    public partial class Form1 : Form
    {
        List<Spieler> spielerList;

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
            PlayerList.Items.Add(PlayerInput.Text);

            int alter;
            int.TryParse(AlterInput.Text, out alter);

            Spieler spieler = new Spieler(MannschaftInput.Text, PlayerInput.Text, alter, PositionInput.Text);
            spielerList.Add(spieler);

            PlayerInput.Text = null;
            PositionInput.Text = null;
            AlterInput.Text = null;
            MannschaftInput.Text = null;
        }

        private void PlayerInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                HinzuButton_Click(sender, e);
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
                Alter.Text = spieler.Alter.ToString();
                Position.Text = spieler.Position;
            }
        }

        private void MannschaftInput_TextChanged(object sender, EventArgs e)
        {

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
            }
        }

        private void AlterInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                HinzuButton_Click(sender, e);
            }
        }

        private void PositionInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                HinzuButton_Click(sender, e);
            }
        }

        private void LöschenButton_Click(object sender, EventArgs e)
        {
            spielerList.Remove(spielerList.Find(spieler => spieler.Spielername == PlayerList.SelectedItem.ToString()));
            PlayerList.Items.Remove(PlayerList.SelectedItem);
            Mannschaftsname.Text = null;
            Spielername.Text = null;
            Alter.Text = null;
            Position.Text = null;
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
                AlterInput.Text = spieler.Alter.ToString();
                PositionInput.Text = spieler.Position;

                LöschenButton_Click(sender, e);
            }
        }
    }
}