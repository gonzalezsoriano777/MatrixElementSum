using NUnit.Framework;
using System;

namespace Matrix
{
    public class MatrixElementSumed
    {

        int[,] rooms = new int[,] { { 0, 1, 1, 2 }, { 0, 5, 0, 0 }, { 2, 0, 3, 3 } };

        [Test]
        public void ReturnTheFirstRowsRoom()
        {
            int[,] output = new int[,] { { 0, 1, 1, 2 }, { 0, 5, 0, 0 }, { 2, 0, 3, 3 } };

            Assert.AreEqual(rooms[0, 3], output[0, 3]);
        }
        
        [Test]
        public void GetAllFloorRoomsWithValesSummedUp()
        {
            int[,] output = new int[3,4];
            for(int floor = 0; floor < 3; floor++)
            {
                for(int room = 0; room < 4; room++)
                {
                     
                }
            }
        }
        
        /*
        [Test]
        public bool isHauntedRoom()
        {

            return true;
        }
        */
        
        
    }
}