using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace IndirizziIP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //questo metodo controlla se ogni parte dell'indirizzo ip è compresa nel range adeguato, in ingresso vuole l'indirizzo in decimale già splittato
        public bool IsInRange(string[] indirizzoSplittato)
        {
            bool inRange = false;
            for(int i=0;i<4;i++)
            {
                if(Convert.ToInt32(indirizzoSplittato[i])<256&&Convert.ToInt32(indirizzoSplittato[i])>=0)
                {
                    inRange = true;
                }
                else
                {
                    inRange = false;
                    break;
                }
            }
            return inRange;
        }
        public int BinDecimale(string binario)
        {
            int dec = Convert.ToInt32(binario, 2);
            return dec;
        }
        public string DecimaleBin(int decimale)
        {
            string bin = Convert.ToString(decimale, 2);
            return bin;
        }
        //questo metodo fa in modo che una stringa abbia una determinata lunghezza, aggiungendo da sinistra il carattere specificato.
        public string CompletaDaSinistra(string daCompletare, int numeroCaratteri, char daAggiungere)
        {
            if (daCompletare.Length < numeroCaratteri)
            {
                while (daCompletare.Length != numeroCaratteri)
                     daCompletare = daAggiungere + daCompletare;
            }
            return daCompletare;
        }
        private void btnVai_Click(object sender, EventArgs e)
        {
            //dichiaro e/o inizializzo tutte le varibili che mi serviranno e pulisco textbox e label che indica la classe dell'indirizzo.
            string[] IpSplitDec, SubSplitDec, IndirizzoSplitBin;            
            string[] IpSplitBin = new string[4];
            string[] SubSplitBin = new string[4];
            bool inRange;
            string indirizzoBin = "";
            txtIPBin.Text = "";
            txtIndirizzo.Text = "";
            txtIndirizzoBin.Text = "";
            txtSubMask.Text = "";
            txtSubBin.Text = "";
            txtIPBin.Text = "";
            lblClasse.Text = "";
            //tutto in try catch per evitare possibili erorri dell'utente.    
            try
            {
                //splitto l'indirizzo inserito dall'utente e successivamente lo controllo per verificare che sia correttamente nel range.
                IpSplitDec = cmbIP.Text.Split('.');
                inRange = IsInRange(IpSplitDec);
                //solo se è nel range continuo
                if (inRange)
                {
                    //qui converto l'indirizzo da decimale a binario, mi serve un for perchè è splittato in 4 parti.
                    for (int i = 0; i < 4; i++)
                    {
                        IpSplitBin[i] = DecimaleBin(Convert.ToInt32(IpSplitDec[i]));
                        IpSplitBin[i] = CompletaDaSinistra(IpSplitBin[i], 8, '0');
                        txtIPBin.Text += IpSplitBin[i];
                        //qui inserisco i punti tra una sezione e l'altra
                        if (i != 3)
                        {
                            txtIPBin.Text += ".";
                        }
                    }
                    //qui controllo il primo byte dell'indirizzo per determinare la classe di appartenenza
                    int primoByte = Convert.ToInt32(IpSplitDec[0]);
                    if (primoByte >= 0 && primoByte < 128)
                    {                        
                        txtSubMask.Text = "255.0.0.0";
                        lblClasse.Text = "A";                        
                    }
                    if (primoByte > 127 && primoByte < 192)
                    {                        
                        txtSubMask.Text = "255.255.0.0";
                        lblClasse.Text = "B";                        
                    }
                    if (primoByte > 191 && primoByte < 224)
                    {                        
                        txtSubMask.Text = "255.255.255.0";
                        lblClasse.Text = "C";                        
                    }
                    if (primoByte > 223 && primoByte < 256)
                    {                        
                        txtSubMask.Text = "255.255.255.255";
                        lblClasse.Text = "D";                        
                    }
                    //Ora splitto la subnet mask appena creata in modo da poterla convertire come fatto con l'indirizzo ip.
                    SubSplitDec = txtSubMask.Text.Split('.');
                    //Converto, il procedimento è come sopra.
                    for (int i = 0; i < 4; i++)
                    {
                        SubSplitBin[i] = DecimaleBin(Convert.ToInt32(SubSplitDec[i]));
                        SubSplitBin[i] = CompletaDaSinistra(SubSplitBin[i], 8, '0');
                        txtSubBin.Text += SubSplitBin[i];
                        if (i != 3)
                        {
                            txtSubBin.Text += ".";
                        }
                    }
                    //AND bit a bit tra l'indirizzo e la subnet mask, ottengo quindi l'indirizzo della rete.
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (IpSplitBin[i].Substring(j, 1) == "1" && IpSplitBin[i].Substring(j, 1) == SubSplitBin[i].Substring(j, 1))
                            {
                                indirizzoBin += 1;
                            }
                            else
                            {
                                indirizzoBin += 0;
                            }
                        }
                        if (i != 3)
                        {
                            indirizzoBin += ".";
                        }
                    }
                    //stampo l'indirizzo di rete in binario, poi lo splitto e lo converto in decimale.
                    txtIndirizzoBin.Text = indirizzoBin;
                    IndirizzoSplitBin = indirizzoBin.Split('.');
                    for (int i = 0; i < 4; i++)
                    {
                        //mano a mano che converto una sezione la stampo.
                        txtIndirizzo.Text += BinDecimale(IndirizzoSplitBin[i]).ToString();
                        if (i != 3)
                        {
                            txtIndirizzo.Text += ".";
                        }
                    }
                }
                else
                {
                    //qui notifico all'utente che ha inserito un ip non valido
                    MessageBox.Show("Attenzione: Indirizzo IP non nel range 0-255\nControlla di non aver commesso errori.","IP Non Valido");
                }
            }
            catch(Exception)
            {
                //qui notifico un errore nel formato, che può essere: lettere al posto di numeri, indirizzo non costituito da 4 sezioni che comprota fallimento del metodo di controllo lunghezza.
                MessageBox.Show("Controlla i dati inseriti:\nL'indirizzo ip deve essere in formato IPv4\n", "Errore del Formato");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //popolo la combo con gli indirizzi ip delle interfacce locali
            string hostname;
            hostname = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(hostname);
            IPAddress[] addresses = ipEntry.AddressList;
            for (int i = 0; i < addresses.Length; i++)
            {
                string address = addresses[i].ToString();
                //non voglio che vengano caricati indirizzi ipv6 che non sono gestiti dal programma
                if(address.Length<16)
                    cmbIP.Items.Add(address);
            }
        }
    }
}
