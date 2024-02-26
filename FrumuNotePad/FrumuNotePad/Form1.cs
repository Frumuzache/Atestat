namespace FrumuNotePad
{
    public partial class formMain : Form
    {
        string OurFileName;
        string LastFindWord;
        bool LastFindDown;
        bool LastFindMatchCase;

        public formMain()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        bool CheckChanges()
        {
            return true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckChanges())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox.LoadFile(openFileDialog1.FileName);
                }
            }
        }

        void DoSave(string filename)
        {
            OurFileName = filename;
            textBox.SaveFile(filename);
        }

        void DoSaveAs()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DoSave(saveFileDialog1.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OurFileName))
            {
                DoSaveAs();
            }
            else
            {
                DoSave(OurFileName);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFind find = new formFind();
            find.Show(this);
        }

        public void DoFind (string search, bool down, bool match_case)
        {
            LastFindWord = search;
            LastFindDown = down;
            LastFindMatchCase = match_case;     

            if (down)
            {
                if (match_case)
                    textBox.Find(search, textBox.SelectionStart + 1, RichTextBoxFinds.MatchCase);
                else
                    textBox.Find(search, textBox.SelectionStart + 1, RichTextBoxFinds.None);
            }
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            formMain parent_form = (formMain)Owner;
            parent_form.DoFind(textFindWhat.Text, rdoDown.Checked, chkMatchCase.Checked);
            */
        }
    }
}
