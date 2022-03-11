using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewItems.PageObject
{
    public class ElementList
    {
        // Below is Search box Element
        public static string Searchbox() {

            return "//input[@id='twotabsearchtextbox']";
        
        }

        // Below is First Search result element
        public static string FirstSeachElement()
        {

            return "(//*[@class='a-size-medium a-color-base a-text-normal'])[1]";

        }

        // Below is corresponding laptop price element
        public static string LaptopPriceElement()
        {

            return "(//span[@aria-hidden='true'])[4]";

        }
    }
}
