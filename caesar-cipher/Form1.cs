using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace caesar_cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private static char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
                return ch;

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - offset) % 26) + offset);
        }

        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += Cipher(ch, key);

            return output;
        }

        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_plain_text.Text))
            {
                MessageBox.Show("please enter plaint text to encrypt!");
                txt_plain_text.Focus();

                return;

            }

            if (string.IsNullOrEmpty(txt_shift.Text ))
            {
                MessageBox.Show("please enter shift value");
                txt_shift.Focus();
                return;

            }
            txt_encrypted_text.Text  = Encipher(txt_plain_text.Text , Convert.ToInt32(txt_shift.Text) );
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            txt_decrypted_text.Text = Decipher(txt_encrypted_text.Text, Convert.ToInt32(txt_shift.Text));
        }
    }
}
