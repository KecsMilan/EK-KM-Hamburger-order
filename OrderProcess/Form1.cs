using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OrderProcess.Classes;
using System.Configuration;


namespace OrderProcess
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"../../user.txt";
            string[] nums = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            List<User> users = new List<User>();

            string[] Firstnames = new string[]
            {
                "Michael", "James", "John", "David", "William"
            };

            string[] Surnames = new string[]
            {
                "Wang", "Liu", "Gao", "Ahmed", "Mohammad", "I"
            };

            Random rnd = new Random();

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            for (int i = 0; i < 3; i++)
            {
                string cardN = "";
                int amount = rnd.Next(500, 142000 + 1);

                string cvcCode = nums[rnd.Next(1, nums.Length - 1)] + "";

                string exp = nums[rnd.Next(0, 1 + 1)];

                if (exp == "0")
                {
                    exp += nums[rnd.Next(1, nums.Length - 1)];
                }
                else 
                {
                    exp += nums[rnd.Next(1, 2 + 1)];
                }

                string date = "";

                string firstname = Firstnames[rnd.Next(0, Firstnames.Length - 1)];
                string surname = Surnames[rnd.Next(0, Surnames.Length - 1)];

                for (int _ = 0; _ < 2; _++)
                {
                    date += nums[rnd.Next(1, nums.Length - 1)];
                }

                for (int j = 0; j < 16; j++)
                {
                    cardN += nums[rnd.Next(0, 10)];
                }

                for (int k = 0; k < 2; k++)
                {
                    cvcCode += nums[rnd.Next(0, nums.Length - 1)];
                }

                string expDate = $"{exp}/{date}";

                User user = new User(
                    cardN,
                    firstname,
                    surname,
                    expDate,
                    cvcCode,
                    amount
                    );

                MessageBox.Show(cardN);

                MessageBox.Show(user.ToString());

                users.Add(user);

                foreach (var item in users) { Console.WriteLine(item.getCardNumber()); }
            } 

            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var user in users)
                {
                    writer.WriteLine(user);
                }
            }

            CardNumber.Size = new Size(238, 40);
        }

        private void CardNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
