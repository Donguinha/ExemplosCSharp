using System;
using System.Text;
using System.Collections.Generic;

namespace AulaPosts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Posts> post = new List<Posts>();
            var repeat = "1";
            var i = 0;

            do
            {
                DateTime date = DateTime.Now;

                Console.Write("Post title: ");
                var title = Console.ReadLine();

                Console.Write("Post content: ");
                var content = Console.ReadLine();

                Console.Write("Likes: ");
                var likes = int.Parse(Console.ReadLine());

                post.Add(new Posts(date, title, content, likes));
                //post[0].Comments.Add(new Comment("da123sdasa"));

                Console.WriteLine("Do you want add/remove comment? 0 to add, 1 to remove, 2 to skip");
                var comment = Console.ReadLine();
                if (comment == "0" || comment == "1")
                {
                    do
                    {
                        if (comment == "0")
                        {
                            Console.Write("Comment: ");
                            var commentpost = Console.ReadLine();
                            post[i].Comments.Add(new Comment(commentpost));

                            Console.WriteLine("Do you want add/remove comment? 0 to add, 1 to remove, 2 to skip");
                            comment = Console.ReadLine();
                        }
                        else
                        {
                            var j = 1;
                            foreach (Comment each in post[i].Comments)
                            {
                                Console.WriteLine($"Coment {j}: {each}");
                                j++;
                            }
                            Console.Write("Which one do you want to delete?");
                            var delete = int.Parse(Console.ReadLine());

                            post[i].Comments.RemoveAt(delete - 1);

                            Console.WriteLine("Do you want add/remove comment? 0 to add, 1 to remove, 2 to skip");
                            comment = Console.ReadLine();
                        }

                    } while (comment == "0" || comment == "1");
                    i++;
                }

                Console.WriteLine();
                foreach (Posts each in post)
                {
                    Console.WriteLine(each.ToString());
                }

                Console.WriteLine("Do you want post another one? type 0 for yes");
                repeat = Console.ReadLine();

            } while (repeat == "0");
        }
    }
}
