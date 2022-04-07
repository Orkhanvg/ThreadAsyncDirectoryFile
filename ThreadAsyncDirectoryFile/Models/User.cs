using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ThreadAsyncDirectoryFile.Models
{
    class User
    {
        public int ID { get; set; }
        public string Username { get; set; }

        List<Status> Statuses = new List<Status>();

        public void StatusesAdd()
        {


        }


        public void ShareStatus(Status status)

        {

            Statuses.Add(status);
        }

        public void GetStatusById()
        {

        }

        public Status GetStatusById(int? id)
        {
            foreach (var item in Statuses)
            {
                if (id == item.ID)
                {
                   return item;
                }
                else
                {
                    throw new Exception("not found");
                }
            }
        }

        public GetAllStatuses()
        {

        }
    }
}
