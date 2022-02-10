using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{

    public class GameMechanics
    {
        public int[,] GameBoard = { { 512, 512, 512, 512 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0,0, 0 } };
        private bool isMoved = true;
        public int moveCounter { get; set; }
        public int Score { get; set; }
        public bool isGameOver { get; set; }
        public bool isGameComplete { get; set; }
        BLayer databaseConfig = new BLayer();
        private bool isInsertet;
        public string timePlayed { get; set; }
        public GameMechanics()
        {
            moveCounter = 0;
            Score = 0;
            isGameOver = false;
            isInsertet = false;
            isGameComplete = false;
        }
        public void randomGenerator()
        {
            if (gameCompleted())
            {
               
                PersonalScore ps = new PersonalScore();
                ps.PL_ID = databaseConfig.getPlayer().PlayerID;
                ps.Score = Score;
                ps.NumberOfMoves = moveCounter;
                ps.TimePlayed = timePlayed;
                ps.DateAndTime = DateTime.Now;

                if (!isInsertet && databaseConfig.insertPlayerScore(ps))
                {
                    isInsertet = true;
                }
                isGameComplete = true;
                updateAchivements();
                return;
            }

            int i, j, random;
            Random r = new Random();
            i = r.Next(4);
            j = r.Next(4);

           

            if (!isBoardFull() && isMoved)
            {

                while (GameBoard[i, j] != 0)
                {
                    i = r.Next(4);
                    j = r.Next(4);
                }
                random = r.Next(6);
                if (random == 5)
                    GameBoard[i, j] = 4;
                else
                    GameBoard[i, j] = 2;

                isMoved = false;
            }
            else if (isBoardFull())
            {
                if (gameOver())
                {
                    
                    PersonalScore ps = new PersonalScore();
                    ps.PL_ID = databaseConfig.getPlayer().PlayerID;
                    ps.Score = Score;
                    ps.NumberOfMoves = moveCounter;
                    ps.TimePlayed = timePlayed;
                    ps.DateAndTime = DateTime.Now;

                    if (!isInsertet&&databaseConfig.insertPlayerScore(ps))
                    {
                        isInsertet = true;
                    }
                    isGameOver = true;
                }
                

            }
        }

        private bool isBoardFull()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (GameBoard[i, j] == 0)
                        return false;
                }
            }
            return true;
        }



       public bool gameOver()
        {
            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (GameBoard[i, j] != 0)
                    {
                        if ((j == 3 && i <= 2) && GameBoard[i, j] == GameBoard[i + 1, j])
                            return false;
                        else if ((i == 3 && j <= 2) && GameBoard[i, j] == GameBoard[i, j + 1])
                            return false;
                        else if ((j < 3 && i < 3) && (GameBoard[i, j] == GameBoard[i, j+1] || GameBoard[i, j] == GameBoard[i+1,j]))
                            return false;


                    }
                }
            }
            return true;
        }

        private void countMovies()
        {
            if (isMoved)
                moveCounter++;
        }

        public bool gameCompleted()
        {
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if (GameBoard[i, j] >= 2048)
                        return true;
                }
            }
            return false;
        }
        public void moveLeft()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (GameBoard[i, j] != 0)
                    {
                        for(int k = j + 1; k < 4; k++)
                        {
                            if (GameBoard[i, j] == GameBoard[i, k])
                            {
                                GameBoard[i, j] += GameBoard[i, k];
                                GameBoard[i, k] = 0;
                                Score += GameBoard[i, j];
                                isMoved = true;
                                break;
                            }
                            else if (GameBoard[i, k] == 0)
                                continue;
                            else if (GameBoard[i, j] != GameBoard[i, k])
                                break;
                        }
                    }
                }
            }

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if(GameBoard[i, j] != 0)
                    {
                        for(int k = j; k > 0; k--)
                        {
                            if (GameBoard[i, k - 1] == 0)
                            {
                                GameBoard[i, k - 1] = GameBoard[i, k];
                                GameBoard[i, k] = 0;
                                isMoved = true;
                            }
                        }
                    }
                }
            }
            countMovies();
            randomGenerator();
        }

        public void moveRight()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (GameBoard[i, j] != 0)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (GameBoard[i, j] == GameBoard[i, k])
                            {
                                GameBoard[i, j] += GameBoard[i, k];
                                GameBoard[i, k] = 0;
                                Score += GameBoard[i, j];
                                isMoved = true;
                                break;
                            }
                            else if (GameBoard[i, k] == 0)
                                continue;
                            else if (GameBoard[i, j] != GameBoard[i, k])
                                break;
                        }
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (GameBoard[i, j] != 0)
                    {
                        for (int k = j; k < 3; k++)
                        {
                            if (GameBoard[i, k + 1] == 0)
                            {
                                GameBoard[i, k + 1] = GameBoard[i, k];
                                GameBoard[i, k] = 0;
                                isMoved = true;
                            }
                        }
                    }
                }
            }
            countMovies();
            randomGenerator();
        }

        public void moveUp()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (GameBoard[j, i] != 0)
                    {
                        for (int k = j + 1; k < 4; k++)
                        {
                            if (GameBoard[j, i] == GameBoard[k, i])
                            {
                                GameBoard[j, i] += GameBoard[k, i];
                                GameBoard[k, i] = 0;
                                Score += GameBoard[j, i];
                                isMoved = true;
                                break;
                            }
                            else if (GameBoard[k, i] == 0)
                                continue;
                            else if (GameBoard[j, i] != GameBoard[k, i])
                                break;
                        }
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (GameBoard[j, i] != 0)
                    {
                        for (int k = j; k > 0; k--)
                        {
                            if (GameBoard[k - 1, i] == 0)
                            {
                                GameBoard[k - 1, i] = GameBoard[k,i];
                                GameBoard[k,i] = 0;
                                isMoved = true;
                            }
                        }
                    }
                }
            }
            countMovies();
            randomGenerator();
        }
        public void moveDown()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (GameBoard[j, i] != 0)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (GameBoard[j, i] == GameBoard[k, i])
                            {
                                GameBoard[j, i] += GameBoard[k, i];
                                GameBoard[k, i] = 0;
                                Score += GameBoard[j, i];
                                isMoved = true;
                                break;
                            }
                            else if (GameBoard[k, i] == 0)
                                continue;
                            else if (GameBoard[j, i] != GameBoard[k, i])
                                break;
                        }
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (GameBoard[j, i] != 0)
                    {
                        for (int k = j; k < 3; k++)
                        {
                            if (GameBoard[k + 1, i] == 0)
                            {
                                GameBoard[k + 1, i] = GameBoard[k, i];
                                GameBoard[k, i] = 0;
                                isMoved = true;
                            }
                        }
                    }
                }
            }
            countMovies();
            randomGenerator();
        }

        public void updateAchivements()
        {
            if (databaseConfig.getAchievement().BetterThanAverageMoves==0&&moveCounter <= 150) //izmeniti kasnije
                databaseConfig.getAchievement().BetterThanAverageMoves = 1;
            if (databaseConfig.getAchievement().BetterThanAverageTime == 0 && moveCounter <= 100) //izmeniti kada time bude dostupan
                databaseConfig.getAchievement().BetterThanAverageTime = 1;
            if (databaseConfig.getAchievement().CompletedGame == 0 && gameCompleted())
                databaseConfig.getAchievement().CompletedGame = 1;

                databaseConfig.insertAchievement();
        }

        public void restartGame()
        {
            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    GameBoard[i, j] = 0;
                }
            }
            moveCounter = 0;
            Score = 0;
            isGameOver = false;
            isMoved = true;
            isInsertet = false;
            isGameComplete = false;
        }


    }


}
