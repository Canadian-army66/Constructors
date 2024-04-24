using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Kohnen_Christian
{
    class Game //creates the class of Game
    {
        public string title, genre; //vreates string variables
        public Game(string titleParam = "Unknown Title", string genreParam = "Casual") //makes default construstor to Unknown title and Casual
        {
            title = titleParam; //assigns default param to title
            genre = genreParam; //assigns default oparam to genre
        }
    }
}
