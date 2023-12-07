using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //unknown
        private void label1_Click(object sender, EventArgs e)
        {
            //unknown
        }


        int arr_index = 0;
        string[] all_id = new string[1000];
        string[] all_name = new string[1000];
        int[] all_score = new int[1000];
        string id_student ;
        string name_student ;
        string score_student;

        int max_idx , max_value , min_value , min_idx;

        int[] grade=new int[8];
        float[] gpa=new float[7];
        private void Save_button_Click(object sender, EventArgs e)
        {

            id_student = text_id_student.Text;
            name_student = text_name.Text;
            score_student = (text_point.Text);

            all_id[arr_index]    = id_student;
            all_name[arr_index]  = name_student;
            all_score[arr_index] = int.Parse(score_student);

            arr_index+=1;
            text_name.Text = "";
            text_id_student.Text = "";
            text_point.Text = "";

            
            
            // max value , index
            max_value = all_score.Max();
            max_idx = all_score.ToList().IndexOf(max_value);

            // show output max
            text_id_student_max.Text = $"{all_id[max_idx]}";
            text_name_max.Text = $"{all_name[max_idx]}";
            text_point_max.Text = $"{all_score[max_idx]}";

            min_value = max_value;
            //min value , index
            for (int i = 0; i < arr_index; i++)
            {
                if (all_score[i] < min_value)
                {
                    min_value = all_score[i];
                }
                
                
            }
            
            min_idx = all_score.ToList().IndexOf(min_value);


            //show output min
            text_id_student_min.Text = $"{all_id[min_idx]}";
            text_name_min.Text = $"{all_name[min_idx]}";
            text_point_min.Text = $"{all_score[min_idx]}";

            //average output 

            //double average_grade = (double)(all_score.Sum() / arr_index);
            text_avg_point.Text = $"{(double)all_score.Sum() / (double)arr_index:0.00}";

            int score = all_score[arr_index-1];
            if (score >= 80 && score <= 100)
            {
                grade[0] += 1;
                gradeA.Text = grade[0].ToString();
                gpa[0] = grade[0] * 4;
            }
            else if (score >= 75 && score <= 79)
            {
                grade[1] += 1;
                gradeBB.Text = grade[1].ToString();
                gpa[1] = grade[1] * 3.5f;
            }
            else if (score >= 70&& score <= 74)
            {
                grade[2] += 1;
                gradeB.Text = grade[2].ToString();
                gpa[2] = grade[2] * 3;
            }
            else if (score >= 65 && score <= 69)
            {
                grade[3] += 1;
                gradeCC.Text = grade[3].ToString();
                gpa[3] = grade[3] * 2.5f;
            }
            else if (score >= 60 && score <= 79)
            {
                grade[4] += 1;
                gradeC.Text = grade[4].ToString();
                gpa[4] = grade[4] * 2.0f;
            }
            else if (score >= 55 && score <= 59)
            {
                grade[5] += 1;
                gradeDD.Text = grade[5].ToString();
                gpa[5] = grade[5] * 1.5f;
            }
            else if (score >= 50 && score <= 54)
            {
                grade[6] += 1;
                gradeD.Text = grade[6].ToString();
                gpa[6] = grade[6] * 1.0f;
            }
            else  
            {
                grade[7] += 1;
                gradeF.Text = grade[7].ToString();
            }

            double result=(double)gpa.Sum()/ (double)arr_index;
            GPA.Text= result.ToString();d
        }
        //Min result

        private void text_id_student_min_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_name_min_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_point_min_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_avg_point_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Min result


        //Max Result
        private void text_id_student_max_TextChanged(object sender, EventArgs e)
        {

            text_id_student_max.Text = $"{all_id[max_idx]}";

        }

        private void text_name_max_TextChanged(object sender, EventArgs e)
        {

            text_name_max.Text = $"{all_name[max_idx]}";

        }

        private void text_point_max_TextChanged(object sender, EventArgs e)
        {

            //text_point_max.Text = $"{all_[max_idx]}";

        }
        //Max result

    }
}
