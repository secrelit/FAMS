using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UILayerAttendanceManagementSystem
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            
            InitializeComponent();
            dataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView1_CellDoubleClick);
            dataGridView1.MouseDown += new MouseEventHandler(dataGridView1_MouseDown);

            //SetBounds(5, 175, Screen.PrimaryScreen.WorkingArea.Width-18, Screen.PrimaryScreen.WorkingArea.Height-240);
            
            //dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            //dataGridView1.MouseDown += new MouseEventHandler(dataGridView1_MouseDown);
        }

        void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        
       
        private void HighlightCell(int row, int column)
        {
            //light orange = 255,192,128
            //dark orange = 192,64,0
            if (row != -1 && column != -1)
            {
                dataGridView1[column, row].Style.ForeColor = Color.FromArgb(255, 255, 255);
                dataGridView1[column, row].Style.BackColor = Color.FromArgb(192, 64, 0);
            }
        }

        private void UndoHighlightCell(int row, int column)
        {
            //light orange = 255,192,128
            //dark orange = 192,64,0
            dataGridView1[column, row].Style.ForeColor = Color.FromArgb(192, 64, 0);
            dataGridView1[column, row].Style.BackColor = Color.FromArgb(255, 192, 128);
        }

        private void HideAllRows(int exceptRow)
        {
            if (exceptRow == -1)
                return;

            for(int i=0;i<exceptRow;i++)
                dataGridView1.Rows[i].Visible = false;

            for (int i = exceptRow + 1; i < dataGridView1.Rows.Count-1; i++)
                dataGridView1.Rows[i].Visible = false;
        }

        private void UnHideAllRows(int exceptRow)
        {
            if (exceptRow == -1)
                return;
            
            for (int i = 0; i < exceptRow; i++)
            {
                dataGridView1.Rows[i].Visible = true;
            }

            for (int i = exceptRow + 1; i < dataGridView1.Rows.Count-1; i++)
                dataGridView1.Rows[i].Visible = true;
        }

        void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int selectedRow = e.RowIndex;
            if (selectedRow == -1)
                return;

            //dataGridView1[e.ColumnIndex, e.RowIndex].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Green;
            HighlightCell(e.RowIndex, e.ColumnIndex);
            HideAllRows(e.RowIndex);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Refresh();

            String staffName = dataGridView1["staffNameColumn", selectedRow].Value.ToString();
            String dateCategory = dataGridView1.Columns[e.ColumnIndex].HeaderText;

          
            //DialogResult dResult = MessageBox.Show("Cell Double Click:\nStaff Name: "+staffName+"\nDate Category: "+dateCategory);
            RevertForm revertForm = new RevertForm();
            revertForm.ShowDialog();

            UndoHighlightCell(e.RowIndex, e.ColumnIndex);
            UnHideAllRows(e.RowIndex);

            //showRevertForm();

        }
        
        private void fillGrid(DataGridView dgv, List<DTO.MonthWiseStaffStatus> staffs)
        {
            int nCols= dgv.Columns.Count;
            for (int row = 0; row < staffs.Count; row++)
            {
                dgv.RowCount++;
                dgv[0, row].Value = staffs[row].StaffName.ToString();
                dgv[1, row].Value = staffs[row].Department.ToString();
                dgv[2, row].Value = staffs[row].Absent.ToString();
                dgv[3, row].Value = staffs[row].NoPunch.ToString();
                dgv[4, row].Value = staffs[row].IPT.ToString();
                dgv[5, row].Value = staffs[row].Late.ToString();
                dgv[6, row].Value = staffs[row].AvgWorkingHrs.ToString();
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            List<DTO.MonthWiseStaffStatus> staffList = DTO.MonthWiseStaffStatus.GetStaffList();
            fillGrid(dataGridView1, staffList);
            staffList.Clear();
           
        }

        private void ApplicationCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
             
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("You Selected Staff: " + dataGridView1[0, e.RowIndex].Value.ToString());
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBottom1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void monthNameButton_Click(object sender, EventArgs e)
        {

        }

        private void panelBottom1_OK_Button_Click(object sender, EventArgs e)
        {
            //panelBottom1.Hide();
            
        }

             
    }
}
