using MyFirstWebAPI.Controllers;
using OCR_Implementation.Models.FormType;
using System.Reflection;

namespace OCR_Implementation.Models
{
    public class FormFactory
    {
        private FormFactory() { }   
        
        private static FormFactory factory;
        public static FormFactory GetFactory() 
        { 
            if(factory==null)
            {
                return new FormFactory();
            }
            return factory; 
        }
       
        public IFormType GetForm(string type)
        {
           
            Dictionary<string, string> form = OCRController.Configuration.GetSection("FormsDictionary").GetChildren().ToDictionary(x => x.Key, x => x.Value);

            if(form.Keys.Contains(type))
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                string find = form[type];
                Type t = assembly.GetType(find);
                object nm = Activator.CreateInstance(t);

                return (IFormType)nm;
            }
            else throw new NotImplementedException("Error Reading the form");
        }

    }
}
