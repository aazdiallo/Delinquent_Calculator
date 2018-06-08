//////////////////// When the streets are a jungle, /////////////////
//////////////////// There can only be one King //////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Program1_CS_A
{
    public partial class Form1 : Form
    {
        //Declaration of constant values
         double AfterFees = 50.0;
         double MissedApptFees = 25.0;
         double FeePerKWH = 8.2;
         double Reconnect = 25.0;
         double RehabDiscount = 0;

         //Declaration of variables
         double Meter1S = 0, Meter1E = 0;
         double Meter2S = 0, Meter2E = 0;
         double Meter3S = 0, Meter3E = 0;
         double PriorBalance = 0, KWHCharges = 0, MeterCharges = 0 , TotalKWH = 0;
         double testVal = 0, testVal1 = 0, testVal2 = 0, resTestVal = 0, TotalDiscount = 0;
         //double AfterFees = 0, MissedApptFees = 0;
         int TotalMeters = 0;

         bool button = true;


        //Definition of Calc function
        private void Calc()
        {

            //Clearing labels outputs
            Meter1KWH.Text = string.Empty;
            Meter2KWH.Text = string.Empty;
            Meter3KWH.Text = string.Empty;

            TotalKWUsed.Text = string.Empty;
            MeterCharge.Text = string.Empty;
            AfterCharge.Text = string.Empty;
            MissedCharge.Text = string.Empty;
            VerifyInput.Text = string.Empty;
            KWHCharge.Text = string.Empty;
            LblRehabMes.Text = string.Empty;
            LblKWHMes.Text = string.Empty;

            LblTotalDue.Text = string.Empty;

            // If at least one meter contains all its input values
            if ((!string.IsNullOrEmpty(TxBxMerter1S.Text) && !string.IsNullOrEmpty(TxBxMerter1E.Text)) ||
                (!string.IsNullOrEmpty(TxBxMerter2S.Text) && !string.IsNullOrEmpty(TxBxMerter2E.Text)) ||
                (!string.IsNullOrEmpty(TxBxMerter3S.Text) && !string.IsNullOrEmpty(TxBxMerter3E.Text)))
            {
               

                //If only meter1 fields were filled
                if ((!string.IsNullOrEmpty(TxBxMerter1S.Text) && !string.IsNullOrEmpty(TxBxMerter1E.Text)) &&
                    (string.IsNullOrEmpty(TxBxMerter2S.Text) && string.IsNullOrEmpty(TxBxMerter2E.Text)) &&
                    (string.IsNullOrEmpty(TxBxMerter3S.Text) && string.IsNullOrEmpty(TxBxMerter3E.Text)))
                {
                    // Verifying that Meter1, Prior Balance, and Meter Count contain only numeric values
                    if (!double.TryParse(TxBxMerter1S.Text, out Meter1S) || !double.TryParse(TxBxMerter1E.Text, out Meter1E) ||
                        (!string.IsNullOrEmpty(TxBxMCount.Text) && (!int.TryParse(TxBxMCount.Text, out TotalMeters))) ||
                        ((!string.IsNullOrEmpty(TxBxPrior.Text) && (!Double.TryParse(TxBxPrior.Text, out PriorBalance)))))
                    {
                        VerifyInput.Text = "Verify that values are in numeric and 'Meter Count' is an integer";
                        SystemSounds.Beep.Play();
                    }
                    else if (TotalMeters > 1)
                    {
                        VerifyInput.Text = "Meter Count should be 1 when you file only one meter";
                        SystemSounds.Beep.Play();
                    }
                    else if (TotalMeters < 1)
                    {
                        VerifyInput.Text = "Meter Count should not be negative or equal to 0";
                        SystemSounds.Beep.Play();
                    }
                    else if ((Meter1S < 0) || (Meter1E < 0))
                    {
                        VerifyInput.Text = "Meter values should not be negative!!!\nPlease enter positive values only";
                        SystemSounds.Beep.Play();
                    }
                    else
                    {
                        // If values are numeric
                        if (string.IsNullOrEmpty(TxBxPrior.Text))
                        {
                            TxBxPrior.Text = "0.00";
                        }
                        else
                        {
                            PriorBalance = Math.Round(Convert.ToDouble(TxBxPrior.Text), 2);
                        }
                        TotalMeters = 1;

                        if (Meter1S == Meter1E) // If starting value is greater than ending value
                        {
                            VerifyInput.Text = "This case is not handled by this program...";
                            SystemSounds.Beep.Play();
                            Meter1KWH.Text = string.Empty;
                            Meter2KWH.Text = string.Empty;
                            Meter3KWH.Text = string.Empty;
                        }
                        else if (Meter1S > Meter1E){ // Starting > Ending value
                            testVal = 9999 - Meter1S; // getting the total KWH in the first roll
                           
                            Meter1KWH.Text = Convert.ToString(Meter1E + testVal);
                            Meter2KWH.Text = "0";
                            Meter3KWH.Text = "0";

                            //Double.TryParse(TotalKWUsed.Text, out TotalUsed);
                            TotalKWUsed.Text = Meter1KWH.Text;
                            TotalKWH = Convert.ToDouble(Meter1KWH.Text);

                            KWHCharges = Math.Round(((Convert.ToDouble(TotalKWUsed.Text) * FeePerKWH) / 100), 2);

                            if ((TotalKWH > 7000) && (TotalKWH < 9000))
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.05)) / 100), 2);
                            }
                            else if (TotalKWH > 9000)
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.15)) / 100), 2);
                            }
                            else
                            {
                                TotalDiscount = KWHCharges;
                            }
                            resTestVal = KWHCharges - TotalDiscount; // assigning the discount value 
                            MeterCharges = Math.Round((TotalMeters * Reconnect), 2);
                            LblKWHMes.Text = "$" + (KWHCharges - TotalDiscount).ToString("#,##0.00");
                            KWHCharge.Text = "$" + (KWHCharges - resTestVal).ToString("#,##0.00"); // Taking off the distance value
                            MeterCharge.Text = "$" + MeterCharges.ToString("#,##0.00");
                            AfterCharge.Text = "$" + AfterFees.ToString("#,##0.00");
                            MissedCharge.Text = "$" + MissedApptFees.ToString("#,##0.00");
                            LblRehabMes.Text = "$" + RehabDiscount.ToString("#,##0.00");
                            LblTotalDue.Text = "Total Due $ " + (MeterCharges + KWHCharges + PriorBalance + MissedApptFees + AfterFees).ToString("#,##0.00");
                        }
                        else
                        {   // If Ending value is greater than Starting value

                            Meter1KWH.Text = Convert.ToString(Meter1E - Meter1S);
                            Meter2KWH.Text = "0";
                            Meter3KWH.Text = "0";
                            //Double.TryParse(TotalKWUsed.Text, out TotalUsed);
                            TotalKWUsed.Text = Meter1KWH.Text;
                            TotalKWH = Convert.ToDouble(Meter1KWH.Text);

                            KWHCharges = Math.Round(((Convert.ToDouble(TotalKWUsed.Text) * FeePerKWH) / 100), 2);
                            if ((TotalKWH > 7000) && (TotalKWH < 9000))
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.05)) / 100), 2);
                            }
                            else if(TotalKWH > 9000)
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.15)) / 100), 2);
                            }
                            else
                            {
                                TotalDiscount = KWHCharges;
                            }

                            MeterCharges = Math.Round((TotalMeters * Reconnect), 2);
                            LblKWHMes.Text = "$" + (KWHCharges - TotalDiscount).ToString("#,##0.00");
                            KWHCharge.Text = "$" + KWHCharges.ToString("#,##0.00");
                            MeterCharge.Text = "$" + MeterCharges.ToString("#,##0.00");
                            AfterCharge.Text = "$" + AfterFees.ToString("#,##0.00");
                            MissedCharge.Text = "$" + MissedApptFees.ToString("#,##0.00");
                            LblRehabMes.Text = "$" + RehabDiscount.ToString("#,##0.00");
                            LblTotalDue.Text = "Total Due $ " + (MeterCharges + KWHCharges + PriorBalance + MissedApptFees + AfterFees).ToString("#,##0.00");
                        }
                    }

                }
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                /////////////////////////////////////////////////////////////////////////////////////////////////////

                //If only meter2 fields were filled

                else if ((string.IsNullOrEmpty(TxBxMerter1S.Text) && string.IsNullOrEmpty(TxBxMerter1E.Text)) &&
                    (!string.IsNullOrEmpty(TxBxMerter2S.Text) && !string.IsNullOrEmpty(TxBxMerter2E.Text)) &&
                    (string.IsNullOrEmpty(TxBxMerter3S.Text) && string.IsNullOrEmpty(TxBxMerter3E.Text)))
                {
                    // Verifying that Meter1, Prior Balance, and Meter Count contain only numeric values
                    if (!double.TryParse(TxBxMerter2S.Text, out Meter2S) || !double.TryParse(TxBxMerter2E.Text, out Meter2E) ||
                        (!string.IsNullOrEmpty(TxBxMCount.Text) && (!int.TryParse(TxBxMCount.Text, out TotalMeters))) ||
                        ((!string.IsNullOrEmpty(TxBxPrior.Text) && (!Double.TryParse(TxBxPrior.Text, out PriorBalance)))))
                    {
                        VerifyInput.Text = "Verify that values are in numeric and 'Meter Count' is an integer";
                        SystemSounds.Beep.Play();
                    }
                    else if (TotalMeters > 1)
                    {
                        VerifyInput.Text = "Meter Count should be 1 when you file only one meter";
                        SystemSounds.Beep.Play();
                    }
                    else if (TotalMeters < 1)
                    {
                        VerifyInput.Text = "Meter Count should not be negative or equal to 0";
                        SystemSounds.Beep.Play();
                    }
                    else if ((Meter2S < 0) || (Meter2E < 0))
                    {
                        VerifyInput.Text = "Meter values should not be negative!!!\nPlease enter positive values only";
                        SystemSounds.Beep.Play();
                    }
                    else
                    {
                        // If values are numeric
                        if (string.IsNullOrEmpty(TxBxPrior.Text))
                        {
                            TxBxPrior.Text = "0.00";
                        }
                        else
                        {
                            PriorBalance = Math.Round(Convert.ToDouble(TxBxPrior.Text), 2);
                        }
                        TotalMeters = 1;

                        if (Meter2S == Meter2E) // If starting value is greater than ending value
                        {
                            VerifyInput.Text = "This case is not handled by this program...";
                            SystemSounds.Beep.Play();
                            Meter1KWH.Text = string.Empty;
                            Meter2KWH.Text = string.Empty;
                            Meter3KWH.Text = string.Empty;
                        }
                        else if ((Meter2S > Meter2E))
                        { // Starting > Ending value
                            testVal = 9999 - Meter2S; // getting the total KWH in the first roll

                            Meter2KWH.Text = Convert.ToString(Meter2E + testVal);
                            Meter1KWH.Text = "0";
                            Meter3KWH.Text = "0";

                            //Double.TryParse(TotalKWUsed.Text, out TotalUsed);
                            TotalKWUsed.Text = Meter2KWH.Text;
                            TotalKWH = Convert.ToDouble(Meter2KWH.Text);

                            KWHCharges = Math.Round(((Convert.ToDouble(TotalKWUsed.Text) * FeePerKWH) / 100), 2);

                            if ((TotalKWH > 7000) && (TotalKWH < 9000))
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.05)) / 100), 2);
                            }
                            else if (TotalKWH > 9000)
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.15)) / 100), 2);
                            }
                            else
                            {
                                TotalDiscount = KWHCharges;
                            }
                            resTestVal = KWHCharges - TotalDiscount; // assigning the discount value 
                            MeterCharges = Math.Round((TotalMeters * Reconnect), 2);
                            LblKWHMes.Text = "$" + (KWHCharges - TotalDiscount).ToString("#,##0.00");
                            KWHCharge.Text = "$" + (KWHCharges - resTestVal).ToString("#,##0.00"); // Taking off the distance value
                            MeterCharge.Text = "$" + MeterCharges.ToString("#,##0.00");
                            AfterCharge.Text = "$" + AfterFees.ToString("#,##0.00");
                            MissedCharge.Text = "$" + MissedApptFees.ToString("#,##0.00");
                            LblRehabMes.Text = "$" + RehabDiscount.ToString("#,##0.00");
                            LblTotalDue.Text = "Total Due $ " + (MeterCharges + KWHCharges + PriorBalance + MissedApptFees + AfterFees).ToString("#,##0.00");
                        }
                        else
                        {   // If Ending value is greater than Starting value

                            Meter2KWH.Text = Convert.ToString(Meter2E - Meter2S);
                            Meter1KWH.Text = "0";
                            Meter3KWH.Text = "0";
                            //Double.TryParse(TotalKWUsed.Text, out TotalUsed);
                            TotalKWUsed.Text = Meter2KWH.Text;
                            TotalKWH = Convert.ToDouble(Meter2KWH.Text);
                            KWHCharges = Math.Round(((Convert.ToDouble(TotalKWUsed.Text) * FeePerKWH) / 100), 2);

                            if ((TotalKWH > 7000) && (TotalKWH < 9000))
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.05)) / 100), 2);
                            }
                            else if (TotalKWH > 9000)
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.15)) / 100), 2);
                            }
                            else
                            {
                                TotalDiscount = KWHCharges;
                            }

                            resTestVal = KWHCharges - TotalDiscount; // assigning the discount value 
                            MeterCharges = Math.Round((TotalMeters * Reconnect), 2);
                            LblKWHMes.Text = "$" + (KWHCharges - TotalDiscount).ToString("#,##0.00");
                            KWHCharge.Text = "$" + (KWHCharges - resTestVal).ToString("#,##0.00"); // Taking off the distance value
                            MeterCharge.Text = "$" + MeterCharges.ToString("#,##0.00");
                            AfterCharge.Text = "$" + AfterFees.ToString("#,##0.00");
                            MissedCharge.Text = "$" + MissedApptFees.ToString("#,##0.00");
                            LblRehabMes.Text = "$" + RehabDiscount.ToString("#,##0.00");
                            LblTotalDue.Text = "Total Due $ " + (MeterCharges + KWHCharges + PriorBalance + MissedApptFees + AfterFees).ToString("#,##0.00");
                        }
                    }

                }
                /////////////////////////////////////////////////////////////////////////////////////////////////////
                ////////////////////////////////////////////////////////////////////////////////////////////////////

                //If only meter3 fields were filled

                else if ((string.IsNullOrEmpty(TxBxMerter1S.Text) && string.IsNullOrEmpty(TxBxMerter1E.Text)) &&
                    (string.IsNullOrEmpty(TxBxMerter2S.Text) && string.IsNullOrEmpty(TxBxMerter2E.Text)) &&
                    (!string.IsNullOrEmpty(TxBxMerter3S.Text) && !string.IsNullOrEmpty(TxBxMerter3E.Text)))
                {
                    // Verifying that Meter1, Prior Balance, and Meter Count contain only numeric values
                    if (!double.TryParse(TxBxMerter3S.Text, out Meter3S) || !double.TryParse(TxBxMerter3E.Text, out Meter3E) ||
                        (!string.IsNullOrEmpty(TxBxMCount.Text) && (!int.TryParse(TxBxMCount.Text, out TotalMeters))) ||
                        ((!string.IsNullOrEmpty(TxBxPrior.Text) && (!Double.TryParse(TxBxPrior.Text, out PriorBalance)))))
                    {
                        VerifyInput.Text = "Verify that values are in numeric and 'Meter Count' is an integer";
                        SystemSounds.Beep.Play();
                    }
                    else if (TotalMeters > 1)
                    {
                        VerifyInput.Text = "Meter Count should be 1 when you file only one meter";
                        SystemSounds.Beep.Play();
                    }
                    else if (TotalMeters < 1)
                    {
                        VerifyInput.Text = "Meter Count should not be negative or equal to 0";
                        SystemSounds.Beep.Play();
                    }
                    else if ((Meter3S < 0) || (Meter3E < 0))
                    {
                        VerifyInput.Text = "Meter values should not be negative!!!\nPlease enter positive values only";
                        SystemSounds.Beep.Play();
                    }
                    else
                    {
                        // If values are numeric
                        if (string.IsNullOrEmpty(TxBxPrior.Text))
                        {
                            TxBxPrior.Text = "0.00";
                        }
                        else
                        {
                            PriorBalance = Math.Round(Convert.ToDouble(TxBxPrior.Text), 2);
                        }
                        TotalMeters = 1;

                        if (Meter3S == Meter3E) // If starting value is greater than ending value
                        {
                            VerifyInput.Text = "This case is not handled by this program...";
                            SystemSounds.Beep.Play();
                            Meter1KWH.Text = string.Empty;
                            Meter2KWH.Text = string.Empty;
                            Meter3KWH.Text = string.Empty;
                        }
                        else if ((Meter3S > Meter3E))
                        { // Starting > Ending value
                            testVal = 9999 - Meter3S; // getting the total KWH in the first roll

                            Meter3KWH.Text = Convert.ToString(Meter3E + testVal);
                            Meter1KWH.Text = "0";
                            Meter2KWH.Text = "0";

                            //Double.TryParse(TotalKWUsed.Text, out TotalUsed);
                            TotalKWUsed.Text = Meter3KWH.Text;
                            TotalKWH = Convert.ToDouble(Meter3KWH.Text);

                            KWHCharges = Math.Round(((Convert.ToDouble(TotalKWUsed.Text) * FeePerKWH) / 100), 2);

                            if ((TotalKWH > 7000) && (TotalKWH < 9000))
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.05)) / 100), 2);
                            }
                            else if (TotalKWH > 9000)
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.15)) / 100), 2);
                            }
                            else
                            {
                                TotalDiscount = KWHCharges;
                            }
                            resTestVal = KWHCharges - TotalDiscount; // assigning the discount value 
                            MeterCharges = Math.Round((TotalMeters * Reconnect), 2);
                            LblKWHMes.Text = "$" + (KWHCharges - TotalDiscount).ToString("#,##0.00");
                            KWHCharge.Text = "$" + (KWHCharges - resTestVal).ToString("#,##0.00"); // Taking off the distance value
                            MeterCharge.Text = "$" + MeterCharges.ToString("#,##0.00");
                            AfterCharge.Text = "$" + AfterFees.ToString("#,##0.00");
                            MissedCharge.Text = "$" + MissedApptFees.ToString("#,##0.00");
                            LblRehabMes.Text = "$" + RehabDiscount.ToString("#,##0.00");
                            LblTotalDue.Text = "Total Due $ " + (MeterCharges + KWHCharges + PriorBalance + MissedApptFees + AfterFees).ToString("#,##0.00");
                        }
                        else
                        {   // If Ending value is greater than Starting value

                            Meter3KWH.Text = Convert.ToString(Meter3E - Meter3S);
                            Meter1KWH.Text = "0";
                            Meter2KWH.Text = "0";
                            //Double.TryParse(TotalKWUsed.Text, out TotalUsed);
                            TotalKWUsed.Text = Meter3KWH.Text;
                            TotalKWH = Convert.ToDouble(Meter3KWH.Text);

                            KWHCharges = Math.Round(((Convert.ToDouble(TotalKWUsed.Text) * FeePerKWH) / 100), 2);

                            if ((TotalKWH > 7000) && (TotalKWH < 9000))
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.05)) / 100), 2);
                            }
                            else if (TotalKWH > 9000)
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.15)) / 100), 2);
                            }
                            else
                            {
                                TotalDiscount = KWHCharges;
                            }

                            resTestVal = KWHCharges - TotalDiscount; // assigning the discount value 
                            MeterCharges = Math.Round((TotalMeters * Reconnect), 2);
                            LblKWHMes.Text = "$" + (KWHCharges - TotalDiscount).ToString("#,##0.00");
                            KWHCharge.Text = "$" + (KWHCharges - resTestVal).ToString("#,##0.00"); // Taking off the distance value
                            MeterCharge.Text = "$" + MeterCharges.ToString("#,##0.00");
                            AfterCharge.Text = "$" + AfterFees.ToString("#,##0.00");
                            MissedCharge.Text = "$" + MissedApptFees.ToString("#,##0.00");
                            LblRehabMes.Text = "$" + RehabDiscount.ToString("#,##0.00");
                            LblTotalDue.Text = "Total Due $ " + (MeterCharges + KWHCharges + PriorBalance + MissedApptFees + AfterFees).ToString("#,##0.00");
                        }
                    }

                }
                /////////////////////////////////////////////////////////////////////////////////////////////////////
                ////////////////////////////////////////////////////////////////////////////////////////////////////

                //If meter1 and meter2 fields were filled

                else if ((!string.IsNullOrEmpty(TxBxMerter1S.Text) && !string.IsNullOrEmpty(TxBxMerter1E.Text)) &&
                    (!string.IsNullOrEmpty(TxBxMerter2S.Text) && !string.IsNullOrEmpty(TxBxMerter2E.Text)) &&
                    (string.IsNullOrEmpty(TxBxMerter3S.Text) && string.IsNullOrEmpty(TxBxMerter3E.Text)))
                {
                    // Verifying that Meter1, Prior Balance, and Meter Count contain only numeric values
                    if (!double.TryParse(TxBxMerter1S.Text, out Meter1S) || !double.TryParse(TxBxMerter1E.Text, out Meter1E) ||
                        (!double.TryParse(TxBxMerter2S.Text, out Meter2S) || !double.TryParse(TxBxMerter2E.Text, out Meter2E) ||
                        (!string.IsNullOrEmpty(TxBxMCount.Text) && (!int.TryParse(TxBxMCount.Text, out TotalMeters))) ||
                        ((!string.IsNullOrEmpty(TxBxPrior.Text) && (!Double.TryParse(TxBxPrior.Text, out PriorBalance))))))
                    {
                        VerifyInput.Text = "Verify that values are in numeric and 'Meter Count' is an integer";
                        SystemSounds.Beep.Play();
                    }
                    else if (TotalMeters > 2 || TotalMeters < 2)
                    {
                        VerifyInput.Text = "Meter Count should be 2 when you file two meters";
                        SystemSounds.Beep.Play();
                    }
                    else if (TotalMeters <= 0)
                    {
                        VerifyInput.Text = "Meter Count should not be negative or equal to 0";
                        SystemSounds.Beep.Play();
                    }
                    else if ((Meter1S < 0) || (Meter1E < 0) || (Meter2S < 0) || (Meter2E < 0))
                    {
                        VerifyInput.Text = "Meter values should not be negative!!!\nPlease enter positive values only";
                        SystemSounds.Beep.Play();
                    }
                    else
                    {
                        // If values are numeric
                        if (string.IsNullOrEmpty(TxBxPrior.Text))
                        {
                            TxBxPrior.Text = "0.00";
                        }
                        else
                        {
                            PriorBalance = Math.Round(Convert.ToDouble(TxBxPrior.Text), 2);
                        }
                        TotalMeters = 2;

                        if ((Meter1S == Meter1E) || (Meter2S == Meter2E)) // If starting value is greater than ending value
                        {
                            VerifyInput.Text = "This case is not handled by this program...";
                            SystemSounds.Beep.Play();
                            Meter1KWH.Text = string.Empty;
                            Meter2KWH.Text = string.Empty;
                            Meter3KWH.Text = string.Empty;
                        }
                        else if ((Meter1S > Meter1E) || (Meter2S > Meter2E)) // If starting value is greater than ending value
                        {   // If Ending value is greater than Starting value

                            testVal = 9999 - Meter1S;
                            testVal1 = 9999 - Meter2S;

                            Meter1KWH.Text = Convert.ToString(Meter1E + testVal);
                            Meter2KWH.Text = Convert.ToString(Meter2E + testVal1);
                            Meter3KWH.Text = "0";
                            double totalKWHs = ((Meter1E + testVal) + (Meter2E + testVal1));
                            TotalKWH = totalKWHs;

                            TotalKWUsed.Text = totalKWHs.ToString("f2");
                            KWHCharges = Math.Round(((Convert.ToDouble(TotalKWUsed.Text) * FeePerKWH) / 100), 2);

                            if ((TotalKWH > 7000) && (TotalKWH < 9000))
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.05)) / 100), 2);
                            }
                            else if (TotalKWH > 9000)
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.15)) / 100), 2);
                            }
                            else
                            {
                                TotalDiscount = KWHCharges;
                            }

                            resTestVal = KWHCharges - TotalDiscount; // assigning the discount value 
                            MeterCharges = Math.Round((TotalMeters * Reconnect), 2);
                            LblKWHMes.Text = "$" + (KWHCharges - TotalDiscount).ToString("#,##0.00");
                            KWHCharge.Text = "$" + (KWHCharges - resTestVal).ToString("#,##0.00"); // Taking off the distance value
                            MeterCharge.Text = "$" + MeterCharges.ToString("#,##0.00");
                            AfterCharge.Text = "$" + AfterFees.ToString("#,##0.00");
                            MissedCharge.Text = "$" + MissedApptFees.ToString("#,##0.00");
                            LblRehabMes.Text = "$" + RehabDiscount.ToString("#,##0.00");
                            LblTotalDue.Text = "Total Due $ " + (MeterCharges + KWHCharges + PriorBalance + MissedApptFees + AfterFees).ToString("#,##0.00");
                        }
                        else
                        {   // If Ending value is greater than Starting value

                            Meter1KWH.Text = Convert.ToString(Meter1E - Meter1S);
                            Meter2KWH.Text = Convert.ToString(Meter2E - Meter2S);
                            Meter3KWH.Text = "0";
                            double totalKWHs = ((Meter1E - Meter1S) + (Meter2E - Meter2S));
                            TotalKWH = totalKWHs; 

                            TotalKWUsed.Text = totalKWHs.ToString("f2");
                            KWHCharges = Math.Round(((Convert.ToDouble(TotalKWUsed.Text) * FeePerKWH) / 100), 2);

                            if ((TotalKWH > 7000) && (TotalKWH < 9000))
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.05)) / 100), 2);
                            }
                            else if (TotalKWH > 9000)
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.15)) / 100), 2);
                            }
                            else
                            {
                                TotalDiscount = KWHCharges;
                            }

                            resTestVal = KWHCharges - TotalDiscount; // assigning the discount value 
                            MeterCharges = Math.Round((TotalMeters * Reconnect), 2);
                            LblKWHMes.Text = "$" + (KWHCharges - TotalDiscount).ToString("#,##0.00");
                            KWHCharge.Text = "$" + (KWHCharges - resTestVal).ToString("#,##0.00"); // Taking off the distance value
                            MeterCharge.Text = "$" + MeterCharges.ToString("#,##0.00");
                            AfterCharge.Text = "$" + AfterFees.ToString("#,##0.00");
                            MissedCharge.Text = "$" + MissedApptFees.ToString("#,##0.00");
                            LblRehabMes.Text = "$" + RehabDiscount.ToString("#,##0.00");
                            LblTotalDue.Text = "Total Due $ " + (MeterCharges + KWHCharges + PriorBalance + MissedApptFees + AfterFees).ToString("#,##0.00");
                        }
                    }

                }
                /////////////////////////////////////////////////////////////////////////////////////////////////////
                ////////////////////////////////////////////////////////////////////////////////////////////////////

                //If meter1 and meter3 fields were filled

                else if ((!string.IsNullOrEmpty(TxBxMerter1S.Text) && !string.IsNullOrEmpty(TxBxMerter1E.Text)) &&
                    (string.IsNullOrEmpty(TxBxMerter2S.Text) && string.IsNullOrEmpty(TxBxMerter2E.Text)) &&
                    (!string.IsNullOrEmpty(TxBxMerter3S.Text) && !string.IsNullOrEmpty(TxBxMerter3E.Text)))
                {
                    // Verifying that Meter1, Prior Balance, and Meter Count contain only numeric values
                    if (!double.TryParse(TxBxMerter1S.Text, out Meter1S) || !double.TryParse(TxBxMerter1E.Text, out Meter1E) ||
                        (!double.TryParse(TxBxMerter3S.Text, out Meter3S) || !double.TryParse(TxBxMerter3E.Text, out Meter3E) ||
                        (!string.IsNullOrEmpty(TxBxMCount.Text) && (!int.TryParse(TxBxMCount.Text, out TotalMeters))) ||
                        ((!string.IsNullOrEmpty(TxBxPrior.Text) && (!Double.TryParse(TxBxPrior.Text, out PriorBalance))))))
                    {
                        VerifyInput.Text = "Verify that values are in numeric and 'Meter Count' is an integer";
                        SystemSounds.Beep.Play();
                    }
                    else if (TotalMeters > 2 || TotalMeters < 2)
                    {
                        VerifyInput.Text = "Meter Count should be 2 when you file two meters";
                        SystemSounds.Beep.Play();
                    }
                    else if (TotalMeters <= 0)
                    {
                        VerifyInput.Text = "Meter Count should not be negative or equal to 0";
                        SystemSounds.Beep.Play();
                    }
                    else if ((Meter1S < 0) || (Meter1E < 0) || (Meter3S < 0) || (Meter3E < 0))
                    {
                        VerifyInput.Text = "Meter values should not be negative!!!\nPlease enter positive values only";
                        SystemSounds.Beep.Play();
                    }
                    else
                    {
                        // If values are numeric
                        if (string.IsNullOrEmpty(TxBxPrior.Text))
                        {
                            TxBxPrior.Text = "0.00";
                        }
                        else
                        {
                            PriorBalance = Math.Round(Convert.ToDouble(TxBxPrior.Text), 2);
                        }
                        TotalMeters = 2;

                        if ((Meter1S == Meter1E) || (Meter3S == Meter3E)) // If starting value is greater than ending value
                        {
                            VerifyInput.Text = "This case is not handled by this program...";
                            SystemSounds.Beep.Play();
                            Meter1KWH.Text = string.Empty;
                            Meter2KWH.Text = string.Empty;
                            Meter3KWH.Text = string.Empty;
                        }
                        else if ((Meter1S > Meter1E) || (Meter3S > Meter3E)) // If starting value is greater than ending value
                        {   // If Ending value is greater than Starting value

                            testVal = 9999 - Meter1S;
                            testVal1 = 9999 - Meter3S;

                            Meter1KWH.Text = Convert.ToString(Meter1E + testVal);
                            Meter3KWH.Text = Convert.ToString(Meter3E + testVal1);
                            Meter2KWH.Text = "0";
                            double totalKWHs = ((Meter1E + testVal) + (Meter3E + testVal1));
                            TotalKWH = totalKWHs;

                            TotalKWUsed.Text = totalKWHs.ToString("f2");
                            KWHCharges = Math.Round(((Convert.ToDouble(TotalKWUsed.Text) * FeePerKWH) / 100), 2);

                            if ((TotalKWH > 7000) && (TotalKWH < 9000))
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.05)) / 100), 2);
                            }
                            else if (TotalKWH > 9000)
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.15)) / 100), 2);
                            }
                            else
                            {
                                TotalDiscount = KWHCharges;
                            }

                            resTestVal = KWHCharges - TotalDiscount; // assigning the discount value 
                            MeterCharges = Math.Round((TotalMeters * Reconnect), 2);
                            LblKWHMes.Text = "$" + (KWHCharges - TotalDiscount).ToString("#,##0.00");
                            KWHCharge.Text = "$" + (KWHCharges - resTestVal).ToString("#,##0.00"); // Taking off the distance value
                            MeterCharge.Text = "$" + MeterCharges.ToString("#,##0.00");
                            AfterCharge.Text = "$" + AfterFees.ToString("#,##0.00");
                            MissedCharge.Text = "$" + MissedApptFees.ToString("#,##0.00");
                            LblRehabMes.Text = "$" + RehabDiscount.ToString("#,##0.00");
                            LblTotalDue.Text = "Total Due $ " + (MeterCharges + KWHCharges + PriorBalance + MissedApptFees + AfterFees).ToString("#,##0.00");
                        }
                        else
                        {   // If Ending value is greater than Starting value

                            Meter1KWH.Text = Convert.ToString(Meter1E - Meter1S);
                            Meter2KWH.Text = "0";
                            Meter3KWH.Text = Convert.ToString(Meter3E - Meter3S);
                            double totalKWHs = ((Meter1E - Meter1S) + (Meter3E - Meter3S));
                            TotalKWH = totalKWHs; 

                            TotalKWUsed.Text = totalKWHs.ToString("f2");
                            KWHCharges = Math.Round(((Convert.ToDouble(TotalKWUsed.Text) * FeePerKWH) / 100), 2);

                            if ((TotalKWH > 7000) && (TotalKWH < 9000))
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.05)) / 100), 2);
                            }
                            else if (TotalKWH > 9000)
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.15)) / 100), 2);
                            }
                            else
                            {
                                TotalDiscount = KWHCharges;
                            }

                            resTestVal = KWHCharges - TotalDiscount; // assigning the discount value 
                            MeterCharges = Math.Round((TotalMeters * Reconnect), 2);
                            LblKWHMes.Text = "$" + (KWHCharges - TotalDiscount).ToString("#,##0.00");
                            KWHCharge.Text = "$" + (KWHCharges - resTestVal).ToString("#,##0.00"); // Taking off the distance value
                            MeterCharge.Text = "$" + MeterCharges.ToString("#,##0.00");
                            AfterCharge.Text = "$" + AfterFees.ToString("#,##0.00");
                            MissedCharge.Text = "$" + MissedApptFees.ToString("#,##0.00");
                            LblRehabMes.Text = "$" + RehabDiscount.ToString("#,##0.00");
                            LblTotalDue.Text = "Total Due $ " + (MeterCharges + KWHCharges + PriorBalance + MissedApptFees + AfterFees).ToString("#,##0.00");
                        }
                    }

                }
                /////////////////////////////////////////////////////////////////////////////////////////////////////
                ////////////////////////////////////////////////////////////////////////////////////////////////////

                //If meter3 and meter2 fields were filled

                else if ((string.IsNullOrEmpty(TxBxMerter1S.Text) && string.IsNullOrEmpty(TxBxMerter1E.Text)) &&
                    (!string.IsNullOrEmpty(TxBxMerter2S.Text) && !string.IsNullOrEmpty(TxBxMerter2E.Text)) &&
                    (!string.IsNullOrEmpty(TxBxMerter3S.Text) && !string.IsNullOrEmpty(TxBxMerter3E.Text)))
                {
                    // Verifying that Meter1, Prior Balance, and Meter Count contain only numeric values
                    if (!double.TryParse(TxBxMerter3S.Text, out Meter3S) || !double.TryParse(TxBxMerter3E.Text, out Meter3E) ||
                        (!double.TryParse(TxBxMerter2S.Text, out Meter2S) || !double.TryParse(TxBxMerter2E.Text, out Meter2E) ||
                        (!string.IsNullOrEmpty(TxBxMCount.Text) && (!int.TryParse(TxBxMCount.Text, out TotalMeters))) ||
                        ((!string.IsNullOrEmpty(TxBxPrior.Text) && (!Double.TryParse(TxBxPrior.Text, out PriorBalance))))))
                    {
                        VerifyInput.Text = "Verify that values are in numeric and 'Meter Count' is an integer";
                        SystemSounds.Beep.Play();
                    }
                    else if (TotalMeters > 2 || TotalMeters < 2)
                    {
                        VerifyInput.Text = "Meter Count should be 2 when you file two meters";
                        SystemSounds.Beep.Play();
                    }
                    else if (TotalMeters <= 0)
                    {
                        VerifyInput.Text = "Meter Count should not be negative or equal to 0";
                        SystemSounds.Beep.Play();
                    }
                    else if ((Meter3S < 0) || (Meter3E < 0) || (Meter2S < 0) || (Meter2E < 0))
                    {
                        VerifyInput.Text = "Meter values should not be negative!!!\nPlease enter positive values only";
                        SystemSounds.Beep.Play();
                    }
                    else
                    {
                        // If values are numeric
                        if (string.IsNullOrEmpty(TxBxPrior.Text))
                        {
                            TxBxPrior.Text = "0.00";
                        }
                        else
                        {
                            PriorBalance = Math.Round(Convert.ToDouble(TxBxPrior.Text), 2);
                        }
                        TotalMeters = 2;

                        if ((Meter3S == Meter3E) || (Meter2S == Meter2E)) // If starting value is greater than ending value
                        {
                            VerifyInput.Text = "This case is not handled by this program...";
                            SystemSounds.Beep.Play();
                            Meter1KWH.Text = string.Empty;
                            Meter2KWH.Text = string.Empty;
                            Meter3KWH.Text = string.Empty;
                        }
                            else if ((Meter3S > Meter3E) || (Meter2S > Meter2E))
                            {   // If Ending value is greater than Starting value

                            testVal = 9999 - Meter2S;
                            testVal1 = 9999 - Meter3S;

                            Meter2KWH.Text = Convert.ToString(Meter2E + testVal);
                            Meter3KWH.Text = Convert.ToString(Meter3E + testVal1);
                            Meter1KWH.Text = "0";
                            double totalKWHs = ((Meter2E + testVal) + (Meter3E + testVal1));
                            TotalKWH = totalKWHs;

                            TotalKWUsed.Text = totalKWHs.ToString("f2");
                            KWHCharges = Math.Round(((Convert.ToDouble(TotalKWUsed.Text) * FeePerKWH) / 100), 2);

                            if ((TotalKWH > 7000) && (TotalKWH < 9000))
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.05)) / 100), 2);
                            }
                            else if (TotalKWH > 9000)
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.15)) / 100), 2);
                            }
                            else
                            {
                                TotalDiscount = KWHCharges;
                            }

                            resTestVal = KWHCharges - TotalDiscount; // assigning the discount value 
                            MeterCharges = Math.Round((TotalMeters * Reconnect), 2);
                            LblKWHMes.Text = "$" + (KWHCharges - TotalDiscount).ToString("#,##0.00");
                            KWHCharge.Text = "$" + (KWHCharges - resTestVal).ToString("#,##0.00"); // Taking off the distance value
                            MeterCharge.Text = "$" + MeterCharges.ToString("#,##0.00");
                            AfterCharge.Text = "$" + AfterFees.ToString("#,##0.00");
                            MissedCharge.Text = "$" + MissedApptFees.ToString("#,##0.00");
                            LblRehabMes.Text = "$" + RehabDiscount.ToString("#,##0.00");
                            LblTotalDue.Text = "Total Due $ " + (MeterCharges + KWHCharges + PriorBalance + MissedApptFees + AfterFees).ToString("#,##0.00");
                        }
                        else
                        {   // If Ending value is greater than Starting value

                            Meter1KWH.Text = "0";
                            Meter2KWH.Text = Convert.ToString(Meter2E - Meter2S);
                            Meter3KWH.Text = Convert.ToString(Meter3E - Meter3S);
                            double totalKWHs = ((Meter3E - Meter3S) + (Meter2E - Meter2S));
                            TotalKWH = totalKWHs; 

                            TotalKWUsed.Text = totalKWHs.ToString("f2");
                            KWHCharges = Math.Round(((Convert.ToDouble(TotalKWUsed.Text) * FeePerKWH) / 100), 2);

                            if ((TotalKWH > 7000) && (TotalKWH < 9000))
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.05)) / 100), 2);
                            }
                            else if (TotalKWH > 9000)
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.15)) / 100), 2);
                            }
                            else
                            {
                                TotalDiscount = KWHCharges;
                            }

                            resTestVal = KWHCharges - TotalDiscount; // assigning the discount value 
                            MeterCharges = Math.Round((TotalMeters * Reconnect), 2);
                            LblKWHMes.Text = "$" + (KWHCharges - TotalDiscount).ToString("#,##0.00");
                            KWHCharge.Text = "$" + (KWHCharges - resTestVal).ToString("#,##0.00"); // Taking off the distance value
                            MeterCharge.Text = "$" + MeterCharges.ToString("#,##0.00");
                            AfterCharge.Text = "$" + AfterFees.ToString("#,##0.00");
                            MissedCharge.Text = "$" + MissedApptFees.ToString("#,##0.00");
                            LblRehabMes.Text = "$" + RehabDiscount.ToString("#,##0.00");
                            LblTotalDue.Text = "Total Due $ " + (MeterCharges + KWHCharges + PriorBalance + MissedApptFees + AfterFees).ToString("#,##0.00");
                        }
                    }

                }
                /////////////////////////////////////////////////////////////////////////////////////////////////////
                ////////////////////////////////////////////////////////////////////////////////////////////////////

                //If meter1, meter2, and meter3 fields were filled

                else if ((!string.IsNullOrEmpty(TxBxMerter1S.Text) && !string.IsNullOrEmpty(TxBxMerter1E.Text)) &&
                    (!string.IsNullOrEmpty(TxBxMerter2S.Text) && !string.IsNullOrEmpty(TxBxMerter2E.Text)) &&
                    (!string.IsNullOrEmpty(TxBxMerter3S.Text) && !string.IsNullOrEmpty(TxBxMerter3E.Text)))
                {
                    // Verifying that Meter1, Prior Balance, and Meter Count contain only numeric values
                    if (!double.TryParse(TxBxMerter1S.Text, out Meter1S) || !double.TryParse(TxBxMerter1E.Text, out Meter1E) ||
                        (!double.TryParse(TxBxMerter2S.Text, out Meter2S) || !double.TryParse(TxBxMerter2E.Text, out Meter2E) ||
                        (!double.TryParse(TxBxMerter3S.Text, out Meter3S) || !double.TryParse(TxBxMerter3E.Text, out Meter3E) ||
                        (!string.IsNullOrEmpty(TxBxMCount.Text) && (!int.TryParse(TxBxMCount.Text, out TotalMeters))) ||
                        ((!string.IsNullOrEmpty(TxBxPrior.Text) && (!Double.TryParse(TxBxPrior.Text, out PriorBalance)))))))
                    {
                        VerifyInput.Text = "Verify that values are in numeric and 'Meter Count' is an integer";
                        SystemSounds.Beep.Play();
                    }
                    else if (TotalMeters > 3 || TotalMeters < 3)
                    {
                        VerifyInput.Text = "Meter Count should be 3 when you file all three meters";
                        SystemSounds.Beep.Play();
                    }
                    else if (TotalMeters <= 0)
                    {
                        VerifyInput.Text = "Meter Count should not be negative or equal to 0";
                        SystemSounds.Beep.Play();
                    }
                    else if ((Meter1S < 0) || (Meter1E < 0) || (Meter2S < 0) || (Meter2E < 0) || (Meter3S < 0) || (Meter3E < 0))
                    {
                        VerifyInput.Text = "Meter values should not be negative!!!\nPlease enter positive values only";
                        SystemSounds.Beep.Play();
                    }
                    else
                    {
                        // If values are numeric
                        if (string.IsNullOrEmpty(TxBxPrior.Text))
                        {
                            TxBxPrior.Text = "0.00";
                        }
                        else
                        {
                            PriorBalance = Math.Round(Convert.ToDouble(TxBxPrior.Text), 2);
                        }
                        TotalMeters = 3;

                        if ((Meter1S == Meter1E) || (Meter2S == Meter2E) || (Meter3S == Meter3E)) // If starting value is greater than ending value
                        {
                            VerifyInput.Text = "This case is not handled by this program...";
                            SystemSounds.Beep.Play();
                            Meter1KWH.Text = string.Empty;
                            Meter2KWH.Text = string.Empty;
                            Meter3KWH.Text = string.Empty;
                        }
                        else if ((Meter1S > Meter1E) || (Meter2S > Meter2E) || (Meter3S > Meter3E)) // If starting value is greater than ending value
                         {   // If Ending value is greater than Starting value

                            testVal = 9999 - Meter1S;
                            testVal1 = 9999 - Meter2S;
                            testVal2 = 9999 - Meter3S;

                            Meter2KWH.Text = Convert.ToString(Meter2E + testVal1);
                            Meter3KWH.Text = Convert.ToString(Meter3E + testVal2);
                            Meter1KWH.Text = Convert.ToString(Meter1E + testVal);
                            double totalKWHs = ((Meter2E + testVal1) + (Meter3E + testVal2) + (Meter1E + testVal));
                            TotalKWH = totalKWHs;

                            TotalKWUsed.Text = totalKWHs.ToString("f2");
                            KWHCharges = Math.Round(((Convert.ToDouble(TotalKWUsed.Text) * FeePerKWH) / 100), 2);

                            if ((TotalKWH > 7000) && (TotalKWH < 9000))
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.05)) / 100), 2);
                            }
                            else if (TotalKWH > 9000)
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.15)) / 100), 2);
                            }
                            else
                            {
                                TotalDiscount = KWHCharges;
                            }

                            resTestVal = KWHCharges - TotalDiscount; // assigning the discount value 
                            MeterCharges = Math.Round((TotalMeters * Reconnect), 2);
                            LblKWHMes.Text = "$" + (KWHCharges - TotalDiscount).ToString("#,##0.00");
                            KWHCharge.Text = "$" + (KWHCharges - resTestVal).ToString("#,##0.00"); // Taking off the distance value
                            MeterCharge.Text = "$" + MeterCharges.ToString("#,##0.00");
                            AfterCharge.Text = "$" + AfterFees.ToString("#,##0.00");
                            MissedCharge.Text = "$" + MissedApptFees.ToString("#,##0.00");
                            LblRehabMes.Text = "$" + RehabDiscount.ToString("#,##0.00");
                            LblTotalDue.Text = "Total Due $ " + (MeterCharges + KWHCharges + PriorBalance + MissedApptFees + AfterFees).ToString("#,##0.00");
                        }
                        else
                        {   // If Ending value is greater than Starting value

                            Meter1KWH.Text = Convert.ToString(Meter1E - Meter1S);
                            Meter2KWH.Text = Convert.ToString(Meter2E - Meter2S);
                            Meter3KWH.Text = Convert.ToString(Meter3E - Meter3S);
                            double totalKWHs = ((Meter1E - Meter1S) + (Meter2E - Meter2S) + (Meter3E - Meter3S));
                            TotalKWH = totalKWHs; 

                            TotalKWUsed.Text = totalKWHs.ToString("f2");
                            KWHCharges = Math.Round(((Convert.ToDouble(TotalKWUsed.Text) * FeePerKWH) / 100), 2);

                            if ((TotalKWH > 7000) && (TotalKWH < 9000))
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.05)) / 100), 2);
                            }
                            else if (TotalKWH > 9000)
                            {
                                TotalDiscount = Math.Round(((TotalKWH * (FeePerKWH - 0.15)) / 100), 2);
                            }
                            else
                            {
                                TotalDiscount = KWHCharges;
                            }

                            resTestVal = KWHCharges - TotalDiscount; // assigning the discount value 
                            MeterCharges = Math.Round((TotalMeters * Reconnect), 2);
                            LblKWHMes.Text = "$" + (KWHCharges - TotalDiscount).ToString("#,##0.00");
                            KWHCharge.Text = "$" + (KWHCharges - resTestVal).ToString("#,##0.00"); // Taking off the distance value
                            MeterCharge.Text = "$" + MeterCharges.ToString("#,##0.00");
                            AfterCharge.Text = "$" + AfterFees.ToString("#,##0.00");
                            MissedCharge.Text = "$" + MissedApptFees.ToString("#,##0.00");
                            LblRehabMes.Text = "$" + RehabDiscount.ToString("#,##0.00");
                            LblTotalDue.Text = "Total Due $ " + (MeterCharges + KWHCharges + PriorBalance + MissedApptFees + AfterFees).ToString("#,##0.00");
                        }
                    }

                }
                /////////////////////////////////////////////////////////////////////////////////////////////////////
                ////////////////////////////////////////////////////////////////////////////////////////////////////

                else
                {
                    VerifyInput.Text = "Please verify that no meter has a missing value to continue ";
                    SystemSounds.Beep.Play();
                }

            }
            else  // If none of the meters contains all its values
            {
                VerifyInput.Text = "Please verify that at least one meter has all its values";
                SystemSounds.Beep.Play();
            }
        
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblMeterCount_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //Clearing text boxes
            TxBxMerter1S.Text = string.Empty;
            TxBxMerter1E.Text = string.Empty;

            TxBxMerter2S.Text = string.Empty;
            TxBxMerter2E.Text = string.Empty;

            TxBxMerter3S.Text = string.Empty;
            TxBxMerter3E.Text = string.Empty;

            TxBxMCount.Text = string.Empty;
            TxBxPrior.Text = string.Empty;

            //Clearing labels outputs
            Meter1KWH.Text = string.Empty;
            Meter2KWH.Text = string.Empty;
            Meter3KWH.Text = string.Empty;

            TotalKWUsed.Text = string.Empty;
            MeterCharge.Text = string.Empty;
            AfterCharge.Text = string.Empty;
            MissedCharge.Text = string.Empty;
            VerifyInput.Text = string.Empty;
            KWHCharge.Text = string.Empty;
            LblKWHMes.Text = string.Empty;
            LblRehabMes.Text = string.Empty;

            LblTotalDue.Text = string.Empty;
           
        }

        private void BtnRecalc_Click(object sender, EventArgs e)
        {
            RehabDiscount = 0.0;
            MissedApptFees = 0.0;
            AfterFees = 0.0;
            Calc(); // Function call
        }

        private void BtnMissed_Click(object sender, EventArgs e)
        {
            if (button)
            {
                MissedApptFees = 25.0;
                Calc(); //Function call
                button = false;
            }
            else
            {
                MissedApptFees = 0.0;
                Calc(); //Function call
                button = true;
            }
        }

        private void BtnAfter_Click(object sender, EventArgs e)
        {
            if (button)
            {
                AfterFees = 50.0;
                Calc(); //Function call
                button = false;
            }
            else
            {
                AfterFees = 0.0;
                Calc(); //Function call
                button = true;
            }
        }

        private void BtnRehab_Click(object sender, EventArgs e)
        {
            if (button)
            {
                double val = AfterFees + MissedApptFees + (TotalMeters * Reconnect);
                if (val >= 55.0)
                {
                    RehabDiscount = Math.Abs(((TotalMeters * Reconnect) + AfterFees + MissedApptFees) - 55.0);
                    Calc();
                    button = false;
                }
                else {
                    RehabDiscount = 0;
                    Calc();
                    button = false;
                }
            }
            else
            {
                RehabDiscount = 0;
                Calc();
                button = true;
            }
        }
    }
}
