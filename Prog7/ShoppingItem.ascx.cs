using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program6.Prog7
{
    public partial class Prog7_ShoppingItem : System.Web.UI.UserControl
    {
        private string _theID, _theName;
        private double _thePrice, _theCost;
        private int _theQuantity;

        public string TheID
        {
            set
            {
                _theID = value.ToString();
            }
            get
            {
                return _theID;
            }
        }
        public string TheName
        {
            set
            {
                _theName = value.ToString();
            }
            get
            {
                return _theName;
            }
        }

        public string ThePrice
        {
            set
            {
                _thePrice = Convert.ToDouble(value);
            }
            get
            {
                return _thePrice.ToString();
            }
        }
        public string TheCost
        {
            set
            {
                _theCost = Convert.ToDouble(value);
            }
            get
            {
                return _theCost.ToString();
            }
        }
        public int TheQuantity
        {
            set
            {
                _theQuantity = value;
            }
            get
            {
                return _theQuantity;
            }
        }

        //Instance of delegate used in declaring event.
        public event ItemChangedHandler ItemChanged;

        //Declaration of delegate.
        public delegate void ItemChangedHandler(object x, bool valid);


        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            txtID.Text = _theID;
            txtName.Text = _theName;
            txtPrice.Text = string.Format("{0:C}", _thePrice);
            txtQuantity.Text = _theQuantity.ToString();
            txtCost.Text = string.Format("{0:C}", _theCost);
        }
    }
}