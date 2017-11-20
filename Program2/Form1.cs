//Grading ID: A5196
//Program Number: Program 2
//Due Date: 9 March 2017
//Course Section: CIS 199-01
//This program will tell a user when ther register for courses.
//The user will select from 1 of 4 radio buttons to indicate their class status.
//The program will then use their first initial and class to assess the date when the register.
//It is based off of a long series of if statements to find the relevant information.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class program2Form : Form
    {
        public program2Form()
        {
            InitializeComponent();
        }
        //Constants for the time slots
        private const string TIME_SLOT_1 = "At 8:30 AM";
        private const string TIME_SLOT_2 = "At 10:00 AM";
        private const string TIME_SLOT_3 = "At 11:30 AM";
        private const string TIME_SLOT_4 = "At 2:00 PM";
        private const string TIME_SLOT_5 = "At 4:00 PM";

        private void registrationTimeButton_Click(object sender, EventArgs e)
        {
            string registrationDate;//this variable will hold the text of the users registration date and time.
            char lastInitial;//Variable to hold last initial of user.


            //This if will determine if the users inputs is no empty and if it is a letter, and if so will proceed with the program.
            if (lastNameTextBox.Text.Count() >= 1 && char.IsLetter(lastNameTextBox.Text[0]))
            {
                lastInitial = lastNameTextBox.Text[0];//sets last initial variable equal to the first letter of entered string.
                lastInitial = char.ToUpper(lastInitial);//Makes sure the inital is upper case

                //This if covers both Junior and Senior registration, due to the same patterns
                if (seniorRadioButton.Checked || juniorRadioButton.Checked)
                {
                    //This series of Ifs will assign a time to the registration date variable
                    //It does not need to be specific since both follow the same time pattern
                    if (lastInitial <= 'D')
                    {
                        registrationDate = TIME_SLOT_3;
                    }
                    else if (lastInitial <= 'I')
                    {
                        registrationDate = TIME_SLOT_4;
                    }
                    else if (lastInitial <= 'O')
                    {
                        registrationDate = TIME_SLOT_5;
                    }
                    else if (lastInitial <= 'S')
                    {
                        registrationDate = TIME_SLOT_1;
                    }
                    else
                    {
                        registrationDate = TIME_SLOT_2;
                    }
                    //The next two ifs will add a date to the registrationDate variable, after the time to give the full readout (Time on Date)
                    //This if shows the registration day for Seniors
                    if (seniorRadioButton.Checked)
                    {
                        registrationDate = registrationDate + " on March 29th";
                    }
                    //This if shows the registration day for Juniors
                    else if (juniorRadioButton.Checked)
                    {
                        registrationDate = registrationDate + " on March 30th";
                    }
                }

                //The following Covers the situation for Freshmen and Sophomores, since they follow the same patterns.
                else if (sophomoreRadioButton.Checked || freshmanRadioButton.Checked)
                {
                    //The following series of ifs will assign a time to freshman and sophmore students, due to their common pattern.
                    //It opts for alphabetic rather than temporal order as the last initial can more easy be compared against a list in this case.
                    if (lastInitial <= 'B')
                    {
                        registrationDate = TIME_SLOT_5;
                    }
                    else if (lastInitial <= 'D')
                    {
                        registrationDate = TIME_SLOT_1;
                    }
                    else if (lastInitial <= 'F')
                    {
                        registrationDate = TIME_SLOT_2;
                    }
                    else if (lastInitial <= 'I')
                    {
                        registrationDate = TIME_SLOT_3;
                    }
                    else if (lastInitial <= 'L')
                    {
                        registrationDate = TIME_SLOT_4;
                    }
                    else if (lastInitial <= 'O')
                    {
                        registrationDate = TIME_SLOT_5;
                    }
                    else if (lastInitial <= 'Q')
                    {
                        registrationDate = TIME_SLOT_1;
                    }
                    else if (lastInitial <= 'S')
                    {
                        registrationDate = TIME_SLOT_2;
                    }
                    else if (lastInitial <= 'V')
                    {
                        registrationDate = TIME_SLOT_3;
                    }
                    else
                    {
                        registrationDate = TIME_SLOT_4;
                    }
                    //This if covers sophomores C-O for the registration Day (4-3)
                    if (sophomoreRadioButton.Checked && lastInitial >= 'C' && lastInitial <= 'O')
                    {
                        registrationDate = registrationDate + " On April 3rd";
                    }
                    //This covers the rest of the sophomores (A-B, P-Z) for their registration day (3-31)
                    else if (sophomoreRadioButton.Checked)
                    {
                        registrationDate = registrationDate + " On March 31st";
                    }
                    //This if covers freshmen C-O for the registration Day (4-5)
                    else if (freshmanRadioButton.Checked && lastInitial >= 'C' && lastInitial <= 'O')
                    {
                        registrationDate = registrationDate + " On April 5th";
                    }
                    //This covers the rest of the freshmen (A-B, P-Z) for their registration day (4-4)
                    else if (freshmanRadioButton.Checked)
                    {
                        registrationDate = registrationDate + " On April 4th";
                    }
                }
                //This else will only display if no class is selected, so It will tell the user to select one.
                else
                {
                    registrationDate = "Please select a Class";
                }
            }
            //Else returns if an empty name or a non alphabetic character entered.
            else
            {
                registrationDate = "Invalid Name Entered";
            }
            //This finally assigns the output to the label on the form
            //Itis at the end so it will not have to be repeated many times throughout the code.
            registrationOutputLabel.Text = registrationDate;
        }
    }
}
