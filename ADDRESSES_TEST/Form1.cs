using System;
using System.Data;
using System.Windows.Forms;


namespace ADDRESSES_TEST
{

    public partial class Form1 : Form
    {
        ServiceReference1.UPDVServiceSoapClient client = new ServiceReference1.UPDVServiceSoapClient();
        ServiceReference1.AuthHeader authHeader = new ServiceReference1.AuthHeader();
       
        
        DataSet DS = new DataSet();
        DataTable DT = new DataTable();
        public Form1()
        {
            InitializeComponent();
            authHeader.UserName = "audriussi";
            authHeader.PostID = "12020";
            authHeader.PC = "06";
            authHeader.IP = "fe80::c83d:cb90:5d4f:716e%11";
            authHeader.HostName = "VACP1202006";
            authHeader.Source = "GUI";
            authHeader.Acsess_MD5 = Convert.FromBase64String("UgK/r/FipxNFzA893hlApA==");
            authHeader.Version = "1.6.4.5";
            authHeader.Compression = "NOZIP";
            client.Open();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Select();
           
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            
            // SqlCommand command = new SqlCommand();
            //command.Parameters.Add("@ID", SqlDbType.Bit);
            //command.Parameters["@ID"].Value = true;

            //DS = client.ReturnDataSetFromServer(authHeader, QUERY.GetMailID(textBox1.Lines[0].ToString()),1);
            //DS = client.ReturnDataSetFromServer(authHeader, QUERY.UPDV_SYSTEM_ONLINE_USERS("jbraziuniene"), 1);
           //DS = client.ReturnDataSetFromServer(authHeader, QUERY.PR_BKIS_GET_OUTDATED_MAILS_LIST("7121","678","16218","1","0"), 1);
          // DS = client.ReturnDataSet(authHeader, Address.PR_BKIS_ADDRESS_STREET_FILTER_BAK_20191028(44,textBox3.Text,textBox4.Text));
            DS = client.ReturnDataSet(authHeader, Address.Vnl_26_adresai());

           // DS = client.ReturnDataSetFromServer(authHeader, QUERY.LP_ADR_KLSF_LOCALITY_TYPES(),1);
           
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;

            foreach (DataTable item in DS.Tables)
            {
                comboBox1.Items.Add(item.TableName);
            }
            comboBox1.SelectedIndex = 0;
            label1.Text = label1.Text + DS.Tables.Count.ToString();
        
            comboBox3.DataSource = DT;
            comboBox3.DisplayMember = "street_name";
            comboBox3.ValueMember = "street_id";
            comboBox3.AutoCompleteSource = AutoCompleteSource.CustomSource;
           //GITHub
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DS.Tables[comboBox1.Text];
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
