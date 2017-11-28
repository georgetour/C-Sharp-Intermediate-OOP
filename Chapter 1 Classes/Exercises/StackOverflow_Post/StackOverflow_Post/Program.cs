using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow_Post
{
    class Program
    {

        static void Main(string[] args)
        {

            var post = new Post();

            post.PostDetails();

            while (true)
            {
                var input = Int32.Parse(Console.ReadLine());

                if ((input) >= 0)
                {
                    post.upvote(input);
                    post.PostDetails();

                }
                else if ((input) < 0)
                {
                    post.downvote(input);
                    post.PostDetails();
                }
              

            }

        }

    
    }
}
