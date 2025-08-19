using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pizza
{
    public partial class PizzaHub : Form
    {
        int Quantity = 1;
        public PizzaHub()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        ///////////////////////////////////////////////////// Total ////////////////

        void UpdateTotalPrice()
        {

            lblPrice.Text = "$" + CalculateTotalPrice().ToString();

        }

        int CalculateTotalPrice()
        {
            return (GetSelectedSizePrice() + GetSelectedCrustPrice() + GetSelectedToppingsPrice());
        }


        ///////////////////////////////////////////////////// Size ////////////////

        int GetSelectedSizePrice()
        {
            if (rbSmall.Checked) return  Convert.ToInt32(rbSmall.Tag) * Quantity;
            else if (rbMedium.Checked) return  Convert.ToInt32(rbMedium.Tag) * Quantity;
            else if (rbLarge.Checked) return  Convert.ToInt32(rbLarge.Tag) * Quantity;
            else return  Convert.ToInt32(rbExtraLarge.Tag) * Quantity;
        }

        void UpdateSize()
        {
            UpdateTotalPrice();
            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }
            if (rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }
            if (rbLarge.Checked)
            {
                lblSize.Text = "Larg";
                return;
            }
            if (rbExtraLarge.Checked)
            {
                lblSize.Text = "Extra Large";
                return;
            }

        }



        ///////////////////////////////////////////////////// Crust ////////////////

        int GetSelectedCrustPrice()
        {
            if (rbThinCrust.Checked) return Convert.ToInt32(rbThinCrust.Tag) * Quantity;
            else if (rbRegularCrust.Checked) return Convert.ToInt32(rbRegularCrust.Tag) * Quantity;
            else if (rbThickCrust.Checked) return Convert.ToInt32(rbThickCrust.Tag) * Quantity;
            else return Convert.ToInt32(rbStuffedCrust.Tag) * Quantity;
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbThinCrust.Checked)
            {
                lblCrustTypes.Text = "Thin Crust";
                return;
            }
            if (rbRegularCrust.Checked)
            {
                lblCrustTypes.Text = "Regular Crust";
                return;
            }
            if (rbThickCrust.Checked)
            {
                lblCrustTypes.Text = "Thick Crust";
                return;
            }
            if (rbStuffedCrust.Checked)
            {
                lblCrustTypes.Text = "Stuffed Crust";
                return;
            }
        }

        ///////////////////////////////////////////////////// Toppings ////////////////

        int GetSelectedToppingsPrice()
        {
            int ToppingsPrice = 0;
            if (chkExtraCheese.Checked) ToppingsPrice += Convert.ToInt32(chkExtraCheese.Tag) * Quantity;
            if (chkOnions.Checked) ToppingsPrice += Convert.ToInt32(chkOnions.Tag) * Quantity;
            if (chkOlives.Checked) ToppingsPrice += Convert.ToInt32(chkOlives.Tag) * Quantity;
            if (chkMushrooms.Checked) ToppingsPrice += Convert.ToInt32(chkMushrooms.Tag) * Quantity;
            if (chkTomatoes.Checked) ToppingsPrice += Convert.ToInt32(chkTomatoes.Tag) * Quantity;
            if (chkGreenPeppers.Checked) ToppingsPrice += Convert.ToInt32(chkGreenPeppers.Tag) * Quantity;
            if (chkRedPeppers.Checked) ToppingsPrice += Convert.ToInt32(chkRedPeppers.Tag) * Quantity;
            if (chkPepperoni.Checked) ToppingsPrice += Convert.ToInt32(chkPepperoni.Tag) * Quantity;
            if (chkChicken.Checked) ToppingsPrice += Convert.ToInt32(chkChicken.Tag) * Quantity;
            if (chkSausage.Checked) ToppingsPrice += Convert.ToInt32(chkSausage.Tag) * Quantity;
            if (chkBacon.Checked) ToppingsPrice += Convert.ToInt32(chkBacon.Tag) * Quantity;
            if (chkFreshBasil.Checked) ToppingsPrice += Convert.ToInt32(chkFreshBasil.Tag) * Quantity;
            if (chkJalapenos.Checked) ToppingsPrice += Convert.ToInt32(chkJalapenos.Tag) * Quantity;
            if (chkSweetCorn.Checked) ToppingsPrice += Convert.ToInt32(chkSweetCorn.Tag) * Quantity;

            return ToppingsPrice;
        }

        void UpdateToppings()
        {
            string addedToppings = "";
            UpdateTotalPrice();

            if (chkExtraCheese.Checked) addedToppings += chkExtraCheese.Text + ", ";
            if (chkOnions.Checked) addedToppings += chkOnions.Text + ", ";
            if (chkOlives.Checked) addedToppings += chkOlives.Text + ", ";
            if (chkMushrooms.Checked) addedToppings += chkMushrooms.Text + ", ";
            if (chkTomatoes.Checked) addedToppings += chkTomatoes.Text + ", ";
            if (chkGreenPeppers.Checked) addedToppings += chkGreenPeppers.Text + ", ";
            if (chkRedPeppers.Checked) addedToppings += chkRedPeppers.Text + ", ";
            if (chkPepperoni.Checked) addedToppings += chkPepperoni.Text + ", ";
            if (chkChicken.Checked) addedToppings += chkChicken.Text + ", ";
            if (chkSausage.Checked) addedToppings += chkSausage.Text + ", ";
            if (chkBacon.Checked) addedToppings += chkBacon.Text + ", ";
            if (chkFreshBasil.Checked) addedToppings += chkFreshBasil.Text + ", ";
            if (chkJalapenos.Checked) addedToppings += chkJalapenos.Text + ", ";
            if (chkSweetCorn.Checked) addedToppings += chkSweetCorn.Text + ", ";

            if (!string.IsNullOrEmpty(addedToppings))
            {
                addedToppings = addedToppings.Substring(0, addedToppings.Length - 2) + ".";
            }
            else
            {
                addedToppings = "None";
            }

            lblToppings.Text = addedToppings;
        }


        ///////////////////////////////////////////////////// Where to Eat ////////////////


        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
                gbAddress.Enabled = false;
                lblDelivery.Visible = false;
                lblDeliverTo.Visible = false;
                tbAddress.Text = string.Empty;
                tbZIP.Text = string.Empty;
                return;
            }
            if (rbTakeaway.Checked)
            {
                lblWhereToEat.Text = "Takeaway";
                gbAddress.Enabled = false;
                lblDelivery.Visible = false;
                lblDeliverTo.Visible = false;
                tbAddress.Text = string.Empty;
                tbZIP.Text = string.Empty;
                return;
            }
            if (rbDelevery.Checked)
            {
                lblWhereToEat.Text = "Delevery";
                gbAddress.Enabled = true;
                lblDelivery.Visible = true;
                lblDeliverTo.Visible = true;

                return;
            }
        }


        ///////////////////////////////////////////////////// Size RB ////////////////

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateSize();

        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateSize();

        }

        private void rbExtraLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }


        //////////////////////////////////////////////// Crust RB ////////////////

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateCrust();
        }

        private void rbRegularCrust_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateCrust();

        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateCrust();

        }

        private void rbStuffedCrust_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateCrust();

        }



        //////////////////////////////////////////////// Where to Eat RB ////////////////

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeaway_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();

        }

        private void rbDelevery_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();

        }

        private void rbDelevery_CheckedChanged567(object sender, EventArgs e)
        {
            UpdateWhereToEat();
            lblDeliverTo.Text = "It will be delevet to: \n" + tbAddress.Text + "\n" + tbZIP.Text;

        }

        ///////////////////////////////////////////////// Toppings CHK ////////////////

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateToppings();
        }

        private void chkOnions_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateToppings();

        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateToppings();

        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateToppings();

        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateToppings();

        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateToppings();

        }

        private void chkRedPeppers_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateToppings();
        }

        private void chkPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateToppings();

        }

        private void chkChicken_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateToppings();

        }

        private void chkSausage_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateToppings();

        }

        private void chkBacon_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateToppings();

        }

        private void chkFreshBasil_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateToppings();

        }

        private void chkJalapenos_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateToppings();

        }

        private void chkSweetCorn_CheckedChanged(object sender, EventArgs e)
        {
            tbQuantity_TextChanged(sender, e);

            UpdateToppings();

        }



        /////////////////////////////// UpdateOrderSummary  ////////////////

        void UpdateOrderSummary()
        {
            tbQuantity.Text = "1";
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();

        }



        ////////////////////////////////////////////////// Buttons  ////////////////

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetForm();
        }


        ////////////////////////////////////////////////// Text Box  ////////////////

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            lblDeliverTo.Text = tbAddress.Text + "\n" +tbZIP.Text;
        }

        private void tbZIP_TextChanged(object sender, EventArgs e)
        {
            lblDeliverTo.Text = tbAddress.Text + "\n" + tbZIP.Text;
        }


        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //
            }

            if (char.IsDigit(e.KeyChar) && tbQuantity.Text.Length >= 2)
            {
                e.Handled = true;
            }
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
             if (tbQuantity.Text.ToString() != string.Empty )
            {
                Quantity = Convert.ToInt32(tbQuantity.Text);
            }
            lblPrice.Text = "$" + CalculateTotalPrice();

        }

        private void btnConfirmOrder_Click_1(object sender, EventArgs e)
        {

            if (rbDelevery.Checked) // Delivery
            {
                if (string.IsNullOrWhiteSpace(tbAddress.Text) ||
                    string.IsNullOrWhiteSpace(tbZIP.Text))
                {
                    MessageBox.Show("Please enter your street address and ZIP/City.",
                                    "Missing address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    (string.IsNullOrWhiteSpace(tbAddress.Text) ? tbAddress : tbZIP).Focus();
                    return;
                }
            }
            if (MessageBox.Show("Confirm Order", "Confirm",MessageBoxButtons.OKCancel,     MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnConfirmOrder.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbCrustTypes.Enabled = false;
                gbWhereToEat.Enabled = false;

            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        ////////////////////////////////////////////////// Reset   ////////////////

        void ResetForm()
        {

            //reset Groups
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbCrustTypes.Enabled = true;
            gbWhereToEat.Enabled = true;

            //reset Size
            rbMedium.Checked = true;

            //reset Toppings.
            chkExtraCheese.Checked = false;
            chkOnions.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkGreenPeppers.Checked = false;
            chkRedPeppers.Checked = false;
            chkTomatoes.Checked = false;
            chkPepperoni.Checked = false;
            chkChicken.Checked = false;
            chkSausage.Checked = false;
            chkBacon.Checked = false;
            chkFreshBasil.Checked = false; 
            chkJalapenos.Checked = false;
            chkSweetCorn.Checked = false;

            //reset CrustType
            rbRegularCrust.Checked = true;

            //reset Where to Eat
            rbEatIn.Checked = true;

            //Reset Order Button
            btnConfirmOrder.Enabled = true;
            tbQuantity.Text = "1";
        }


    }
}
