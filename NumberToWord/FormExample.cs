using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NumberToWord
{
    public partial class FormExample : Form
    {
        public FormExample()
        {
            InitializeComponent();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            toword();
        }
        private void cboCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            toword();
        }

        private void toword()
        {
            IFormater formater = new GradeFormater();
            if (cboCurrency.SelectedIndex == 1)
                formater = new GrammFormater();

            try
            {
                txtArabicWord.Text = ToWord.ToArabic(long.Parse(txtNumber.Text), formater);
            }
            catch (Exception ex)
            {
                txtArabicWord.Text = ex.Message;
            }
        }
    }
}
