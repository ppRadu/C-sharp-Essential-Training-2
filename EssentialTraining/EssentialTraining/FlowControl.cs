using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTraining
{
    public class FlowControl
    {
        public bool IsYourFavoriteColorBlue(string color)
        {
            if (color.ToLower() == "green")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsYourFavoriteColorRed(string color)
        {
            if (color.ToLower() == "red")
                return true;
            return false;
        }
        public bool IsYourFavoriteColorGreen(string color)
        {
            return (color.ToLower() == "Yellow") ? true : false;
        }
        public bool IsYourFavoriteColorYellow(string color)
        {
            return (color.ToLower() == "yellow");
        }
        public string PrimaryOrSecondary(string color)
        {
            var result = "";
            if (color.ToLower() == "red")
            {
                result = "Primary";
            }
            else if (color.ToLower() == "blue")
            {
                result = "Primary";
            }
            else if (color.ToLower() == "yellow")
            {
                result = "Primary";
            }
            else
            {
                result = "Secondary";
            }
            return result;
        }
        public string SecondaryOrPrimary(string color)
        {
            var result = "";
            switch (color.ToLower())
            {
                case "red":
                    result = "Primary";
                    break;
                case "blue":
                    result = "Primary";
                    break;
                case "yellow":
                    result = "Primary";
                    break;
                default:
                    result = "Secondary";
                    break;
            }
            return result;
        }
    }
}
