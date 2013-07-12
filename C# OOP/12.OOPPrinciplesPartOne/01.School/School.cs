using System;
using System.Collections.Generic;

namespace School
{
    public class School
    {
        private string name;

        public School(string schoolName)
        {
            this.name = schoolName;
        }

        #region Properties

        //there is no school without name, right?
        public string Name
        {
            get { return name; }
        }

        #endregion
    }
}