﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class Department
    {
        private int code;
        private string name;
        private int dept_mng_id;
        private string mngFName;
        private string mngLName;
        private int product_num;
        private string category;

        public int Dept_mng_id
        {
            get { return this.dept_mng_id; }
        }

        public int Code
        {
            get { return this.code; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public string MngFName
        {
            get { return this.mngFName; }
        }

        public string MngLName
        {
            get { return this.mngLName; }
        }

        public Department(int code, string name)
        {
            if( name == "")
            {
                throw new ArgumentException();
            }

            this.code = code;
            this.name = name;
        }

        public Department(int code, string name, int dept_mng_id, string mngFName, string mngLName)
        {
            if (name == "")
            {
                throw new ArgumentException();
            }

            this.code = code;
            this.name = name;
            this.dept_mng_id = dept_mng_id;
            this.mngFName = mngFName;
            this.mngLName = mngLName;
        }

        public Department(int code, string name, int product_num, string category)
        {
            if (name == "")
            {
                throw new ArgumentException();
            }

            this.code = code;
            this.name = name;
            this.product_num = product_num;
            this.category = category;
        }

        public override string ToString()
        {
            return $"Code: {this.code} - {this.name}";
        }

        public string DisplayAssignDManager()
        {
            return $"Code: {this.code} - {this.name} -\t {this.mngFName} {this.mngLName}";
        }

        public string DisplayAssignPCategory()
        {
            return $"{this.name} - {this.category}";
        }
    }
}