using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        List<Person> ListPerson = new List<Person>();
        public Form1()
        {
            Person p = new Person();
            p.Age = 10;
            Person p1 = new Person();
            p1.Age = 20;
            Person p2 = new Person();
            p2.Age = 30;
            ListPerson.Add(p);
            ListPerson.Add(p1);
            ListPerson.Add(p2);
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
             ///این دلیگیت هم خروجی دارد و هم ورودی
       





            //متد سنتی
            System.Func<Person, bool> FuncDlegete1 = method;

            ///*********************************************
            /// 
            ///*********************************************

            //anonymouse function
            //System.Func<Person, bool> FuncDlegete2 = (Person x) => {
            System.Func<Person, bool> FuncDlegete2 = x =>
            {
                if (x.Age == 10)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            };

            ///*********************************************
            /// 
            ///*********************************************

            //Lambda_Expression
            System.Func<Person, bool> FuncDlegete3 = x => x.Age == 10;

            ///*********************************************
            /// 
            ///*********************************************

            var Result = ListPerson.Where(FuncDlegete1);
            //var Result = ListPerson.Where(FuncDlegete2);
            //var Result = ListPerson.Where(FuncDlegete3);

            foreach (var item in Result)
            {
                MessageBox.Show(item.Age.ToString());
            }

        }
        public bool method(Person p)
        {
            if (p.Age == 10)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /// این دلیگیت فقط ورودی می گیرد و خروجی ندارد
            System.Action ActionDelegate1 = () => MessageBox.Show("non parameters");
            ActionDelegate1();

            ///*********************************************
            /// 
            ///*********************************************

            System.Action<string> ActionDelegate2 = (string s) => { MessageBox.Show(s); };
            //System.Action<string> ActionDelegate2 = (s) => MessageBox.Show(s);
            ActionDelegate2("with parameter");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///خروجی این دلیگیت فقط بولین می باشد
            System.Predicate<string> PredicateDlegate1 = (s) => true;

            System.Predicate<string> PredicateDlegate2 = (s) =>
            {
                MessageBox.Show(s);
                if (s == "input")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };


            if (PredicateDlegate2("input"))
            {
                MessageBox.Show("is true");
            }
        }
    }
}
