using System.Text.Json;
using static NoteApp.MainMenu;


namespace NoteApp
{
    public partial class Form1 : Form
    {
        public NoteBook NoteBook { get; set; }

        public Form1(NoteBook noteBook)
        {
            NoteBook = noteBook;

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.KeyDown += new KeyEventHandler(KeyDownEnter);
            this.KeyPreview = true;

            if (noteBook.Notes != null)
            {
                for (int i = 0; i < noteBook.Notes.Count; i++)
                {
                    checkedListBox1.Items.Add(noteBook.Notes[i]);
                }
            }
        }

        private void Submit(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please ebter the note");
                return;
            }

            checkedListBox1.Items.Add(textBox1.Text);

            string a = textBox1.Text;

            if (NoteBook.Notes is null)
            {
                NoteBook.Notes = new();
            }
            NoteBook.Notes.Add(a);

            textBox1.Text = null;
        }

        //Key handler for Submit button
        private void KeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();

                e.SuppressKeyPress = true;
            }
        }
        private void ClearList(object sender, EventArgs e)
        {

            if (checkedListBox1.Items.Count == 0)
            {

            }
            else
            {
                checkedListBox1.Items.Clear();
                NoteBook.Notes.Clear();
            }

        }

        private void AddNote(object sender, EventArgs e)
        {

        }

        public void Notes(object sender, EventArgs e)
        {

        }

        private void DeleteAll(object sender, EventArgs e)
        {
            var noteBook = NoteBook;

            if (checkedListBox1.CheckedItems.Count != 0)
            {

                foreach (var item in checkedListBox1.CheckedItems.OfType<string>().ToList())
                {
                    checkedListBox1.Items.Remove(item);
                    noteBook.Notes.Remove(item);
                }

            }
        }

        private void SaveButton(object sender, EventArgs e) => this.Close();
        
    }
}

