namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> likedlist = new List<string>
                {}; //add names in the brackts here
            
            Likes(likedlist);
        }

        static void Likes(List<string> likedlist)
        {
            if(likedlist.Count == 0)
            {
                Console.WriteLine("no one likes this");
            }
            else if(likedlist.Count == 1)
            {
                Console.WriteLine(likedlist[0] + " likes this");
            }
            else if(likedlist.Count == 2)
            {
                Console.WriteLine(likedlist[0] + " and " + likedlist[1] +" like this");
            }
            else if(likedlist.Count == 3)
            {
                Console.WriteLine(likedlist[0] + ", " + likedlist[1] + " and " + likedlist[2] +" like this");
            }
            else
            {
                Console.WriteLine(likedlist[0] + ", " + likedlist[1] + " and " + (likedlist.Count-2) + " others like this");
            }
        }
    }
}