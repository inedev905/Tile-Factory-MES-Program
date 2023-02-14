using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project_DTO;


namespace Team2_Project.Utils
{
    class CommonCodeUtil
    {
        public static void ComboBinding(ComboBox cbo, List<CodeDTO> src
                                        , string category
                                        , bool blankItem = true, string blankText = "선택")
        {
            var list = src.FindAll((c) => c.Category == category);

            if (blankItem)
            {
                CodeDTO newItem = new CodeDTO()
                {
                    Category = category,
                    Code = "",
                    Name = blankText
                };
                list.Insert(0, newItem);
            }

            cbo.DisplayMember = "Name";
            cbo.ValueMember = "Code";
            cbo.DataSource = list;
        }

        public static bool IsPhoneNumber(string input)
        {
            string phonePattern = @"\d{2,3}-\d{3,4}-\d{4}";
            if (!Regex.IsMatch(input, phonePattern))
                return false;
            else
                return true;
        }

        public static Image ByteToImage(byte[] data)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            return (Bitmap)tc.ConvertFrom(data);
        }

        //image => byte[]
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter ic = new ImageConverter();
            return (byte[])ic.ConvertTo(img, typeof(byte[]));
        }

        public static void UseAdminComboBinding(ComboBox cbo, bool blankItem = true, string blankText = "전체")
        {
            if (blankItem)
            {
                cbo.Items.Add("전체");
            }
            cbo.Items.Add("예");
            cbo.Items.Add("아니오");
        }
        public static void UseYNComboBinding(ComboBox cbo, bool blankItem = true, string blankText = "전체")
        {
            if (blankItem)
            {
                cbo.Items.Add("전체");                
            }
            cbo.Items.Add("예");
            cbo.Items.Add("아니오");
        }
    }
}
