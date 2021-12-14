using System;
using System.Windows.Forms;

namespace Notebook
{
    public partial class ActivityForm : Form
    {
        public NoteMaker Maker;
        public int Index;
        
        public ActivityForm(NoteMaker Maker, int index)
        {
            this.Maker = Maker;
            Index = index;
            InitializeComponent();
            FillData();
        }

        public void FillData()
        {
            txt_Name.Text = Maker.noteBook.notes[Index].NoteName;
            txt_Text.Text = Maker.noteBook.notes[Index].NoteText;
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Name.Text) || String.IsNullOrWhiteSpace(txt_Text.Text))
            {
                MessageBox.Show("You have to enter name and text for a note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Maker.AddUpdateNote(txt_Name.Text, txt_Text.Text, Index);
        }

        private void btn_CloseDetail_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Maker.DeleteNote(Index);
            Close();
        }
    }
}