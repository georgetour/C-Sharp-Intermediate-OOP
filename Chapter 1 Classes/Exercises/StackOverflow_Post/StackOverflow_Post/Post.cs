using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow_Post
{
    class Post
    {
        private string title;
        private string description;
        private DateTime created;


        public string Title
        {
            get { title = "C# Rocks"; return title;  }
        }

        public string Description
        {
            get { description = "I want to learn C# in good level so I can leave behind PHP"; return description; }
        }

        public DateTime Created
        {
            get { created = DateTime.Now; return created; }
        }

        public int Votes
        {
            get;
            private set;
        }



        public int upvote(int votes)
        {
            return Votes += votes;
        }


        //If you don't have the - it will add the votes since we are saying to user to write + or - 
        public int downvote(int votes)
        {
            Votes = Votes - (-votes);
            return Votes ;
        }


        public void PostDetails()
        {

            Console.WriteLine
           (String.Format
               ("Post Title: {0}  \n" +
                " Description: {1}  \n" +
                " Created at: {2} \n" +
                " Votes: {3}",
                this.Title,
                this.Description,
                this.Created,
                this.Votes)
           );
            Console.WriteLine("");
            Console.WriteLine("If you write a possitive number you will upvote, if you write negative number you will downvote");

        }


    }
}
