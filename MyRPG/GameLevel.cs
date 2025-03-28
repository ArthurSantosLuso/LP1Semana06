using System;
using System.Net.NetworkInformation;
using Humanizer;

namespace MyRPG
{
    public class GameLevel
    {
        private Enemy[] rooms;
        private Hardness difficulty;

        public GameLevel(int numberOfRooms, Hardness difficulty)
        {
            rooms = new Enemy[numberOfRooms];
            this.difficulty = difficulty;
        }

        public void SetEnemyInRoom(int roomIndex, Enemy enemy)
        {
            rooms[roomIndex] = enemy;
        }
        public Hardness GetHardness()
        {
            return difficulty;
        }

        public int GetNumRooms()
        {
            return rooms.Length;
        }

        public int GetNumEnemies()
        {
            int count = 0;
            foreach (var enemy in rooms)
            {
                if (enemy != null)
                {
                    count++;
                }
            }
            return count;
        }

        public void PrintEnemies()
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"Room {((i).ToRoman())}: {rooms[i].GetName()}");
                }
            }
        }
    }
}
