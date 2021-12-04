using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Dynamic;
using System.Xml.Xsl;

namespace Xml_Lab
{
    public partial class Form1 : Form
    {
        private string path = @"C:\Users\acer\Desktop\laba#2\Xml_Lab\ScientificSociety.xml";
        private bool isButtonSearchClicked = false;
        private List<Member> members;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ParseDocument();
            comboBoxFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCathedra.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMember.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTImeOfEntry.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void ParseDocument()
        {
            List<Member> allMembers = new List<Member>();
            Member m = new Member(new DOMXmlAnalyzatorStrategy(path));
            allMembers = m.Find(m);
            foreach (Member member in allMembers)
            {
                if (!comboBoxCathedra.Items.Contains(member.cathedra.cathedra))
                {
                    comboBoxCathedra.Items.Add(member.cathedra.cathedra);
                }
                if (!comboBoxFaculty.Items.Contains(member.cathedra.faculty))
                {
                    comboBoxFaculty.Items.Add(member.cathedra.faculty);
                }
                if (!comboBoxID.Items.Contains(member.cathedra.cathedraID))
                {
                    comboBoxID.Items.Add(member.cathedra.cathedraID);
                }
                if (!comboBoxMember.Items.Contains(member.name))
                {
                    comboBoxMember.Items.Add(member.name);
                }
                if (!comboBoxSex.Items.Contains(member.sex))
                {
                    comboBoxSex.Items.Add(member.sex);
                }
                if (!comboBoxTImeOfEntry.Items.Contains(member.timeOfEntry))
                {
                    comboBoxTImeOfEntry.Items.Add(member.timeOfEntry);
                }
            }
        }

        private void CustomizeComboBox(CheckBox checkBox, ComboBox comboBox)
        {
            if (checkBox.Checked)
            {
                comboBox.Visible = true;
                comboBox.Text = null;
            }
            else
            {
                comboBox.Visible = false;
            }
        }

        private void checkBoxPIP_Click(object sender, EventArgs e)
        {
            CustomizeComboBox(checkBoxPIP, comboBoxMember);
        }
        private void checkBoxFaculty_Click(object sender, EventArgs e)
        {
            CustomizeComboBox(checkBoxFaculty, comboBoxFaculty);
        }
        private void checkBoxCathedra_Click(object sender, EventArgs e)
        {
            CustomizeComboBox(checkBoxCathedra, comboBoxCathedra);
        }
        private void checkBoxTimeOfEntry_Click(object sender, EventArgs e)
        {
            CustomizeComboBox(checkBoxTimeOfEntry, comboBoxTImeOfEntry);
        }
        private void checkBoxSex_Click(object sender, EventArgs e)
        {
            CustomizeComboBox(checkBoxSex, comboBoxID);
        }
        private void checkBoxID_Click(object sender, EventArgs e)
        {
            CustomizeComboBox(checkBoxID, comboBoxID);
        }

        

        
        private void search_Click(object sender, EventArgs e)
        {
            isButtonSearchClicked = true;
            clear_Click(this, null);
            Member member = GetMember();
            members = member.Find(member);
            if (members != null)
                PrintMembers(members);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            rtbResult.Clear();
        }

        private Member GetMember()
        {
            Member member = new Member();
            if (dom.Checked)
                member = new Member(new DOMXmlAnalyzatorStrategy(path));
            if (sax.Checked)
                member = new Member(new SAXXmlAnalyzatorStrategy(path));
            if (linq.Checked)
                member = new Member(new LINQXmlAnalyzatorStrategy(path));
            member.name = checkBoxPIP.Checked ? comboBoxMember.Text : String.Empty;
            member.cathedra.faculty = checkBoxFaculty.Checked ? comboBoxFaculty.Text : String.Empty;
            member.cathedra.cathedraID = checkBoxID.Checked ? comboBoxID.Text : String.Empty;
            member.cathedra.cathedra = checkBoxCathedra.Checked ? comboBoxCathedra.Text : String.Empty;
            member.sex = checkBoxSex.Checked ? comboBoxSex.Text : String.Empty;
            member.timeOfEntry = checkBoxTimeOfEntry.Checked ? comboBoxTImeOfEntry.Text : String.Empty;
            return member;
        }
        private void PrintMembers(List<Member> members)
        {
            string output = String.Empty;
            foreach (Member member in members)
            {
                output = String.Empty;
                output += "Ім'я: " + member.name + "\r\n";
                output += "Cathedra: " + member.cathedra.cathedra + "\r\n";
                output += "Faculty: " + member.cathedra.faculty + "\r\n";
                output += "Cathedra ID: " + member.cathedra.cathedraID + "\r\n";
                output += "Sex: " + member.sex + "\r\n";
                output += "Date of birth: " + member.timeOfEntry + "\r\n";
                output += "===============================\r\n";
                rtbResult.Text += output;
            }
            if (output == String.Empty)
            {
                rtbResult.Text += "No matches found!!!\r\n";
                rtbResult.Text += "===============================\r\n";
            }
        }

        private void transform_Click(object sender, EventArgs e)
        {
            CheckToTransform();
            string xslFile = @"C:\Users\acer\Desktop\laba#2\Xml_Lab\Transform.xsl";
            string htmlFile = @"C:\Users\acer\Desktop\laba#2\Xml_Lab\Result.html";
            Transformator transformator = new Transformator(members, xslFile, htmlFile);
            transformator.Transform();
        }

        private void CheckToTransform()
        {
            if (!isButtonSearchClicked)
            {
                search_Click(this, null);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dr = MessageBox.Show("Ви дійсно хочете вийти?", "Підтвердження про вихід", MessageBoxButtons.YesNo);
            e.Cancel = (dr == DialogResult.Yes ? false : true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
