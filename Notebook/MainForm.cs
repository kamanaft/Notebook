using System;
using System.Windows.Forms;

namespace Notebook
{
    public partial class Form1 : Form
    {
        public NoteMaker Maker;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text) || String.IsNullOrWhiteSpace(txtText.Text))
            {
                MessageBox.Show("You have to enter name and text for a note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Maker.AddUpdateNote(txtName.Text, txtText.Text);
            UpdateList();
            ClearInput();
        }

        public void UpdateList()
        {
            listNotes.Items.Clear();
            foreach (var note in Maker.noteBook.notes)
            {
                listNotes.Items.Add(note.ToString());
            }
        }

        public void ClearInput()
        {
            txtName.Text = "";
            txtText.Text = "";
        }

        private void listNotes_DoubleClick(object sender, EventArgs e)
        {
            if (listNotes.SelectedItem != null)
            {
                var newFrm = new ActivityForm(Maker, listNotes.SelectedIndex);
                newFrm.Closed += delegate
                {
                    UpdateList();
                };
                newFrm.Show();
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (listNotes.SelectedIndex < 0)
            {
                MessageBox.Show("Choose note to delete.", "Error during deleting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Maker.DeleteNote(listNotes.SelectedIndex);
            UpdateList();
        }

        private void ReadExistingData()
        {
            var result = Maker.ReadBook();
            var message = result ? "Data uploaded. Let's go!" : "Data wasn't found.";
            if(result)
                UpdateList();
            MessageBox.Show(message, "Data loading", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormLoad(object sender, EventArgs e)
        {
            Maker = new NoteMaker();
            ReadExistingData();
        }

        private void NoteClosed(object sender, FormClosedEventArgs e)
        {
            Maker.SaveXml(Maker.noteBook);
        }

        private void txt_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void listNotes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}