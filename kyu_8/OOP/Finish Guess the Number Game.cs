using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.OOP;

internal class Finish_Guess_the_Number_Game
{
    private int number;
    private int lives;

    public Finish_Guess_the_Number_Game(int number, int lives)
    {
        this.number = number;
        this.lives = lives;
    }

    public bool Guess(int n)
    {
        if (this.lives == 0)
            throw new Exception();
        if (n == this.number)
            return true;
        this.lives--;
        return false;
    }
}
