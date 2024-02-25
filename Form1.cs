using System.Runtime.Intrinsics.Arm;

namespace Item_move_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmoveright_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Add(listBox1.SelectedItems);
                int i = 0;
                i = listBox1.SelectedIndex;
                listBox1.Items.Remove(i);
            }
            catch { }
        }

        private void btnmoveleft_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add(listBox2.SelectedItems);
                int i = 0;
                i = listBox2.SelectedIndex;
                listBox2.Items.Remove(i);
            }
            catch { }
        }

        private void btnmultiright_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
            }
            foreach (int rem = listBox1.SelectedItems.Count - 1; rem = 0; rem--)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[rem]);
            }
        }

        private void btnmultileft_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox2.SelectedItems)
            {
                listBox1.Items.Add(item);
            }
            foreach (int rem = listBox2.SelectedItems.Count - 1; rem = 0; rem--)
            {
                listBox2.Items.Remove(listBox2.SelectedItems[rem]);
            }
        }

        private void btnmoveallright_Click(object sender, EventArgs e)
        {
            while (listBox1.Items.Count != 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                    listBox1.Items.Remove(listBox1.Items[i]);
                }
            }
        }

        private void btnmoveallleft_Click(object sender, EventArgs e)
        {
            while (listBox2.Items.Count != 0)
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox1.Items.Add(listBox2.Items[i]);
                    listBox2.Items.Remove(listBox2.Items[i]);
                }
            }
        }
    }
}
