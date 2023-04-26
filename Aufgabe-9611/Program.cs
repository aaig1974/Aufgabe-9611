using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_9611
{
    class Program
    {
        static void Main(string[] args)
        {

            bool[,] myarr = { { false, false, false, false, false }, { false, false, false, true, false }, { false, true, true, true, true }, { false, true, false, false, false }, { false, false, false, false, false } };
            int[] point = { 3 , 1 };
            Console.WriteLine(FindFriends(point, myarr));
            Console.ReadKey();
        }
        //private static int CountIslands(bool[,] arr)
        //{
        //    int count = 0;
        //    for (int i = 0; i < arr.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < arr.GetLength(1); j++)
        //        {
        //            if (!HasFriend(i, j, arr))
        //            {
        //                count++;
        //            }
        //        }

        //    }
        //    return count;
        //}

        //private static List<int[]> FindFriends(int[] coord, bool[,] arr)
        private static int FindFriends(int[] coord, bool[,] arr)
        {
            HashSet<int[]> friend;
            if(friends == null)
            {
                friends = new HashSet<int[]>();
            }
            //if (!friends.Contains(coord))
            //{
            friends.Add(coord);
            int x = coord[0];
            int y = coord[1];
            try
            {
                if (arr[x, y] == arr[x + 1, y])
                {
                    int[] newFriend = { x + 1, y };
                    if (!friends.Contains(newFriend))
                    {
                        friends.Add(newFriend);
                        FindFriends(newFriend, arr);
                    }
                }

            }
            catch (Exception)
            {
            }

            try
            {
                if (arr[x, y] == arr[x - 1, y])
                {
                    int[] newFriend = { x - 1, y };
                    if (!friends.Contains(newFriend))
                    {
                        friends.Add(newFriend);
                        FindFriends(newFriend, arr);
                    }

                }

            }
            catch (Exception)
            {
            }

            try
            {
                if (arr[x, y] == arr[x, y + 1])
                {
                    int[] newFriend = { x, y + 1 };
                    if (!friends.Contains(newFriend))
                    {
                        friends.Add(newFriend);
                        FindFriends(newFriend, arr);
                    }
                }

            }
            catch (Exception)
            {
            }

            try
            {
                if (arr[x, y] == arr[x, y - 1])
                {
                    int[] newFriend = { x, (y - 1) };
                    if (!friends.Contains(newFriend))
                    {
                        friends.Add(newFriend);
                        FindFriends(newFriend, arr);
                    }
                }

            }
            catch (Exception)
            {
            }
            //}

            return friends.Count();
        }
    }
}
