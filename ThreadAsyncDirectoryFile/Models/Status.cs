using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadAsyncDirectoryFile.Models
{
    class Status
    {
//        Id  
//- Title
//- Content
//- SharedDate

        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SharedDate { get; set; }
        public Status (DateTime shareddate)
        {
            SharedDate = shareddate;

        }




        public Status( string title, string content)
        {
          
            Title = title;
            Content = content;
            

        }
        public void GetStatusInfo()
        {

        }
    }
}
