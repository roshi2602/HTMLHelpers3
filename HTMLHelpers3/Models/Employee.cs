using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTMLHelpers3.Models
{
    //Edit HTMLHelper- is used to generate HTML input elements based on data type  we supplied
    //Editor() HTML Helper method for simple type view and EditorFor() HTML Helper method for strongly type view to generate HTML elements based on the data type of the model object’s property.
   //ex=string -<input type="text>
   //int - <input type="number">
    public class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        //boolean data type
        public bool newEnrollment { get; set; }
        //Datetime data type
        public DateTime DOB { get; set; }
    }
}