using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmadeiNicola_Sottoreti
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public bool IsInRange(string[] indirizzoSplittato)
        {
            bool inRange = false;
            for (int i = 0; i < 4; i++)
            {
                if (Convert.ToInt32(indirizzoSplittato[i]) < 256 && Convert.ToInt32(indirizzoSplittato[i]) >= 0)
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

        public string CompletaDaDestra(string daCompletare, int numeroCaratteri, char daAggiungere)
        {
            if (daCompletare.Length < numeroCaratteri)
            {
                while (daCompletare.Length != numeroCaratteri)
                    daCompletare += daAggiungere;
            }
            return daCompletare;
        }

        private void btnVai_Click(object sender, EventArgs e)
        {
            bool inRange;
            string IpBinLast = "";
            
            int esponente = 0;
            try
            {
                string[] IpSplitDec = txtIP.Text.Split('.');
                string tBit, tInd;
                inRange = IsInRange(IpSplitDec);
                //solo se è nel range continuo
                if (inRange)
                {                
                    //metodo senza usare logaritmi
                    int bitNecessari = DecimaleBin(Convert.ToInt32(nudReti.Value)).Length;
                    IpBinLast = CompletaDaSinistra(IpBinLast, 8 - esponente, '0');
                    
                    dgvDati.Rows.Clear();
                    for (int i = 0; i < Convert.ToInt32(nudReti.Value); i++)
                    {
                        dgvDati.Rows.Add();
                        dgvDati.Rows[i].Cells[0].Value = i;
                        tBit = DecimaleBin(i);
                        tBit = CompletaDaSinistra(tBit, bitNecessari, '0');
                        tInd = tBit;
                        tInd = CompletaDaDestra(tInd, 8, '0');
                        dgvDati.Rows[i].Cells[1].Value = IpSplitDec[0] + "." + IpSplitDec[1] + "." + IpSplitDec[2] + "." + BinDecimale(tInd);
                        dgvDati.Rows[i].Cells[3].Value = IpSplitDec[0] + "." + IpSplitDec[1] + "." + IpSplitDec[2] + "." + (BinDecimale(tInd) + 1);
                        tInd = tBit;
                        tInd = CompletaDaDestra(tInd, 8, '1');
                        dgvDati.Rows[i].Cells[2].Value = IpSplitDec[0] + "." + IpSplitDec[1] + "." + IpSplitDec[2] + "." + BinDecimale(tInd);
                        dgvDati.Rows[i].Cells[3].Value += " - "+IpSplitDec[0] + "." + IpSplitDec[1] + "." + IpSplitDec[2] + "." + (BinDecimale(tInd) -1);
                        dgvDati.Rows[i].Cells[3].Value = dgvDati.Rows[i].Cells[1].Value + " - " + dgvDati.Rows[i].Cells[2].Value;
                    }
                }
                else
                {
                    //qui notifico all'utente che ha inserito un ip non valido
                    MessageBox.Show("Attenzione: Indirizzo IP non nel range 0-255\nControlla di non aver commesso errori.", "IP Non Valido");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Errore di inserimento", "Qualcosa non va...");
            }
        }
    }
}
