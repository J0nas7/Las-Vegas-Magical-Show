using System;
using System.Collections;
namespace MagicalShow_3rd_HandIn
{
    public class Magician : Person
    {
        // instance variables
        ArrayList favoriteTricks;

        public Magician(string favoriteTrick, string name, string password) : base(name, password)
        {
            this.favoriteTricks = new ArrayList();

            string MagicTrick = favoriteTrick;
            string[] tricks = MagicTrick.Split(',');
            for (int i = 0; i < tricks.Length; i++)
            {
                this.AddFavouriteTrick(tricks[i]);
            }
        }

        public ArrayList FavoriteTricks {
            get => favoriteTricks;
        }

        public void SetFavoriteTricks(string value)
        {
            this.favoriteTricks = new ArrayList();
            string MagicTrick = value;
            string[] tricks = MagicTrick.Split(',');
            for (int i = 0; i < tricks.Length; i++)
            {
                this.AddFavouriteTrick(tricks[i]);
            }
        }

        public void AddFavouriteTrick(string Trick)
        {
            this.favoriteTricks.Add(Trick);
        }

        public override string ToString()
        {
            string result = this.Name+" (ID: "+this.Id+")";
            if (favoriteTricks.Count > 0)
            {
                result += " likes the trick(s): ";
                for (int i = 0; i < favoriteTricks.Count; i++)
                {
                    result += favoriteTricks[i]+", ";
                }
            }
            return result;
        }
    }
}
