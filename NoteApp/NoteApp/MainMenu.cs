using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static NoteApp.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoteApp
{
    public partial class MainMenu : Form
    {
        //list with NoteBook objects
        private static NoteBooks NoteBookData = new NoteBooks();

        private const string FilePath = "NoteAppData.json";


        public MainMenu()
        {
            InitializeComponent();
            var collection = LoadData();
            NoteBookData.ListNoteBooks = collection;
            PopulateListDropDown();
            this.FormClosing += SaveData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("PLease enter the name of the Note Book");
                return;
            }


            if (ListsDropDown.Items != null)
            {

                foreach (string notebook in ListsDropDown.Items)
                {
                    if (textBox1.Text == notebook)
                    {
                        MessageBox.Show("Note Book already excites");
                        textBox1.Text = null;
                        return;
                    }
                }
            }
            else
            {
                return;
            }

            NoteBook noteBook = new NoteBook(textBox1.Text);
            NoteBookData.ListNoteBooks.Add(noteBook);


            ListsDropDown.Items.Add(noteBook.Name);

            ListsDropDown.Text = textBox1.Text;
            textBox1.Text = null;

        }

        private void button3_Click(object sender, EventArgs e)
        //I have made feature from the bag(when you press select it can create new note book automatically)
        {
            if (ListsDropDown.Text == "")
            {
                MessageBox.Show("PLease create the note");
                return;
            }

            var noteBook = NoteBookData.ListNoteBooks.Where(noteBook => noteBook.Name == ListsDropDown.Text).First();


            var editForm = new Form1(noteBook);
            var response = editForm.ShowDialog();

        }

        private void SaveData(object sender, FormClosingEventArgs e)
        {
            try
            {
                string json = JsonSerializer.Serialize(NoteBookData.ListNoteBooks, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}");
            }
        }
        private List<NoteBook> LoadData()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    return JsonSerializer.Deserialize<List<NoteBook>>(json) ?? new List<NoteBook>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
            return new List<NoteBook>();

        }

        private void PopulateListDropDown()
        {
            ListsDropDown.Items.Clear();

            foreach (var noteBook in NoteBookData.ListNoteBooks)
            {
                ListsDropDown.Items.Add(noteBook.Name);
            }
        }

        private void ClearTheList(object sender, EventArgs e)
        {
            ListsDropDown.Items.Clear();
            NoteBookData.ListNoteBooks.Clear();
        }
        
        private void DeleteNoteBook(object sender, EventArgs e)
        {
            var noteBookToRemove = NoteBookData.ListNoteBooks
                .FirstOrDefault(noteBook => noteBook.Name == deleteListText.Text);

            if (noteBookToRemove != null)
            {
                NoteBookData.ListNoteBooks.Remove(noteBookToRemove);
                ListsDropDown.Items.Remove(noteBook);
            }
        }
    }
}
