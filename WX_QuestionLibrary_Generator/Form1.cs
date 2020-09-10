using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WX_QuestionLibrary_Generator
{
    public partial class Form1 : Form
    {
        Question question;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            for (int i = listBoxAllSelections.SelectedItems.Count - 1; i > -1; i--)
            {
                //先验证是否已经存在这个选项
                if (listBoxAnswer.Items.Contains(listBoxAllSelections.SelectedItems[i]))
                {
                    continue;
                }
                // 添加至右边的格子
                listBoxAnswer.Items.Add(listBoxAllSelections.SelectedItems[i]);
            }


            /*
            //这里涉及到删除元素，逆向顺序删除，否则会导致下标变动
            for (int i = listBoxAllSelections.SelectedItems.Count - 1; i > -1; i--)
            {
                // 添加至右边的格子
                listBoxAnswer.Items.Add(listBoxAllSelections.SelectedItems[i]);
                //listBoxAllSelections.Items.Remove(listBoxAllSelections.SelectedItems[i]);
            }
            */


            if (question == null)
            {
                MessageBox.Show("请先填写并确定题目！");
                return;
            }
            UpdatePerview();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //这里涉及到删除元素，逆向顺序删除，否则会导致下标变动
            for (int i = listBoxAnswer.SelectedItems.Count - 1; i > -1; i--)
            {
                //listBoxAllSelections.Items.Add(listBoxAnswer.SelectedItems[i]);
                listBoxAnswer.Items.Remove(listBoxAnswer.SelectedItems[i]);
            }
            if (question == null)
            {
                MessageBox.Show("请先填写并确定题目！");
                return;
            }
            UpdatePerview();
        }

        private void buttonAddThisSelection_Click(object sender, EventArgs e)
        {
            // 先判断是否已经存在相同的选项
            foreach (var item in listBoxAllSelections.Items)
            {
                if (item == textBoxSelection)
                { 
                MessageBox.Show("不允许存在相同的选项！");
                return;
                }
            }

            // 如果已经
            if (question == null)
            {
                MessageBox.Show("请先填写并确定题目！");
                return;
            }
            if (textBoxSelection.Text == "")
            {
                MessageBox.Show("不可添加没有内容的选项！");
                return;
            }
            listBoxAllSelections.Items.Add(textBoxSelection.Text.ToString());
            textBoxSelection.Clear();
            UpdatePerview();
        }

        private void UpdatePerview() {
            if (question == null)
            {
                MessageBox.Show("ERROR");
                return;
            }

            // 更新选项
            question.getChoices().Clear();
            foreach (var item in listBoxAllSelections.Items)
            {
                question.getChoices().Add(item.ToString());
            }
            
            // 更新答案
            question.getAnswers().Clear();
            foreach (var item in listBoxAnswer.Items)
            {
                question.getAnswers().Add(item.ToString());
            }

            // 更新预览信息文本（框框下方的文本提示）并设定题目类型
            string questionType = "";
            if (question.getAnswers().Count == 1 && question.getChoices().Count == 2)
            {
                questionType = "判断题";
                question.setType("tf");
            }
            if (question.getAnswers().Count == 1 && question.getChoices().Count > 2)
            {
                questionType = "单选题";
                question.setType("s");
            }
            if (question.getAnswers().Count > 1 && question.getChoices().Count > 2)
            {
                questionType = "多选题";
                question.setType("m");
            }
            if (questionType != "")
                labelPreviewInfo.Text = "本题为 " + questionType + " 题，共有 " + question.getChoices().Count + " 个选项。";
            else if (question.getAnswers().Count < 1)
            {
                labelPreviewInfo.Text = "题目需要至少 1 个正确答案。";
                question.setType("");
            }
            else
            {
                labelPreviewInfo.Text = "题目需要多于 1 个选项。";
                question.setType("");
            }

            // 显示预览内容
            textBoxPreview.Text = question.ToPerviewString();
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            question = new Question(textBoxQuestion.Text);
            UpdatePerview();
        }

        private void buttonConfirmAnswer_Click(object sender, EventArgs e)
        {
            if (question == null)
            {
                MessageBox.Show("请先填写并确定题目！");
                return;
            }
            UpdatePerview();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            listBoxLibrary.Items.Add(question);
            listBoxAllSelections.Items.Clear();
            listBoxAnswer.Items.Clear();
            textBoxQuestion.Clear();
        }
        private void importFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "题库文本|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK){
                string[] datas = File.ReadAllLines(openFile.FileName);
                int q = 0;
                int c = 0;
                int a = 0;
                string[] titles = datas[0].Split('\t');
                for (int i = 0; i < titles.Length; i++){
                    if(titles[i].Trim() == "question"){
                        q = i;
                    }
                    if (titles[i].Trim() == "choices")
                    {
                        c = i;
                    }
                    if (titles[i].Trim() == "answers")
                    {
                        a = i;
                    }
                }

                for (int i = 1; i < datas.Length; i++)
                {
                    string[] tmpdata = datas[i].Split('\t');
                    string[] answers = tmpdata[a].Split('|');
                    string[] choices = tmpdata[c].Split('|');
                    string tquestion = tmpdata[q];
                    Question tmpQuestion = new Question(tquestion, choices, answers);
                    listBoxLibrary.Items.Add(tmpQuestion);
                }
            }
        }
        private void exportFile(){
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JSON|*.json";
            if (save.ShowDialog() == DialogResult.OK){
                string jsonFileName = save.FileName.EndsWith(".json") ? save.FileName : save.FileName + ".json";
                string txtFileName = save.FileName.EndsWith(".txt") ? save.FileName : save.FileName + ".txt";
                object[] libs = new object[listBoxLibrary.Items.Count];
                listBoxLibrary.Items.CopyTo(libs, 0);
                string json = string.Join("\r\n",libs);
                File.WriteAllText(jsonFileName, json, Encoding.UTF8);
                List<string> txtContent = new List<string>();
                txtContent.Add("question\tchoices\tanswers");
                foreach (var item in listBoxLibrary.Items){
                    Question t = (Question)item;
                    string tchoices = string.Join("|", t.getChoices());
                    string tanswers = string.Join("|", t.getAnswers());
                    string tquestion = t.getQuestion();
                    txtContent.Add(tquestion + "\t" + tchoices + "\t" + tanswers);
                }
                File.WriteAllLines(txtFileName, txtContent);
            }
        }

        private void buttonLoadQuestionLibrary_Click(object sender, EventArgs e)
        {
            importFile();
        }

        private void buttonSaveQuestionLibrary_Click(object sender, EventArgs e)
        {
            exportFile();
        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {
            //这里涉及到删除元素，逆向顺序删除，否则会导致下标变动
            for (int i = listBoxAllSelections.SelectedItems.Count - 1; i > -1; i--) {
                string item = listBoxAllSelections.SelectedItems[i].ToString();
                listBoxAllSelections.Items.Remove(item);
                if (listBoxAnswer.Items.Contains(item)) {
                    listBoxAnswer.Items.Remove(item);
                }
            }
            UpdatePerview();
        }
    }
}
