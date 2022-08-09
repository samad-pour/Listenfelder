namespace Listenfelder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_to_right_Click(object sender, EventArgs e)
        {
            foreach (string word in lst_left.SelectedItems)
            { 
                lst_right.Items.Insert(0, word);
            }

            while (lst_left.SelectedItems.Count > 0)
            {
                lst_left.Items.Remove(lst_left.SelectedItems[0]);
            }
        }

        private void btn_to_left_Click(object sender, EventArgs e)
        {
            foreach (string word in lst_right.SelectedItems)
            {
                lst_left.Items.Insert(0, word);
            }

            while (lst_right.SelectedItems.Count > 0)
            {
                lst_right.Items.Remove(lst_right.SelectedItems[0]);
            }
        }
    }
}