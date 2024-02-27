using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleLanguages.App
{
    public enum Lang
    {
        ar, en, fr
    }
    public class ChangeLang
    {

        public static Lang lang = Lang.ar;
        private static JObject SetLang(Lang lang)
        {
            string filePath = Application.StartupPath + $"/languages/{lang.ToString()}.json";
            string jsonText = File.ReadAllText(filePath, Encoding.UTF8);
            var json = JsonConvert.DeserializeObject(jsonText);
            var data = JObject.Parse(json.ToString());
            return data;
        }

        public static JObject GetLangProperties(Form form)
        {
            if (ChangeLang.lang == Lang.ar)
            {
                form.RightToLeft = RightToLeft.Yes;
                form.RightToLeftLayout = true;
            }
            else
            {
                form.RightToLeft = RightToLeft.No;
                form.RightToLeftLayout = false;
            }
            return SetLang(lang);
        }
    }
}
