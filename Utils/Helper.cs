using EntityEXP02.Models;

namespace EntityEXP02.Utils
{
    public class Helper : IHelper
    {

        
            public void filewrite(Shop txt)
            {

                StreamWriter st = new StreamWriter(@"D:\Projects\EntityEXP02\Static\" + txt.item + ".txt");
                st.WriteLine("Item name :" + txt.item);
                st.WriteLine("Colour of item :" + txt.color);
                st.WriteLine("Price of item :" + txt.rate.ToString());
                st.Close();
            }
        }
    }

