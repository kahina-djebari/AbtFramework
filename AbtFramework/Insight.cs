using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework
{
           public class Insight
        {
            string _author;
            string _title;
            public Insight()
            {

            }

            public string Author
            {
                get
                {
                    return _author;
                }

                set
                {
                    _author = value;
                }
            }

            public string Title
            {
                get
                {
                    return _title;
                }

                set
                {
                    _title = value;
                }
            }
        }
    }

