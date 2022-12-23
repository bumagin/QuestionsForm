using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        string username;

        int question = 0;
        int trueAnswers = 0;
        int sec = 0;
        int minute = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            switch (question)
            {
                case 0:
                    username = textBox1.Text; // 1 вопрос
                    pictureBox1.Visible = false;
                    label2.Visible = false;


                    label1.Text = "Относится ли Agile к архитектурным решениям?"; // 2 вопрос
                    button1.Text = "Да";
                    button2.Visible = true;
                    textBox1.Visible = false;
                    button2.Text = "Нет";
                    break;
                case 1:
                    trueAnswers++;

                    button1.Visible = false; // 3 вопрос
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = true;
                    button4.Text = "Ответить";

                    label1.Text = "Какие уровни архитектуры принято выделять?";

                    checkBox1.Visible = true;
                    checkBox1.Text = "Уровень предприятия";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Уровень системы (приложения)";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Уровень кода";
                    break;
                case 4:
                    button1.Visible = false;
                    button2.Visible = false;
                    button4.Visible = true;

                    label1.Text = "Какие принципы помогают строить хорошую Архитектуру?";

                    checkBox1.Visible = true;
                    checkBox1.Text = "DRY";
                    checkBox2.Visible = true;
                    checkBox2.Text = "SOLID";
                    checkBox3.Visible = true;
                    checkBox3.Text = "KISS";
                    checkBox4.Visible = true;
                    checkBox4.Text = "GRASP";
                    break;
                case 6:
                    label1.Text = "Входит ли формирование требований\nк инфраструктуре проекта в Архитектуру проекта?";

                    button1.Text = "Да";
                    button2.Text = "Нет";
                    button3.Visible = false;
                    button4.Visible = false;
                    break;
                case 7:
                    trueAnswers++;

                    label1.Text = "На каком уровне архитектуры\n используется архитектурный шаблон MVC?";

                    button1.Text = "На уровне предпрития";
                    button2.Text = "На уровне приложения";
                    button3.Visible = true;
                    button3.Text = "На уровне кода";
                    button4.Visible = false;
                    break;
                case 8:
                    label1.Text = "Одно из основных архитектурных правил гласит:";

                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = true;
                    button4.Text = "Завершить тест.";

                    checkBox1.Visible = true;
                    checkBox1.Text = "Высокое зацепление (coupling), низкая связность (cohesion)";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Низкое зацепление (coupling), высокая связность (cohesion)";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Высокое зацепление (coupling), высокая связность (cohesion)";
                    checkBox4.Visible = true;
                    checkBox4.Text = "Низкое зацепление (coupling), низкая связность (cohesion)";
                    break;
            }

            question++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (question)
            {
                case 1:
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = true; //3 вопрос
                    button4.Text = "Ответить";

                    label1.Text = "Какие уровни архитектуры принято выделять?";

                    checkBox1.Visible = true;
                    checkBox1.Text = "Уровень предприятия";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Уровень системы (приложения)";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Уровень кода";
                    break;
                case 4:
                    trueAnswers++;
                    //на 6 вопрос

                    button1.Visible = false;
                    button2.Visible = false;
                    button4.Visible = true;

                    label1.Text = "Какие принципы помогают строить хорошую Архитектуру?";

                    checkBox1.Visible = true;
                    checkBox1.Text = "DRY";
                    checkBox2.Visible = true;
                    checkBox2.Text = "SOLID";
                    checkBox3.Visible = true;
                    checkBox3.Text = "KISS";
                    checkBox4.Visible = true;
                    checkBox4.Text = "GRASP";
                    break;
                case 6:
                    trueAnswers++; //проверка 7 вопроса

                    //к 8 вопросу

                    label1.Text = "Входит ли формирование требований\n к инфраструктуре проекта в Архитектуру проекта?";

                    button1.Text = "Да";
                    button2.Text = "Нет";
                    button3.Visible = false;
                    button4.Visible = false;
                    break;
                case 7:
                    trueAnswers++;

                    label1.Text = "На каком уровне архитектуры\nиспользуется архитектурный шаблон MVC?";

                    button1.Text = "На уровне предпрития";
                    button2.Text = "На уровне приложения";
                    button3.Visible = true;
                    button3.Text = "На уровне кода";
                    button4.Visible = false;
                    break;
                case 8:
                    trueAnswers++;

                    //к 10 вопросу

                    label1.Text = "Одно из основных архитектурных правил гласит:";

                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = true;
                    button4.Text = "Завершить тест.";

                    checkBox1.Visible = true;
                    checkBox1.Text = "Высокое зацепление (coupling), низкая связность (cohesion)";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Низкое зацепление (coupling), высокая связность (cohesion)";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Высокое зацепление (coupling), высокая связность (cohesion)";
                    checkBox4.Visible = true;
                    checkBox4.Text = "Низкое зацепление (coupling), низкая связность (cohesion)";
                    break;
            }
            question++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (question)
            {
                case 6:
                    //trueAnswer++; проверка 7 вопроса

                    //к 8 вопросу

                    label1.Text = "Входит ли формирование требований\n к инфраструктуре проекта в Архитектуру проекта?";

                    button1.Text = "Да";
                    button2.Text = "Нет";
                    button3.Visible = false;
                    button4.Visible = false;
                    break;
                case 8:
                    //проверка 9 вопроса

                    //к 10 вопросу

                    label1.Text = "Одно из основных архитектурных правил гласит:";

                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = true;
                    button4.Text = "Завершить тест.";

                    checkBox1.Visible = true;
                    checkBox1.Text = "Высокое зацепление (coupling), низкая связность (cohesion)";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Низкое зацепление (coupling), высокая связность (cohesion)";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Высокое зацепление (coupling), высокая связность (cohesion)";
                    checkBox4.Visible = true;
                    checkBox4.Text = "Низкое зацепление (coupling), низкая связность (cohesion)";
                    break;
            }

            question++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (question)
            {
                case 2:
                    if (checkBox1.Checked)
                    {
                        trueAnswers++; // проверка ответа 3 вопроса
                    }


                    label1.Text = "Какие проблемы решает Архитектура?";

                    checkBox1.Text = "Уменьшает time to market"; // 4 вопрос
                    checkBox2.Text = "Позволяет наращивать темп разработки";
                    checkBox3.Text = "Уменьшает сложность разработкия";
                    checkBox4.Visible = true;
                    checkBox4.Text = "Упрощает интеграцию разных компонент системы";
                    break;
                case 3:
                    if (checkBox1.Checked)
                    {
                        trueAnswers++;
                    }

                    checkBox1.Visible = false;
                    checkBox2.Visible = false;
                    checkBox3.Visible = false; // 5 вопрос
                    checkBox4.Visible = false;
                    button4.Visible = false;

                    label1.Text = "Может ли хорошая архитектура \nполностью исключить возможность написания \"плохого\" кода?";

                    button1.Visible = true;
                    button1.Text = "Да";
                    button2.Visible = true;
                    button2.Text = "Нет";
                    break;
                case 5:
                    if (checkBox1.Checked) //проверка 6 вопроса
                    {
                        trueAnswers++;
                    }

                    label1.Text = "Какой правильный порядок действий при построении архитектуры?";

                    checkBox1.Visible = false;
                    checkBox2.Visible = false;
                    checkBox3.Visible = false;
                    checkBox4.Visible = false;

                    button1.Visible = true;
                    button1.Text = "архитектура – требования – логика – структура – код";
                    button2.Visible = true;
                    button2.Text = "требования – структура – архитектура – логика – код";
                    button3.Visible = true;
                    button3.Text = "требования – архитектура – логика – структура – код";
                    button4.Text = "архитектура – логика – требования – структура – код";
                    break;
                case 6:
                    //trueAnswer++; проверка 7 вопроса

                    //к 8 вопросу

                    label1.Text = "Входит ли формирование требований\n к инфраструктуре проекта в Архитектуру проекта?";

                    button1.Text = "Да";
                    button2.Text = "Нет";
                    button3.Visible = false;
                    button4.Visible = false;
                    break;
                case 8:
                    //проверка 9 вопроса

                    //к 10 вопросу

                    label1.Text = "Одно из основных архитектурных правил гласит:";

                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;

                    checkBox1.Visible = true;
                    checkBox1.Text = "Высокое зацепление (coupling), низкая связность (cohesion)";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Низкое зацепление (coupling), высокая связность (cohesion)";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Высокое зацепление (coupling), высокая связность (cohesion)";
                    checkBox4.Visible = true;
                    checkBox4.Text = "Низкое зацепление (coupling), низкая связность (cohesion)";
                    break;
                case 9:
                    timer1.Stop();
                    label1.Text = "Спасибо за прохождения теста!\nВаши результаты записаны, ждите оценки!" + "\nТест пройден за " + minute + " минут и " + sec + " секунд.";

                    checkBox1.Visible = false;
                    checkBox2.Visible = false;
                    checkBox3.Visible = false;
                    checkBox4.Visible = false;
                    button4.Visible = false;

                    label2.Visible = true;

                    if (trueAnswers <= 4)
                    {
                        label2.Text = "Ваша оцена: 2";
                    }
                    if (trueAnswers > 4 && trueAnswers < 6)
                    {
                        label2.Text = "Ваша оценка: 3";
                    }
                    if (trueAnswers == 7)
                    {
                        label2.Text = "Ваша оценка: 4";
                    }
                    if (trueAnswers == 8)
                    {
                        label2.Text = "Ваша оценка: 5";
                    }

                    System.IO.File.WriteAllText("результат.txt", "Имя студента: " + username + "\n" + "Количество правильный ответов: " + trueAnswers + "\n" + "Время прохождения теста: " + minute + " минут " + sec + " секунд");
                    break;
            }
            question++;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sec == 60)
            {
                minute++;
                sec = 0;
            }

            sec++;
        }
    }
}