using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
// Assignment 1: Airline Reservation System
//
// HKwonAssignment1
//  By: Haeryun Kwon (Irene)
//  Date Created: 9.24.2017
//

namespace HKwonAssignment1
{
    public partial class Form1 : Form
    {
        //////////////////////////////////////////////////////////////////
        ////// Constructor:
        //////////////////////////////////////////////////////////////////

        const int MAX_WAITING = 10;

        // The airplane has 5 rows with 3 seats in each row.
        string[,] seatingList = new string[5, 3]
        {{"", "", ""}, { "", "", ""}, { "", "", ""},
        { "", "", ""}, { "", "", ""},};

        string[,] seatingNum = new string[5, 3]
        {{"A0", "A1", "A2"}, { "B0", "B1", "B2"}, { "C0", "C1", "C2"},
        { "D0", "D1", "D2"}, { "E0", "E1", "E2"},};

        string[] waitingList = new string[MAX_WAITING];

        string reservationSuccess = "The seat is successfully reserved. Thank you.";
        string waitingSuccess = "You are successfully added to waiting list. Thank you.";

        string passengerName = "";

        public Form1()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////////////////////
        ////// To book:
        //////////////////////////////////////////////////////////////////
        private void btnBook_Click(object sender, EventArgs e)
        {
            // Initialize textbox strings
            string passengerText = txtName.Text;
            string columnText = listBox1.Text;
            string rowText = listBox2.Text;

            // When having empty textbox
            if (passengerText == "")
            {
                MessageBox.Show("Please type your name.");
            }
            if (columnText == "")
            {
                MessageBox.Show("Please select a seat column.");
            }
            if (rowText == "")
            {
                MessageBox.Show("Please select a seat row.");
            }

            // No empty textbox
            if (passengerText != "" & columnText != "" & rowText != "")
            {
                switch (columnText + rowText)
                {
                    case "A0":
                        if (seatingList[0, 0].Length > 0)
                        {
                            MessageBox.Show("Sorry, the seat is not available.");
                            if (rtxtShowWaiting.ToString().Contains(passengerText + " " + seatingNum[0, 0]))
                            {
                                // nothing
                            }
                            else
                            {
                                rtxtShowWaiting.AppendText(passengerText + " " + seatingNum[0, 0] + "\n");
                                MessageBox.Show(waitingSuccess);
                            }
                        }
                        else
                        {
                            passengerName = passengerText;
                            seatingList[0, 0] = passengerName;

                            MessageBox.Show(reservationSuccess);
                        }

                        break;

                    case "A1":
                        if (seatingList[0, 1].Length > 0)
                        {
                            MessageBox.Show("Sorry, the seat is not available.");
                            if (rtxtShowWaiting.ToString().Contains(passengerText + " " + seatingNum[0, 1]))
                            {
                                // nothing
                            }
                            else
                            {
                                rtxtShowWaiting.AppendText(passengerText + " " + seatingNum[0, 1] + "\n");
                                MessageBox.Show(waitingSuccess);
                            }
                        }
                        else
                        {
                            passengerName = passengerText;
                            seatingList[0, 1] = passengerName;

                            MessageBox.Show(reservationSuccess);
                        }

                        break;

                    case "A2":
                        if (seatingList[0, 2].Length > 0)
                        {
                            MessageBox.Show("Sorry, the seat is not available.");
                            if (rtxtShowWaiting.ToString().Contains(passengerText + " " + seatingNum[0, 2]))
                            {
                                // nothing
                            }
                            else
                            {
                                rtxtShowWaiting.AppendText(passengerText + " " + seatingNum[0, 2] + "\n");
                                MessageBox.Show(waitingSuccess);
                            }
                        }
                        else
                        {
                            passengerName = passengerText;
                            seatingList[0, 2] = passengerName;

                            MessageBox.Show(reservationSuccess);
                        }

                        break;

                    case "B0":
                        if (seatingList[1, 0].Length > 0)
                        {
                            MessageBox.Show("Sorry, the seat is not available.");
                            if (rtxtShowWaiting.ToString().Contains(passengerText + " " + seatingNum[1, 0]))
                            {
                                // nothing
                            }
                            else
                            {
                                rtxtShowWaiting.AppendText(passengerText + " " + seatingNum[1, 0] + "\n");
                                MessageBox.Show(waitingSuccess);
                            }
                        }
                        else
                        {
                            passengerName = passengerText;
                            seatingList[1, 0] = passengerName;

                            MessageBox.Show(reservationSuccess);
                        }

                        break;

                    case "B1":
                        if (seatingList[1, 1].Length > 0)
                        {
                            MessageBox.Show("Sorry, the seat is not available.");
                            if (rtxtShowWaiting.ToString().Contains(passengerText + " " + seatingNum[1, 1]))
                            {
                                // nothing
                            }
                            else
                            {
                                rtxtShowWaiting.AppendText(passengerText + " " + seatingNum[1, 1] + "\n");
                                MessageBox.Show(waitingSuccess);
                            }
                        }
                        else
                        {
                            passengerName = passengerText;
                            seatingList[1, 1] = passengerName;

                            MessageBox.Show(reservationSuccess);
                        }

                        break;

                    case "B2":
                        if (seatingList[1, 2].Length > 0)
                        {
                            MessageBox.Show("Sorry, the seat is not available.");
                            if (rtxtShowWaiting.ToString().Contains(passengerText + " " + seatingNum[1, 2]))
                            {
                                // nothing
                            }
                            else
                            {
                                rtxtShowWaiting.AppendText(passengerText + " " + seatingNum[1, 2] + "\n");
                                MessageBox.Show(waitingSuccess);
                            }
                        }
                        else
                        {
                            passengerName = passengerText;
                            seatingList[1, 2] = passengerName;

                            MessageBox.Show(reservationSuccess);
                        }

                        break;

                    case "C0":
                        if (seatingList[2, 0].Length > 0)
                        {
                            MessageBox.Show("Sorry, the seat is not available.");
                            if (rtxtShowWaiting.ToString().Contains(passengerText + " " + seatingNum[2, 0]))
                            {
                                // nothing
                            }
                            else
                            {
                                rtxtShowWaiting.AppendText(passengerText + " " + seatingNum[2, 0] + "\n");
                                MessageBox.Show(waitingSuccess);
                            }
                        }
                        else
                        {
                            passengerName = passengerText;
                            seatingList[2, 0] = passengerName;

                            MessageBox.Show(reservationSuccess);
                        }

                        break;

                    case "C1":
                        if (seatingList[2, 1].Length > 0)
                        {
                            MessageBox.Show("Sorry, the seat is not available.");
                            if (rtxtShowWaiting.ToString().Contains(passengerText + " " + seatingNum[2, 1]))
                            {
                                // nothing
                            }
                            else
                            {
                                rtxtShowWaiting.AppendText(passengerText + " " + seatingNum[2, 1] + "\n");
                                MessageBox.Show(waitingSuccess);
                            }
                        }
                        else
                        {
                            passengerName = passengerText;
                            seatingList[2, 1] = passengerName;

                            MessageBox.Show(reservationSuccess);
                        }

                        break;

                    case "C2":
                        if (seatingList[2, 2].Length > 0)
                        {
                            MessageBox.Show("Sorry, the seat is not available.");
                            if (rtxtShowWaiting.ToString().Contains(passengerText + " " + seatingNum[2, 2]))
                            {
                                // nothing
                            }
                            else
                            {
                                rtxtShowWaiting.AppendText(passengerText + " " + seatingNum[2, 2] + "\n");
                                MessageBox.Show(waitingSuccess);
                            }
                        }
                        else
                        {
                            passengerName = passengerText;
                            seatingList[2, 2] = passengerName;

                            MessageBox.Show(reservationSuccess);
                        }

                        break;

                    case "D0":
                        if (seatingList[3, 0].Length > 0)
                        {
                            MessageBox.Show("Sorry, the seat is not available.");
                            if (rtxtShowWaiting.ToString().Contains(passengerText + " " + seatingNum[3, 0]))
                            {
                                // nothing
                            }
                            else
                            {
                                rtxtShowWaiting.AppendText(passengerText + " " + seatingNum[3, 0] + "\n");
                                MessageBox.Show(waitingSuccess);
                            }
                        }
                        else
                        {
                            passengerName = passengerText;
                            seatingList[3, 0] = passengerName;

                            MessageBox.Show(reservationSuccess);
                        }

                        break;

                    case "D1":
                        if (seatingList[3, 1].Length > 0)
                        {
                            MessageBox.Show("Sorry, the seat is not available.");
                            if (rtxtShowWaiting.ToString().Contains(passengerText + " " + seatingNum[3, 1]))
                            {
                                // nothing
                            }
                            else
                            {
                                rtxtShowWaiting.AppendText(passengerText + " " + seatingNum[3, 1] + "\n");
                                MessageBox.Show(waitingSuccess);
                            }
                        }
                        else
                        {
                            passengerName = passengerText;
                            seatingList[3, 1] = passengerName;

                            MessageBox.Show(reservationSuccess);
                        }

                        break;

                    case "D2":
                        if (seatingList[3, 2].Length > 0)
                        {
                            MessageBox.Show("Sorry, the seat is not available.");
                            if (rtxtShowWaiting.ToString().Contains(passengerText + " " + seatingNum[3, 2]))
                            {
                                // nothing
                            }
                            else
                            {
                                rtxtShowWaiting.AppendText(passengerText + " " + seatingNum[3, 2] + "\n");
                                MessageBox.Show(waitingSuccess);
                            }
                        }
                        else
                        {
                            passengerName = passengerText;
                            seatingList[3, 2] = passengerName;

                            MessageBox.Show(reservationSuccess);
                        }

                        break;

                    case "E0":
                        if (seatingList[4, 0].Length > 0)
                        {
                            MessageBox.Show("Sorry, the seat is not available.");
                            if (rtxtShowWaiting.ToString().Contains(passengerText + " " + seatingNum[4, 0]))
                            {
                                // nothing
                            }
                            else
                            {
                                rtxtShowWaiting.AppendText(passengerText + " " + seatingNum[4, 0] + "\n");
                                MessageBox.Show(waitingSuccess);
                            }
                        }
                        else
                        {
                            passengerName = passengerText;
                            seatingList[4, 0] = passengerName;

                            MessageBox.Show(reservationSuccess);
                        }

                        break;

                    case "E1":
                        if (seatingList[4, 1].Length > 0)
                        {
                            MessageBox.Show("Sorry, the seat is not available.");
                            if (rtxtShowWaiting.ToString().Contains(passengerText + " " + seatingNum[4, 1]))
                            {
                                // nothing
                            }
                            else
                            {
                                rtxtShowWaiting.AppendText(passengerText + " " + seatingNum[4, 1] + "\n");
                                MessageBox.Show(waitingSuccess);
                            }
                        }
                        else
                        {
                            passengerName = passengerText;
                            seatingList[4, 1] = passengerName;

                            MessageBox.Show(reservationSuccess);
                        }

                        break;

                    case "E2":
                        if (seatingList[4, 2].Length > 0)
                        {
                            MessageBox.Show("Sorry, the seat is not available.");
                            if (rtxtShowWaiting.ToString().Contains(passengerText + " " + seatingNum[4, 2]))
                            {
                                // nothing
                            }
                            else
                            {
                                rtxtShowWaiting.AppendText(passengerText + " " + seatingNum[4, 2] + "\n");
                                MessageBox.Show(waitingSuccess);
                            }
                        }
                        else
                        {
                            passengerName = passengerText;
                            seatingList[4, 2] = passengerName;

                            MessageBox.Show(reservationSuccess);
                        }

                        break;
                }
            }
        }

        //////////////////////////////////////////////////////////////////
        ////// To show status:
        //////////////////////////////////////////////////////////////////
        private void btnStatus_Click(object sender, EventArgs e)
        {
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (seatingList[r, c].Length > 0)
                    {
                        txtStatus.Text = "Not Available";
                    }

                    else
                    {
                        txtStatus.Text = "Available";
                    }
                }
            }
        }

        //////////////////////////////////////////////////////////////////
        ////// To show all of passengers reserved:
        //////////////////////////////////////////////////////////////////
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            // Initialize variables
            string columnText = listBox1.Text;
            string rowText = listBox2.Text;

            // Display a chart of the seats in the airplane. (When "All Seats" are pressed)
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (seatingList[r, c].Length > 0)
                    {
                        if (rtxtShowAll.ToString().Contains(seatingList[r, c] + " " + seatingNum[r, c]))
                        {
                            // nothing
                        }
                        else
                        {
                            rtxtShowAll.AppendText(seatingList[r, c] + " " + seatingNum[r, c] + "\n");
                        }
                    }
                }
            }
        }

        //////////////////////////////////////////////////////////////////
        ////// To Add to waiting list:
        //////////////////////////////////////////////////////////////////
        private void btnAddWaiting_Click(object sender, EventArgs e)
        {
            // Initialize variables
            string columnText = listBox1.Text;
            string rowText = listBox2.Text;
            string passengerText = txtName.Text;

            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    // If no seats are available, place the passenger to the waiting list.
                    if (seatingList[r, c].Length > 0)
                    {
                        if (rtxtShowWaiting.ToString().Contains(passengerText + " " + seatingNum[r, c]))
                        {

                        }
                        else
                        {
                            // If waiting list is full, do not add to waiting list,
                            // just show a message that the waiting list is full.
                            if (rtxtShowWaiting.Text.Split('\n').Length == 11)
                            {
                                MessageBox.Show("Sorry, the waiting list is full.");
                            }

                            // waiting list is not full.
                            else
                            {
                                MessageBox.Show(waitingSuccess);
                                rtxtShowWaiting.AppendText(passengerText + " " + seatingNum[r, c] + "\n");
                            }
                        }
                    }

                    // If seats are available, btnAddWaiting will not do anything,
                    // except showing a message "Seats are available".
                    // You cannot add a person to waiting list if there are seats available.            
                    else
                    {
                        MessageBox.Show("Seats are available.");
                        break;
                    }
                    break;
                }
                break;
            }
        }

        //////////////////////////////////////////////////////////////////
        ////// To fill all the 15 seats:
        //////////////////////////////////////////////////////////////////
        private void btnDebug_Click(object sender, EventArgs e)
        {
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    seatingList[r, c] = "Irene Kwon";
                    rtxtShowAll.AppendText("Irene Kwon" + " " + seatingNum[r, c] + "\n");
                }
            }
        }

        //////////////////////////////////////////////////////////////////
        ////// To Cancel:
        //////////////////////////////////////////////////////////////////
        private void btnCancel_Click(object sender, EventArgs e)
        {
            string columnText = listBox1.Text;
            string rowText = listBox2.Text;

            // "Cancel" is pressed without specifying the seat.
            if (columnText == "")
            {
                MessageBox.Show("Please select a seat column.");
            }
            if (rowText == "")
            {
                MessageBox.Show("Please select a seat row.");
            }

            // Choose the seat number to be cancelled.
            if (columnText != "" & rowText != "")
            {
                // Delete the passenger's name.
                for (int r = 0; r < 5; r++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (seatingNum[r, c] == columnText + rowText)
                        {
                            seatingList[r, c] = "";
                            MessageBox.Show("The seat is successfully cancelled. Thank you.");
                        }
                    }
                }
            }
        }
    }
}